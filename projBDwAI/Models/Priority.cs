namespace projBDwAI.Models
{
    public class Priority
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Bug> Bugs { get; set; }
    }
}
