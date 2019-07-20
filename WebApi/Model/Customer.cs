using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webApi.Model
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string Name { get; set; }

        public IList<Order> Orders { get; set; }
    }
}
