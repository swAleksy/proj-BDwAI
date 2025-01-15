using System.ComponentModel.DataAnnotations;

namespace projBDwAI.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Role { get; set; } // Admin, User

        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }

}
