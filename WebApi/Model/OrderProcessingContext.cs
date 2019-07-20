using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webApi.Model
{
    public class OrderProcessingDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public OrderProcessingDbContext(DbContextOptions<OrderProcessingDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .ToTable("order");
            modelBuilder.Entity<Customer>()
                .ToTable("customer");

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Customer)
                .WithMany(o => o.Orders);
        }
    }
}
