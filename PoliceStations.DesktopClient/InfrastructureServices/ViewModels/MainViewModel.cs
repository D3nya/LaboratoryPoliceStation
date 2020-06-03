using PoliceStations.ApplicationServices.GetPoliceStationListUseCase;
using PoliceStations.ApplicationServices.Ports;
using PoliceStations.DomainObjects;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;

namespace PoliceStations.DesktopClient.InfrastructureServices.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private readonly IGetPoliceStationListUseCase _getPoliceStationListUseCase;

        public MainViewModel(IGetPoliceStationListUseCase getPoliceStationListUseCase)
            => _getPoliceStationListUseCase = getPoliceStationListUseCase;

        private Task<bool> _loadingTask;
        private PoliceStation _currentPoliceStation;
        private ObservableCollection<PoliceStation> _policeStations;

        public event PropertyChangedEventHandler PropertyChanged;

        public PoliceStation CurrentPoliceStation
        {
            get => _currentPoliceStation;
            set
            {
                if (_currentPoliceStation != value)
                {
                    _currentPoliceStation = value;
                    OnPropertyChanged(nameof(CurrentPoliceStation));
                }
            }
        }

        private async Task<bool> LoadPoliceStations()
        {
            var outputPort = new OutputPort();
            bool result = await _getPoliceStationListUseCase.Handle(GetPoliceStationListUseCaseRequest.CreateAllPoliceStationsRequest(), outputPort);
            if (result)
            {
                PoliceStations = new ObservableCollection<PoliceStation>(outputPort.PoliceStations);
            }
            return result;
        }

        public ObservableCollection<PoliceStation> PoliceStations
        {
            get
            {
                if (_loadingTask == null)
                {
                    _loadingTask = LoadPoliceStations();
                }

                return _policeStations;
            }
            set
            {
                if (_policeStations != value)
                {
                    _policeStations = value;
                    OnPropertyChanged(nameof(PoliceStations));
                }
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private class OutputPort : IOutputPort<GetPoliceStationListUseCaseResponse>
        {
            public IEnumerable<PoliceStation> PoliceStations { get; private set; }

            public void Handle(GetPoliceStationListUseCaseResponse response)
            {
                if (response.Success)
                {
                    PoliceStations = new ObservableCollection<PoliceStation>(response.PoliceStations);
                }
            }
        }
    }
}