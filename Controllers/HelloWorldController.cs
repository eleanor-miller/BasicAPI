using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BasicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        // The name of the method "SayHello" is to be clear to 
        // *me* the programmer. It doesn't tell ASP anything.
        [HttpGet]
        public string SayHello(string who = "World")
        {
            // By adding "World" to method above we no longer need the statement below.
            // string whoOrWorld = (who == null) ? "World" : who;
            return $"Hello, {who}. It is currently {DateTime.Now}";
        }
    }
}