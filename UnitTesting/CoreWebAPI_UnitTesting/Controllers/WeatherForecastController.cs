using BusinessLibrary.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebAPI_UnitTesting.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        ILogin _login;
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogin login)
        {
           // _logger = logger;
            _login = login;
        }
        //public WeatherForecastController(ILogin login)
        //{
        //    _login = login;
        //}
        //public WeatherForecastController()
        //{

        //}

        [Route("climate/{uid}/{pwd}")]
        [HttpGet]
        public List<WeatherForecast> Get([FromRoute] string uid, [FromRoute] string pwd)
        {
            //
            if (_login.Login(uid, pwd))
            {
                var rng = new Random();
                return Enumerable.Range(1, 5).Select(index => new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(index),
                    TemperatureC = rng.Next(-20, 55),
                    Summary = Summaries[rng.Next(Summaries.Length)]
                })
                .ToList();
            }
            else
            {
                throw new UnauthorizedAccessException("Invalid user");
            }
        }
    }
}
