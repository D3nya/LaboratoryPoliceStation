using PoliceStations.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PoliceStations.ApplicationServices.Ports.Gateways.Database
{
    public interface IPoliceStationDatabaseGateway
    {
        Task AddPoliceStation(PoliceStation policeStation);

        Task RemovePoliceStation(PoliceStation policeStation);

        Task UpdatePoliceStation(PoliceStation policeStation);

        Task<PoliceStation> GetPoliceStation(long id);

        Task<IEnumerable<PoliceStation>> GetAllPoliceStaions();

        Task<IEnumerable<PoliceStation>> QueryPoliceStations(Expression<Func<PoliceStation, bool>> filter);
    }
}
