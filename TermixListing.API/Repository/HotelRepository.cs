using Microsoft.EntityFrameworkCore;
using TermixListing.API.Contracts;
using TermixListing.API.Data;

namespace TermixListing.API.Repository
{
    public class HotelRepository : GenericRepository<Hotel>, IHotelRepository
    {
        private readonly termixListViewContext _context;
        public HotelRepository(termixListViewContext context) : base(context)
        {
            this._context = context;
        }
        public Task<Hotel> GetDetails(int id)
        { 
            throw new NotImplementedException();
        }
    }
}
