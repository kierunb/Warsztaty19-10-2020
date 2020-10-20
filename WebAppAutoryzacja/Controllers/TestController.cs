using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace WebAppAutoryzacja.Controllers
{
    [Route("test")]
    public class TestController : ControllerBase
    {
        
        [Authorize]
        [HttpGet("info")]
        public string Info()
        {       
            var user = this.HttpContext.User;
            
            return this.User.Identity.Name;
        }
    }
}
