using Microsoft.AspNetCore.Identity;

namespace Bakery.Models
{
    public class User : IdentityUser
    {
        public string? FirstName;
        public string? LastName;
    }
}
