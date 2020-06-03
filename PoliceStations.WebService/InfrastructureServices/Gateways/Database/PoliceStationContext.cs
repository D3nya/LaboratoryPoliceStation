using Microsoft.EntityFrameworkCore;
using PoliceStations.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

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
            modelBuilder.Entity<PoliceStation>().HasData(
                new PoliceStation()
                {
                    Id = 1,
                    Name = "Участковый пункт полиции № 1 по району Арбат",
                    AdmArea = "Центральный административный округ",
                    Address = "Шубинский переулок, дом 7",
                    ExtraInfo = "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktn…"
                }
                );
        }
        }
    }