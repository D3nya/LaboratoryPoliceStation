using PoliceStations.DomainObjects;
using PoliceStations.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace PoliceStations.ApplicationServices.GetPoliceStationListUseCase
{
    public class DistrictCriteria : ICriteria<PoliceStation>
    {
        public string District { get; }

        public DistrictCriteria(string district)
            => District = district;

        public Expression<Func<PoliceStation, bool>> Filter
            => (ps => ps.District == District);
    }
}
