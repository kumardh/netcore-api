using System;
using System.Linq;

namespace WebApi.Model
{
    public static class CalculateDiscount
    {
        public static decimal GetDiscount(int age, int productCount)
        {
            var discount = 0;
            if (age <= 15) { discount += 5; }
            if (productCount > 10) { discount += 5; }
            return discount;
        }

        public static decimal GetDiscount(Order order)
        {
            if (order.Products == null) throw new ArgumentNullException();
            var discount = 0;
            if (order.Customer.Age <= 15) { discount += 5; }
            if (order.Products.Count() > 10) { discount += 5; }
            return discount;
        }
    }
}
