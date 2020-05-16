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
                    Name = "���������� ����� ������� � 1 �� ������ �����",
                    AdmArea = "����������� ���������������� �����",
                    District = "����� �����",
                    Address = "��������� ��������, ��� 7",
                    ExtraInfo = "��� �����������, ���� ������ ����� ������ ����� ����������� ����� ������ �� ����� petrovka38.ru/Kontaktn�"
                    },
                    new PoliceStation()
                    {
                    Id = 2,
                    Name = "���������� ����� ������� � 2 �� ������ �����",
                    AdmArea = "����������� ���������������� �����",
                    District = "����� �����",
                    Address = "������� ���������������� ��������, ��� 3 ",
                    ExtraInfo = "��� �����������, ���� ������ ����� ������ ����� ����������� ����� ������ �� ����� petrovka38.ru/Kontaktn�"
                    },
                    new PoliceStation()
                    {
                    Id = 3,
                    Name = "���������� ����� ������� � 3 �� ������ �����",
                    AdmArea = "����������� ���������������� �����",
                    District = "����� �����",
                    Address = "��������� �������, ��� 12 ",
                    ExtraInfo = "��� �����������, ���� ������ ����� ������ ����� ����������� ����� ������ �� ����� petrovka38.ru/Kontaktn�"
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
