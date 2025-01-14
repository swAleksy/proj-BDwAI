using System.ComponentModel.DataAnnotations;

namespace projBDwAI.Models
{
    public class Bug
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public int PriorityId { get; set; }
        public Priority Priority { get; set; }

        [Required]
        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
