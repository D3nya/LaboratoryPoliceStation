using PoliceStations.ApplicationServices.Ports.Cache;
using PoliceStations.DomainObjects;
using PoliceStations.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PoliceStations.InfrastructureServices.Repositories
{
    public class NetworkPoliceStationRepository : NetworkRepositoryBase, IReadOnlyPoliceStationRepository
    {
        private readonly IDomainObjectsCache<PoliceStation> _policeStationCache;

        public NetworkPoliceStationRepository(string host, ushort port, bool useTls, IDomainObjectsCache<PoliceStation> policeStationCache)
            : base(host, port, useTls)
            => _policeStationCache = policeStationCache;

        public async Task<PoliceStation> GetPoliceStation(long id)
            => CacheAndReturn(await ExecuteHttpRequest<PoliceStation>($"PoliceStations/{id}"));

        public async Task<IEnumerable<PoliceStation>> GetAllPoliceStations()
            => CacheAndReturn(await ExecuteHttpRequest<IEnumerable<PoliceStation>>($"PoliceStations"), allObjects: true);

        public async Task<IEnumerable<PoliceStation>> QueryPoliceStations(ICriteria<PoliceStation> criteria)
            => CacheAndReturn(await ExecuteHttpRequest<IEnumerable<PoliceStation>>($"PoliceStations"), allObjects: true)
               .Where(criteria.Filter.Compile());

        private IEnumerable<PoliceStation> CacheAndReturn(IEnumerable<PoliceStation> policeStations, bool allObjects = false)
        {
            if (allObjects)
            {
                _policeStationCache.ClearCache();
            }
            _policeStationCache.UpdateObjects(policeStations, DateTime.Now.AddDays(1), allObjects);
            return policeStations;
        }

        private PoliceStation CacheAndReturn(PoliceStation policeStation)
        {
            _policeStationCache.UpdateObject(policeStation, DateTime.Now.AddDays(1));
            return policeStation;
        }
    }
}