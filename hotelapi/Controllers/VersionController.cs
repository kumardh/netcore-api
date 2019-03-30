using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace hotelapi.Controllers
{
    [Route("api/[controller]")]
    public class VersionController : ControllerBase
    {
        private AppSetting setting;
        public VersionController(IConfiguration config)
        {
            this.setting = config.Get<AppSetting>();
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(new AppInfo() { AppSetting = this.setting });
        }
    }

    public class AppInfo
    {
        public string Application => "hotelapi";
        public string Version => "2.0.0";
        public string Hosting => "InProcess";
        public string ProcessName => System.Diagnostics.Process.GetCurrentProcess().ProcessName;
        public AppSetting AppSetting { set; get; }
    }
}
