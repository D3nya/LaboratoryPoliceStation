using PoliceStations.DomainObjects;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;
using PoliceStations.ApplicationServices.Ports.Gateways.Database;

namespace PoliceStations.InfrastructureServices.Gateways.Database
{
    public class PoliceStationEFSqliteGateway : IPoliceStationDatabaseGateway
    {
        private readonly PoliceStationContext _policeStationContext;

        public PoliceStationEFSqliteGateway(PoliceStationContext transportContext)
            => _policeStationContext = transportContext;

        public async Task<PoliceStation> GetPoliceStation(long id)
           => await _policeStationContext.PoliceStations.Where(r => r.Id == id).FirstOrDefaultAsync();

        public async Task<IEnumerable<PoliceStation>> GetAllPoliceStaions()
            => await _policeStationContext.PoliceStations.ToListAsync();
          
        public async Task<IEnumerable<PoliceStation>> QueryPoliceStations(Expression<Func<PoliceStation, bool>> filter)
            => await _policeStationContext.PoliceStations.Where(filter).ToListAsync();

        public async Task AddPoliceStation(PoliceStation policeStation)
        {
            _policeStationContext.PoliceStations.Add(policeStation);
            await _policeStationContext.SaveChangesAsync();
        }

        public async Task UpdatePoliceStation(PoliceStation policeStation)
        {
            _policeStationContext.Entry(policeStation).State = EntityState.Modified;
            await _policeStationContext.SaveChangesAsync();
        }

        public async Task RemovePoliceStation(PoliceStation policeStation)
        {
            _policeStationContext.PoliceStations.Remove(policeStation);
            await _policeStationContext.SaveChangesAsync();
        }
    }
}
