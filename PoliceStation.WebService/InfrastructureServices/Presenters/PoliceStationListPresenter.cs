using PoliceStations.ApplicationServices.GetPoliceStationListUseCase;
using System.Net;
using Newtonsoft.Json;
using PoliceStations.ApplicationServices.Ports;

namespace PoliceStations.InfrastructureServices.Presenters
{
    public class PoliceStationListPresenter : IOutputPort<GetPoliceStationListUseCaseResponse>
    {
        public JsonContentResult ContentResult { get; }

        public PoliceStationListPresenter()
        {
            ContentResult = new JsonContentResult();
        }

        public void Handle(GetPoliceStationListUseCaseResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : HttpStatusCode.NotFound);
            ContentResult.Content = response.Success ? JsonConvert.SerializeObject(response.PoliceStations) : JsonConvert.SerializeObject(response.Message);
        }
    }
}
