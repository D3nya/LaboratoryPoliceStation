using PoliceStations.ApplicationServices.Ports.Gateways.Database;
using PoliceStations.DomainObjects;
using PoliceStations.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PoliceStations.ApplicationServices.Repositories
{
    public class DbPoliceStationRepository : IReadOnlyPoliceStationRepository,
                                             IPoliceStationRepository
    {
        private readonly IPoliceStationDatabaseGateway _databaseGateway;

        public DbPoliceStationRepository(IPoliceStationDatabaseGateway databaseGateway)
            => _databaseGateway = databaseGateway;

        public async Task<PoliceStation> GetPoliceStation(long id)
            => await _databaseGateway.GetPoliceStation(id);

        public async Task<IEnumerable<PoliceStation>> GetAllPoliceStations()
            => await _databaseGateway.GetAllPoliceStaions();

        public async Task<IEnumerable<PoliceStation>> QueryPoliceStations(ICriteria<PoliceStation> criteria)
            => await _databaseGateway.QueryPoliceStations(criteria.Filter);

        public async Task AddPoliceStation(PoliceStation policeStation)
            => await _databaseGateway.AddPoliceStation(policeStation);

        public async Task RemovePoliceStation(PoliceStation policeStation)
            => await _databaseGateway.RemovePoliceStation(policeStation);

        public async Task UpdatePoliceStation(PoliceStation policeStation)
            => await _databaseGateway.UpdatePoliceStation(policeStation);
    }
}
