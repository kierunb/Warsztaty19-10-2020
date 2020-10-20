using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    // format url:
    // https://server:port/controller/metoda/
     
    [Route("pierwszy")]
    public class PierwszyController : ControllerBase
    {
        private readonly IOsobaService osobaService;

        public PierwszyController(IOsobaService osobaService)
        {
            this.osobaService = osobaService;
        }
        
        // GET: https://server:port/pierwszy/hej 

        [HttpGet("hej")]
        public string Hej()
        {
            return osobaService.GetById(1);
        }

        [HttpGet("osoba")]
        public IActionResult Osoba()
        {
            var osoba = new { Imie = "Heniek", Nazwisko = "Kowalski" };

            // DEPENDENCY INJECTION

            return Ok(osoba);
        }


    }
}
