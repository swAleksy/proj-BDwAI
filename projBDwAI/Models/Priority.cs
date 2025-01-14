using System.ComponentModel.DataAnnotations;

namespace projBDwAI.Models
{
    public class Priority
    {
        public int Id { get; set; }

        [Required]
        public string Level { get; set; } // Low, Medium, High

        public ICollection<Bug> Bugs { get; set; }
    }

}
