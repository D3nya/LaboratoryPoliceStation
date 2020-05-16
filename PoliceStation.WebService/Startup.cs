using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PoliceStations.InfrastructureServices.Gateways.Database;
using Microsoft.EntityFrameworkCore;
using PoliceStations.ApplicationServices.GetPoliceStationListUseCase;
using PoliceStations.ApplicationServices.Ports.Gateways.Database;
using PoliceStations.ApplicationServices.Repositories;
using PoliceStations.DomainObjects.Ports;

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
            services.AddDbContext<PoliceStationContext>(opts => 
                opts.UseSqlite($"Filename={System.IO.Path.Combine(System.Environment.CurrentDirectory, "PoliceStations.db")}")
            );

            services.AddScoped<IPoliceStationDatabaseGateway, PoliceStationEFSqliteGateway>();

            services.AddScoped<DbPoliceStationRepository>();
            services.AddScoped<IReadOnlyPoliceStationRepository>(x => x.GetRequiredService<DbPoliceStationRepository>());
            services.AddScoped<IPoliceStationRepository>(x => x.GetRequiredService<DbPoliceStationRepository>());

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
