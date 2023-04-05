using Microsoft.AspNetCore.Identity;

namespace AspNet_Assignment.Models.Identity
{
    public class CustomIdentityUser : IdentityUser
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string StreetName { get; set; } = null!; 
        public string PostalCode { get; set; } = null!;   
        public string City { get; set; } = null!;   
   
    }
}
