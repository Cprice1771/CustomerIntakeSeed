using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CustomerIntakeStarter.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class ExampleController : ControllerBase {
        public ExampleController() {
        }

        [HttpGet]
        public string Get() {
            return "Hello World";
        }
    }
}
