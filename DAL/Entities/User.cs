using Microsoft.AspNetCore.Identity;

namespace HomeEdu.DAL.Entities
{
    public class User : IdentityUser
    {
        public string? Fullname { get; set; }

    }
}
