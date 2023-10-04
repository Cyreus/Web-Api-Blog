namespace WebUygulaması.Dtos
{
    public class ProjectForListDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? PhotoUrl { get; set; } 
        public string? ProjectUrl { get; set; }

        public string? Description { get; set; }
    }
}
