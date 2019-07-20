using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Model
{
    public class HotelContext : DbContext
    {
        public DbSet<Hotel> Hotels { get; set; }

        public HotelContext(DbContextOptions<HotelContext> options) : base(options)
        { }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=tcp:dkss.database.windows.net,1433;Initial Catalog=hmsdb;Persist Security Info=False;User ID=Dhananjay;Password=Manav2011;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        //    optionsBuilder.UseSqlServer(@"Data Source=DKUMAR04\\SQL2016;Initial Catalog=hmsdb;Integrated Security=True;");
        //}

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
