using System.ComponentModel.DataAnnotations;

namespace projBDwAI.Models
{
    public class Project
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<Bug> Bugs { get; set; }
    }

}
