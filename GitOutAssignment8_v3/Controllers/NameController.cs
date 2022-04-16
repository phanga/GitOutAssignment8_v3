using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitOutAssignment8_v3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    //gabriel phan
    public class NameController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var name = new NameClass();
            name.Name = "Gabriel Phan";
            return Ok(name);
        }
    }
}
