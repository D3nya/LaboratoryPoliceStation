using System.Threading.Tasks;
using System.Collections.Generic;
using PoliceStations.DomainObjects;
using PoliceStations.DomainObjects.Ports;
using PoliceStations.ApplicationServices.Ports;

namespace PoliceStations.ApplicationServices.GetPoliceStationListUseCase
{
    public class GetPoliceStationListUseCase : IGetPoliceStationListUseCase
    {
        private readonly IReadOnlyPoliceStationRepository _readOnlyPoliceStationRepository;

        public GetPoliceStationListUseCase(IReadOnlyPoliceStationRepository readOnlyPoliceStationRepository) 
            => _readOnlyPoliceStationRepository = readOnlyPoliceStationRepository;

        public async Task<bool> Handle(GetPoliceStationListUseCaseRequest request, IOutputPort<GetPoliceStationListUseCaseResponse> outputPort)
        {
            IEnumerable<PoliceStation> policeStations = null;
            if (request.PoliceStationId != null)
            {
                var PoliceStation = await _readOnlyPoliceStationRepository.GetPoliceStation(request.PoliceStationId.Value);
                policeStations = (PoliceStation != null) ? new List<PoliceStation>() { PoliceStation } : new List<PoliceStation>();
                
            }
            else if (request.District != null)
            {
                policeStations = await _readOnlyPoliceStationRepository.QueryPoliceStations(new DistrictCriteria(request.District));
            }
            else
            {
                policeStations = await _readOnlyPoliceStationRepository.GetAllPoliceStations();
            }
            outputPort.Handle(new GetPoliceStationListUseCaseResponse(policeStations));
            return true;
        }
    }
}
