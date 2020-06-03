using PoliceStations.ApplicationServices.Ports.Cache;
using PoliceStations.DomainObjects;
using PoliceStations.DomainObjects.Ports;
using PoliceStations.DomainObjects.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PoliceStations.ApplicationServices.Repositories
{
    public class CachedReadOnlyPoliceStationRepository : ReadOnlyPoliceStationRepositoryDecorator
    {
        private readonly IDomainObjectsCache<PoliceStation> _policeStationCache;

        public CachedReadOnlyPoliceStationRepository(IReadOnlyPoliceStationRepository policeStationRepository,
                                             IDomainObjectsCache<PoliceStation> policeStationsCache)
            : base(policeStationRepository)
            => _policeStationCache = policeStationsCache;

        public async override Task<PoliceStation> GetPoliceStation(long id)
            => _policeStationCache.GetObject(id) ?? await base.GetPoliceStation(id);

        public async override Task<IEnumerable<PoliceStation>> GetAllPoliceStations()
            => _policeStationCache.GetObjects() ?? await base.GetAllPoliceStations();

        public async override Task<IEnumerable<PoliceStation>> QueryPoliceStations(ICriteria<PoliceStation> criteria)
            => _policeStationCache.GetObjects()?.Where(criteria.Filter.Compile()) ?? await base.QueryPoliceStations(criteria);

    }
}