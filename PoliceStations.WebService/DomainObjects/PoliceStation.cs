using System;
using System.Collections.Generic;
using System.Text;

namespace PoliceStations.DomainObjects
{
    public class PoliceStation : DomainObject
    {
        public string Name { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string ExtraInfo { get; set; }
    }
}
