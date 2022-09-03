using TermixListing.API.Models.Hotel;

namespace TermixListing.API.Models.Country
{
    public class GetCountryDetailsDto : BaseCountryDto
    {
        public string Id { get; set; }
   
        public List<HotelDto> Hotels { get; set; }
    }


}
