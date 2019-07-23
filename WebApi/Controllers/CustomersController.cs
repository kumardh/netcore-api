using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApi.Model;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController
    {
        private OrderProcessingDbContext ctx;
        public CustomersController(OrderProcessingDbContext ctx)
        {
            this.ctx = ctx;
        }

        // GET api/customers
        [HttpGet]
        public ActionResult<IEnumerable<Customer>> Get()
        {
            return ctx.Customers.ToList();
        }

        // POST api/customers
        [HttpPost]
        public void Add([FromBody] Customer c)
        {
            ctx.Customers.Add(c);
            ctx.SaveChanges();
        }

        // PUT api/customers/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Customer c)
        {
            var p = ctx.Customers.FirstOrDefault(o => o.CustomerId == id);
            p.Name = c.Name;
            ctx.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var p = ctx.Customers.FirstOrDefault(o => o.CustomerId == id);
            ctx.Remove(p);
            ctx.SaveChanges();
        }
    }
}
