using System.ComponentModel.DataAnnotations;

namespace projBDwAI.Models
{
    public class Bug
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(100, ErrorMessage = "Title cannot be longer than 100 characters")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }

        [Required(ErrorMessage = "Priority is required")]
        public int PriorityId { get; set; }
        public Priority Priority { get; set; }
    }
}
