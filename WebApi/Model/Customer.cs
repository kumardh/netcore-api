using System.Collections.Generic;

namespace WebApi.Model
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public IList<Order> Orders { get; set; }
    }
}
