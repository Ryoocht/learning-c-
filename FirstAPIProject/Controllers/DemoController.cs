using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FirstAPIProject.Controllers
{
    [Route("api/[controller]")]
    public class DemoController : Controller
    {
        [HttpGet]
        public string SayHelloApi()
        {
            return "Start Adding Database";
        }
    }
}

