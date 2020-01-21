using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab0_ED2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Lab0_ED2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private ICRUD IData;

        public WeatherForecastController(ICRUD cRUD)
        {
            IData = cRUD;
        }
        //decorador
        [HttpPost]
        public void Post(Movie Movies) {
            IData.Add(Movies);
        }

        [HttpGet]
        public List<Movie> Get() {
            return IData.ReturnList();
        }

    }
}
