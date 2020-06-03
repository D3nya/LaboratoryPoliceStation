using Microsoft.EntityFrameworkCore;
using PoliceStations.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;
using PoliceStations.ApplicationServices.Synchronization;

namespace PoliceStations.InfrastructureServices.Gateways.Database
{
    public class PoliceStationContext : DbContext
    {
        public DbSet<PoliceStation> PoliceStations { get; set; }

        public PoliceStationContext(DbContextOptions options)
            : base(options)
        { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var v = new UseCasePoliceStation();

            modelBuilder.Entity<PoliceStation>().HasData(v.policeStations);
        }
    }
}