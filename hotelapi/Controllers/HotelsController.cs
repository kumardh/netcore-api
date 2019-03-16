using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace hotelapi.Controllers
{
    [Route("api/[controller]")]
    public class HotelsController : Controller
    {
        // GET api/hotels
        [HttpGet]
        public IActionResult Get()
        {
            using (var db = new HotelContext())
            {
                return Ok(db.Hotels.ToList());
            }            
        }

        // GET api/hotels/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/hotels
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/hotels/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/hotels/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
