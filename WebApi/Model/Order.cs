using System.Collections.Generic;

namespace WebApi.Model
{
    public class Order
    {
        public int OrderId { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public IEnumerable<Product> Products { get; set; }
    }
}
