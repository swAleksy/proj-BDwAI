using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace projBDwAI.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }

}
