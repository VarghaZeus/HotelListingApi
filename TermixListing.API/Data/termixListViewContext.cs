using Microsoft.EntityFrameworkCore;

namespace TermixListing.API.Data
{
    public class termixListViewContext : DbContext
    {
        public termixListViewContext(DbContextOptions options) : base(options)
        {
                
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Texas",
                    ShortName = "SANA"
                },
                new Country
                {
                    Id=2,
                    Name = "Sterling",
                    ShortName = "SL"
                },
                new Country { 
                    Id=3,
                    Name = "Penselvania",
                    ShortName ="EGS"
                }
                );
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name ="Corp",
                    Address = "1059 suvid RD",
                    CountryId = 1,
                    Rating = 5
                },
                new Hotel
                {
                    Id =2,
                    Name ="Egs Plant",
                    Address = "EGS Suvid RD",
                    CountryId=2,
                    Rating = 4.4
                },
                new Hotel
                {
                    Id =3,
                    Name ="SANA PLant",
                    Address = "Suvid RD",
                    CountryId=3,
                    Rating = 3
                }
                );
        }
    }
}
