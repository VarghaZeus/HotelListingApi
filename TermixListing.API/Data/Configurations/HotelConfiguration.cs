using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TermixListing.API.Data.Configurations
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Corp",
                    Address = "1059 suvid RD",
                    CountryId = 1,
                    Rating = 5
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Egs Plant",
                    Address = "EGS Suvid RD",
                    CountryId = 2,
                    Rating = 4.4
                },
                new Hotel
                {
                    Id = 3,
                    Name = "SANA PLant",
                    Address = "Suvid RD",
                    CountryId = 3,
                    Rating = 3
                }
                );
        }
    }
}
