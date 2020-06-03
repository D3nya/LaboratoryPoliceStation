using System;
using System.Collections.Generic;
using System.Net;
using PoliceStations.DomainObjects;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace PoliceStations.ApplicationServices.Synchronization
{
    public class PoliceStation_Cell
    {
        public int global_id { get; set; }
        public int Number { get; set; }
        public PoliceStation_inf Cells { get; set; }
    }

    public class PoliceStation_inf
    {
        public string Name { get; set; }
        public string AdmArea { get; set; }
        public string Address { get; set; }
        public string ExtraInfo { get; set; }
    }


    public class UseCasePoliceStation
    {
        static string remoteURL = "https://apidata.mos.ru/v1/datasets/2354/rows?api_key=a81609408dea292d2b1278d155511711";

        List<PoliceStation_Cell> policeStation_cells;

        public List<PoliceStation> policeStations = new List<PoliceStation>();

        public UseCasePoliceStation()
        {

            WebRequest request = WebRequest.Create(remoteURL);
            WebResponse response = request.GetResponse();


            StreamReader stream = new StreamReader(response.GetResponseStream());
            string line = stream.ReadToEnd();

            JArray jsonArray = JArray.Parse(line);

            policeStation_cells = JsonConvert.DeserializeObject<List<PoliceStation_Cell>>(jsonArray.ToString());


            for (int i = 0; i < policeStation_cells.Count; i++)
            {
                policeStations.Add(new PoliceStation()
                {
                    Name = policeStation_cells[i].Cells.Name,
                    Id = policeStation_cells[i].Number,
                    AdmArea = policeStation_cells[i].Cells.AdmArea,
                    Address = policeStation_cells[i].Cells.Address,
                    ExtraInfo = policeStation_cells[i].Cells.ExtraInfo
                });
            }
        }

    }
}