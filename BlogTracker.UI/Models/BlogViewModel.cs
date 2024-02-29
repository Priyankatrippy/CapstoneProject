namespace BlogTracker.UI.Models
{
    public class BlogViewModel
    {
        public int BlogId { get; set; }
        public string? Title { get; set; }
        public string? Subject { get; set; }
        public DateTime DateOfCreation { get; set; }
        public string? BlogUrl { get; set; }
        public string? EmpEmailId { get; set; }
    }
}
