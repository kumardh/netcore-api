using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace InProcess.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<Result> Get()
        {
            var processName =  System.Diagnostics.Process.GetCurrentProcess().ProcessName;

            var data = new Result()
            {
                RequiredPeriods = new RequiredPeriod[]
                {
                    new RequiredPeriod() { Start = DateTime.Now, End = DateTime.Now.AddDays(20), Data = "sadsafsfdsfdsfdsgfsdgfdg fgdrdfgrgrsrgergrege"},
                    new RequiredPeriod() { Start = DateTime.Now, End = DateTime.Now.AddDays(20), Data = "sadsafsfdsfdsfdsgfsdgfdg fgdrdfgrgrsrgergrege"},
                    new RequiredPeriod() { Start = DateTime.Now, End = DateTime.Now.AddDays(20), Data = "sadsafsfdsfdsfdsgfsdgfdg fgdrdfgrgrsrgergrege"},
                    new RequiredPeriod() { Start = DateTime.Now, End = DateTime.Now.AddDays(20), Data = "sadsafsfdsfdsfdsgfsdgfdg fgdrdfgrgrsrgergrege"},
                    new RequiredPeriod() { Start = DateTime.Now, End = DateTime.Now.AddDays(20), Data = "sadsafsfdsfdsfdsgfsdgfdg fgdrdfgrgrsrgergrege"},
                    new RequiredPeriod() { Start = DateTime.Now, End = DateTime.Now.AddDays(20), Data = "sadsafsfdsfdsfdsgfsdgfdg fgdrdfgrgrsrgergrege"},
                    new RequiredPeriod() { Start = DateTime.Now, End = DateTime.Now.AddDays(20), Data = "sadsafsfdsfdsfdsgfsdgfdg fgdrdfgrgrsrgergrege"},
                    new RequiredPeriod() { Start = DateTime.Now, End = DateTime.Now.AddDays(20), Data = "sadsafsfdsfdsfdsgfsdgfdg fgdrdfgrgrsrgergrege"},
                    new RequiredPeriod() { Start = DateTime.Now, End = DateTime.Now.AddDays(20), Data = "sadsafsfdsfdsfdsgfsdgfdg fgdrdfgrgrsrgergrege"},
                    new RequiredPeriod() { Start = DateTime.Now, End = DateTime.Now.AddDays(20), Data = "sadsafsfdsfdsfdsgfsdgfdg fgdrdfgrgrsrgergrege"},
                    new RequiredPeriod() { Start = DateTime.Now, End = DateTime.Now.AddDays(20), Data = "sadsafsfdsfdsfdsgfsdgfdg fgdrdfgrgrsrgergrege"},
                    new RequiredPeriod() { Start = DateTime.Now, End = DateTime.Now.AddDays(20), Data = "sadsafsfdsfdsfdsgfsdgfdg fgdrdfgrgrsrgergrege"},
                    new RequiredPeriod() { Start = DateTime.Now, End = DateTime.Now.AddDays(20), Data = "sadsafsfdsfdsfdsgfsdgfdg fgdrdfgrgrsrgergrege"},
                    new RequiredPeriod() { Start = DateTime.Now, End = DateTime.Now.AddDays(20), Data = "sadsafsfdsfdsfdsgfsdgfdg fgdrdfgrgrsrgergrege"},
                    new RequiredPeriod() { Start = DateTime.Now, End = DateTime.Now.AddDays(20), Data = "sadsafsfdsfdsfdsgfsdgfdg fgdrdfgrgrsrgergrege"},
                    new RequiredPeriod() { Start = DateTime.Now, End = DateTime.Now.AddDays(20), Data = "sadsafsfdsfdsfdsgfsdgfdg fgdrdfgrgrsrgergrege"},
                    new RequiredPeriod() { Start = DateTime.Now, End = DateTime.Now.AddDays(20), Data = "sadsafsfdsfdsfdsgfsdgfdg fgdrdfgrgrsrgergrege"},
                    new RequiredPeriod() { Start = DateTime.Now, End = DateTime.Now.AddDays(20), Data = "sadsafsfdsfdsfdsgfsdgfdg fgdrdfgrgrsrgergrege"},
                    new RequiredPeriod() { Start = DateTime.Now, End = DateTime.Now.AddDays(20), Data = "sadsafsfdsfdsfdsgfsdgfdg fgdrdfgrgrsrgergrege"},
                    new RequiredPeriod() { Start = DateTime.Now, End = DateTime.Now.AddDays(20), Data = "sadsafsfdsfdsfdsgfsdgfdg fgdrdfgrgrsrgergrege"},
                    new RequiredPeriod() { Start = DateTime.Now, End = DateTime.Now.AddDays(20), Data = "sadsafsfdsfdsfdsgfsdgfdg fgdrdfgrgrsrgergrege"},
                    new RequiredPeriod() { Start = DateTime.Now, End = DateTime.Now.AddDays(20), Data = "sadsafsfdsfdsfdsgfsdgfdg fgdrdfgrgrsrgergrege"},
                    new RequiredPeriod() { Start = DateTime.Now, End = DateTime.Now.AddDays(20), Data = "sadsafsfdsfdsfdsgfsdgfdg fgdrdfgrgrsrgergrege"},
                    new RequiredPeriod() { Start = DateTime.Now, End = DateTime.Now.AddDays(20), Data = "sadsafsfdsfdsfdsgfsdgfdg fgdrdfgrgrsrgergrege"},
                }
            };

            return Ok(data);
        }
    }

    public class Result
    {
        public RequiredPeriod[] RequiredPeriods { get; set; }
    }

    public class RequiredPeriod
    {
        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public string Data { get; set; }
    }
}
