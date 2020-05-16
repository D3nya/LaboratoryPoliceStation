using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PoliceStations.ApplicationServices.GetPoliceStationListUseCase;
using PoliceStations.ApplicationServices.Repositories;
using PoliceStations.DomainObjects.Ports;
using PoliceStations.DomainObjects;
using System.Collections.Generic;

namespace PoliceStations.WebService
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<InMemoryPoliceStationRepository>(x => new InMemoryPoliceStationRepository(
                new List<PoliceStation> {
                    new PoliceStation()
                    {
                    Id = 1,
                    Name = "Участковый пункт полиции № 1 по району Арбат",
                    AdmArea = "Центральный административный округ",
                    District = "район Арбат",
                    Address = "Шубинский переулок, дом 7",
                    ExtraInfo = "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktn…"
                    },
                    new PoliceStation()
                    {
                    Id = 2,
                    Name = "Участковый пункт полиции № 2 по району Арбат",
                    AdmArea = "Центральный административный округ",
                    District = "район Арбат",
                    Address = "Большой Николопесковский переулок, дом 3 ",
                    ExtraInfo = "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktn…"
                    },
                    new PoliceStation()
                    {
                    Id = 3,
                    Name = "Участковый пункт полиции № 3 по району Арбат",
                    AdmArea = "Центральный административный округ",
                    District = "район Арбат",
                    Address = "Новинский бульвар, дом 12 ",
                    ExtraInfo = "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktn…"
                    }
            }));
            services.AddScoped<IReadOnlyPoliceStationRepository>(x => x.GetRequiredService<InMemoryPoliceStationRepository>());
            services.AddScoped<IPoliceStationRepository>(x => x.GetRequiredService<InMemoryPoliceStationRepository>());

            services.AddScoped<IGetPoliceStationListUseCase, GetPoliceStationListUseCase>();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
