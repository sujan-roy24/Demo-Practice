using Microsoft.AspNetCore.Identity;

namespace MetroSystem.Models
{
    public class Users : IdentityUser
    {
        public string FullName { get; set; }
    }
}
