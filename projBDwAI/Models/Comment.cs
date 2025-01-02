namespace projBDwAI.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int BugId { get; set; }
        public Bug Bug { get; set; }
    }
}
