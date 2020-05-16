using PoliceStations.DomainObjects;
using PoliceStations.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PoliceStations.ApplicationServices.Repositories
{
    public class InMemoryPoliceStationRepository : IReadOnlyPoliceStationRepository,
                                                   IPoliceStationRepository 
    {
        private readonly List<PoliceStation> _policeStation = new List<PoliceStation>();

        public InMemoryPoliceStationRepository(IEnumerable<PoliceStation> policeStations = null)
        {
            if (policeStations != null)
            {
                _policeStation.AddRange(policeStations);
            }
        }

        public Task AddPoliceStation(PoliceStation policeStation)
        {
            _policeStation.Add(policeStation);
            return Task.CompletedTask;
        }

        public Task<IEnumerable<PoliceStation>> GetPoliceStations()
        {
            return Task.FromResult(_policeStation.AsEnumerable());
        }

        public Task<PoliceStation> GetPoliceStation(long id)
        {
            return Task.FromResult(_policeStation.Where(r => r.Id == id).FirstOrDefault());
        }

        public Task<IEnumerable<PoliceStation>> QueryPoliceStation(ICriteria<PoliceStation> criteria)
        {
            return Task.FromResult(_policeStation.Where(criteria.Filter.Compile()).AsEnumerable());
        }

        public Task RemovePoliceStation(PoliceStation policeStation)
        {
            _policeStation.Remove(policeStation);
            return Task.CompletedTask;
        }

        public Task UpdatePoliceStation(PoliceStation policeStation)
        {
            var foundPoliceStation = GetPoliceStation(policeStation.Id).Result;
            if (foundPoliceStation == null)
            {
                AddPoliceStation(policeStation);
            }
            else
            {
                if (foundPoliceStation != policeStation)
                {
                    _policeStation.Remove(foundPoliceStation);
                    _policeStation.Add(policeStation);
                }
            }
            return Task.CompletedTask;
        }
    }
}
