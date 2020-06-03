using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace PoliceStations.DomainObjects.Ports
{
    public interface IReadOnlyPoliceStationRepository
    {
        Task<PoliceStation> GetPoliceStation(long id);

        Task<IEnumerable<PoliceStation>> GetAllPoliceStations();

        Task<IEnumerable<PoliceStation>> QueryPoliceStations(ICriteria<PoliceStation> criteria);

    }

    public interface IPoliceStationRepository
    {
        Task AddPoliceStation(PoliceStation policeStation);

        Task RemovePoliceStation(PoliceStation policeStation);

        Task UpdatePoliceStation(PoliceStation policeStation);
    }
}
