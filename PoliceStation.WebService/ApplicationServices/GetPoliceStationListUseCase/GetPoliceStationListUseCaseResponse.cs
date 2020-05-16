using PoliceStations.DomainObjects;
using PoliceStations.ApplicationServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PoliceStations.ApplicationServices.GetPoliceStationListUseCase
{
    public class GetPoliceStationListUseCaseResponse : UseCaseResponse
    {
        public IEnumerable<PoliceStation> PoliceStations { get; }

        public GetPoliceStationListUseCaseResponse(IEnumerable<PoliceStation> policeStations) => PoliceStations = policeStations;
    }
}
