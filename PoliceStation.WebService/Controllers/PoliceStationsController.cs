using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PoliceStations.DomainObjects;

namespace PoliceStations.WebService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PoliceStationsController : ControllerBase
    {
        private readonly ILogger<PoliceStationsController> _logger;

        public PoliceStationsController(ILogger<PoliceStationsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<PoliceStation> GetPoliceStations()
        {
            return new List<PoliceStation>() 
            { 
                new PoliceStation()
                {
                    Id = 1,
                    Name = "Участковый пункт полиции № 1 по району Арбат",
                    AdmArea = "Центральный административный округ",
                    District = "район Арбат",
                    Address = "Шубинский переулок, дом 7",
                    ExtraInfo = "ФИО участкового, часы приема можно узнать через специальную форму поиска на сайте petrovka38.ru/Kontaktn…"
                }
            };
        }
    }
}
