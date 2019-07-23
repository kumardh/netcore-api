using System;
using System.Collections.Generic;
using System.Linq;
using WebApi.Model;
using Xunit;

namespace WebApi.Tests
{
    public class CalculateDiscountTests
    {

        [Fact]
        public void CalculateDiscount_Test1()
        {
            // Arrange
            var order = new Order()
            {
                Customer = new Customer() { Age = 10 },
                Products = Enumerable.Empty<Product>()
            };

            // Act
            var discount = CalculateDiscount.GetDiscount(9,5);

            // Assert
            Assert.Equal(5, discount);
        }

        

        [Theory]
        [InlineData(5, 5, 5)]
        [InlineData(25, 5, 0)]
        [InlineData(5, 25, 10)]
        public void CalculateDiscount_Test2(int age, int productCount, decimal discount)
        {
            var result = CalculateDiscount.GetDiscount(age, productCount);

            // Assert
            Assert.Equal(discount, result);
        }

        [Fact]
        public void CalculateDiscount_Test3()
        {
            // Arrange
            var order = new Order()
            {
                Customer = new Customer() { Age = 10 },
                Products = Enumerable.Empty<Product>()
            };

            // Act
            var discount = CalculateDiscount.GetDiscount(order);

            // Assert
            Assert.Equal(5, discount);
        }

        [Fact]
        public void CalculateDiscount_Test4()
        {
            // Arrange
            var order = new Order()
            {
                Customer = new Customer() { Age = 10 },
                Products = Enumerable.Empty<Product>()
            };

            // Act
            var discount = CalculateDiscount.GetDiscount(order);

            // Assert
            Assert.Equal(5, discount);
        }

        [Theory]
        [MemberData(nameof(TestDataGenerator.GetOrderFromDataGenerator), MemberType = typeof(TestDataGenerator))]
        public void CalculateDiscount_Test5(Order order,decimal discount)
        {
            // Act
            var result = CalculateDiscount.GetDiscount(order);

            // Assert
            Assert.Equal(discount, result);
        }

        [Fact]
        public void CalculateDiscount_Test6()
        {
            // Arrange
            var order = new Order()
            {
                Customer = new Customer() { Age = 10 },
                Products = null
            };

            // Assert
            Assert.Throws<ArgumentNullException>(() => CalculateDiscount.GetDiscount(order));
        }
    }

    public class TestDataGenerator
    {
        public static IEnumerable<object[]> GetOrderFromDataGenerator()
        {
            yield return new object[]
            {
            new Order()
            {
                Customer = new Customer() { Age = 10 },
                Products = Enumerable.Empty<Product>()
            },
            5
            };

            yield return new object[]
            {
            new Order()
            {
                Customer = new Customer() { Age = 20 },
                Products = Enumerable.Empty<Product>()
            },
            0
            };
        }
    }
}
