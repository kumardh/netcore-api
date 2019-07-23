using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Model
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string Name { get; set; }

        [NotMapped]
        public int Age { get; set; }

        public IList<Order> Orders { get; set; }
    }
}
