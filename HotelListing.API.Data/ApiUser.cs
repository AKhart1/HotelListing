using Microsoft.AspNetCore.Identity;

namespace HotelListing.API.CoreData
{
    public class ApiUser: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
         
    }
}
