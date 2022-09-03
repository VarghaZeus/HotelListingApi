using Microsoft.EntityFrameworkCore;
using TermixListing.API.Contracts;
using TermixListing.API.Data;

namespace TermixListing.API.Repository
{
    public class CountriesRepository : GenericRepository<Country>, ICountriesRepository
    {
        private readonly termixListViewContext _context;

        public CountriesRepository(termixListViewContext context) : base(context)
        {
            this._context = context;
        }

        public async Task<Country> GetDetails(int id)
        {
           return await _context.Countries.Include(q => q.Hotels)
                .FirstOrDefaultAsync(q => q.Id == id);
        }
    }
}
