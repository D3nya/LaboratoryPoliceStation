using PoliceStations.ApplicationServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PoliceStations.ApplicationServices.GetPoliceStationListUseCase
{
    public class GetPoliceStationListUseCaseRequest : IUseCaseRequest<GetPoliceStationListUseCaseResponse>
    {
        public string District { get; private set; }
        public long? PoliceStationId { get; private set; }

        private GetPoliceStationListUseCaseRequest()
        { }

        public static GetPoliceStationListUseCaseRequest CreateAllPoliceStationsRequest()
        {
            return new GetPoliceStationListUseCaseRequest();
        }

        public static GetPoliceStationListUseCaseRequest CreatePoliceStationRequest(long PoliceStationId)
        {
            return new GetPoliceStationListUseCaseRequest() { PoliceStationId = PoliceStationId };
        }
        public static GetPoliceStationListUseCaseRequest CreateDistrictPoliceStationRequest(string district)
        {
            return new GetPoliceStationListUseCaseRequest() { District = district };
        }
    }
}
