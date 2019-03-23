using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hotelapi.Controllers
{
    [Route("api/[controller]")]
    public class VersionController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(new AppInfo());
        }
    }

    public class AppInfo
    {
        public string Application => "hotelapi";
        public string Version => "2.0.0";
        public string Hosting => "InProcess";
        public string ProcessName => System.Diagnostics.Process.GetCurrentProcess().ProcessName;
    }
}
