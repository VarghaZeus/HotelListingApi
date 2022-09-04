using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TermixListing.API.Data.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
                new Country
                {
                    Id = 1,
                    Name = "Texas",
                    ShortName = "SANA"
                },
                new Country
                {
                    Id = 2,
                    Name = "Sterling",
                    ShortName = "SL"
                },
                new Country
                {
                    Id = 3,
                    Name = "Penselvania",
                    ShortName = "EGS"
                }
                );
        }
    }
}
