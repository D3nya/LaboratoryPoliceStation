using Microsoft.Extensions.DependencyInjection;
using PoliceStations.ApplicationServices.GetPoliceStationListUseCase;
using PoliceStations.ApplicationServices.Ports.Cache;
using PoliceStations.ApplicationServices.Repositories;
using PoliceStations.DesktopClient.InfrastructureServices.ViewModels;
using PoliceStations.DomainObjects;
using PoliceStations.DomainObjects.Ports;
using PoliceStations.InfrastructureServices.Cache;
using PoliceStations.InfrastructureServices.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PoliceStations.DesktopClient
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ServiceProvider _serviceProvider;

        public App()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            _serviceProvider = serviceCollection.BuildServiceProvider();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IDomainObjectsCache<PoliceStation>, DomainObjectsMemoryCache<PoliceStation>>();
            services.AddSingleton<NetworkPoliceStationRepository>(
                x => new NetworkPoliceStationRepository("localhost", 80, useTls: false, x.GetRequiredService<IDomainObjectsCache<PoliceStation>>())
            );
            services.AddSingleton<CachedReadOnlyPoliceStationRepository>(
                x => new CachedReadOnlyPoliceStationRepository(
                    x.GetRequiredService<NetworkPoliceStationRepository>(),
                    x.GetRequiredService<IDomainObjectsCache<PoliceStation>>()
                )
            );
            services.AddSingleton<IReadOnlyPoliceStationRepository>(x => x.GetRequiredService<CachedReadOnlyPoliceStationRepository>());
            services.AddSingleton<IGetPoliceStationListUseCase, GetPoliceStationListUseCase>();
            services.AddSingleton<MainViewModel>();
            services.AddSingleton<MainWindow>();
        }

        private void OnStartup(object sender, StartupEventArgs args)
        {
            var mainWindow = _serviceProvider.GetService<MainWindow>();
            mainWindow.Show();
        }
    }
}
