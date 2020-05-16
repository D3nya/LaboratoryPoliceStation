﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PoliceStations.InfrastructureServices.Gateways.Database;

namespace PoliceStations.WebService.Migrations
{
    [DbContext(typeof(PoliceStationContext))]
    partial class PoliceStationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4");

            modelBuilder.Entity("PoliceStations.DomainObjects.PoliceStation", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("AdmArea")
                        .HasColumnType("TEXT");

                    b.Property<string>("District")
                        .HasColumnType("TEXT");

                    b.Property<string>("ExtraInfo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("PoliceStations");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Address = "Шубинский переулок, дом 7",
                            AdmArea = "Центральный административный округ",
                            District = "район Арбат",
                            ExtraInfo = "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktn…",
                            Name = "Участковый пункт полиции № 1 по району Арбат"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}