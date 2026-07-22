using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EcoScanAPI.Controllers
{
    public class HealthController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok("EcoScan API is running!");
        } 
    }
}
