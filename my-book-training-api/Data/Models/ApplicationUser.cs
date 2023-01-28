using Microsoft.AspNetCore.Identity;

namespace my_book_training_api.Data.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string Custom { get; set; }
    }
}
