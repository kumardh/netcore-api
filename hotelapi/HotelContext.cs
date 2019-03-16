using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace hotelapi
{
    public class HotelContext : DbContext
    {
        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=tcp:dkss.database.windows.net,1433;Initial Catalog=hmsdb;Persist Security Info=False;User ID=Dhananjay;Password=Manav2011;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hotel>()
                .ToTable("Hotel")
                .HasKey(b => b.HotelId);
        }
    }

    public class Hotel
    {
        public long HotelId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
