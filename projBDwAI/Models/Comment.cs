using System.ComponentModel.DataAnnotations;

namespace projBDwAI.Models
{
    public class Comment
    {
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public int BugId { get; set; }
        public Bug Bug { get; set; }

        [Required]
        public int UserId { get; set; }
        public User User { get; set; }
    }

}
