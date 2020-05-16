using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PoliceStations.DomainObjects;
using PoliceStations.ApplicationServices.GetPoliceStationListUseCase;
using PoliceStations.InfrastructureServices.Presenters;

namespace PoliceStations.InfrastructureServices.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PoliceStationsController : ControllerBase
    {
        private readonly ILogger<PoliceStationsController> _logger;
        private readonly IGetPoliceStationListUseCase _getPoliceStationListUseCase;

        public PoliceStationsController(ILogger<PoliceStationsController> logger,
                                        IGetPoliceStationListUseCase getPoliceStationListUseCase)
        {
            _logger = logger;
            _getPoliceStationListUseCase = getPoliceStationListUseCase;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllPoliceStations()
        {
            var presenter = new PoliceStationListPresenter();
            await _getPoliceStationListUseCase.Handle(GetPoliceStationListUseCaseRequest.CreateAllPoliceStationsRequest(), presenter);
            return presenter.ContentResult;
        }

        [HttpGet("{policeStationId}")]
        public async Task<ActionResult> GetPoliceStation(long policeStationId)
        {
            var presenter = new PoliceStationListPresenter();
            await _getPoliceStationListUseCase.Handle(GetPoliceStationListUseCaseRequest.CreatePoliceStationRequest(policeStationId), presenter);
            return presenter.ContentResult;
        }

        [HttpGet("Districts/{district}")]
        public async Task<ActionResult> GetDistrictFilter(string district)
        {
            var presenter = new PoliceStationListPresenter();
            await _getPoliceStationListUseCase.Handle(GetPoliceStationListUseCaseRequest.CreateDistrictPoliceStationRequest(district), presenter);
            return presenter.ContentResult;
        }
    }
}
