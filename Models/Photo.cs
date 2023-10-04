namespace WebUygulaması.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public string? Url { get; set; } 
        public int ProjectId { get; set; }
        public string? Description { get; set; } 

        public DateTime DateAdded { get; set; }
        public bool IsMain { get; set; }

        public int PublicId { get; set; }

        public Project? Project { get; set; } 
        public string? ProjectUrl { get; set; }
    }
}
