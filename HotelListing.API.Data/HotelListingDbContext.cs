using HotelListing.API.CoreData.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.Runtime.InteropServices;

namespace HotelListing.API.CoreData
{
    public class HotelListingDbContext : IdentityDbContext<ApiUser>
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Hotel> Hotels { get; set; } 
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);

            modelbuilder.ApplyConfiguration(new RoleConfiguration());
            modelbuilder.ApplyConfiguration(new CountryConfiguration());
            modelbuilder.ApplyConfiguration(new HotelConfiguration());
        }
    }

    //public class HotelListingDbContextFactory : IDesignTimeDbContextFactory<HotelListingDbContext>
    //{
    //    public HotelListingDbContext CreateDbContext(string[] args)
    //    {
    //        IConfiguration config = new ConfigurationBuilder()
    //             .SetBasePath(Directory.GetCurrentDirectory())
    //             .AddJsonFile("appsettings.json",OptionalAttribute: false, reloadOnChange: true)
    //             .Build();

    //        var optionsBuilder = new DbContextOptionsBuilder<HotelListingDbContext>();
    //        var conn = config.GetConnectionString("HotelListingDbConnectionString");
    //        optionsBuilder.UseSqlServer(conn);
    //        return new HotelListingDbContext(optionsBuilder.Options);
                
    //    }
    //}
}
