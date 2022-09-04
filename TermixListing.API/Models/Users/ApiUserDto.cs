using System.ComponentModel.DataAnnotations;

namespace TermixListing.API.Models.Users
{
    public class ApiUserDto : LoginDTO
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

    }
}
