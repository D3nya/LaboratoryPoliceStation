using PoliceStations.DomainObjects;
using PoliceStations.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PoliceStations.DomainObjects.Repositories
{
    public abstract class ReadOnlyPoliceStationRepositoryDecorator : IReadOnlyPoliceStationRepository
    {
        private readonly IReadOnlyPoliceStationRepository _policeStationRepository;

        public ReadOnlyPoliceStationRepositoryDecorator(IReadOnlyPoliceStationRepository policeStationRepository)
        {
            _policeStationRepository = policeStationRepository;
        }

        public virtual async Task<IEnumerable<PoliceStation>> GetAllPoliceStations()
        {
            return await _policeStationRepository?.GetAllPoliceStations();
        }

        public virtual async Task<PoliceStation> GetPoliceStation(long id)
        {
            return await _policeStationRepository?.GetPoliceStation(id);
        }

        public virtual async Task<IEnumerable<PoliceStation>> QueryPoliceStations(ICriteria<PoliceStation> criteria)
        {
            return await _policeStationRepository?.QueryPoliceStations(criteria);
        }
    }
}

