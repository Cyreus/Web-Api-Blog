namespace WebUygulaması.Dtos
{
    public class PhotoForCreationDto
    {
        public PhotoForCreationDto()
        {
            DateAdded = DateTime.Now;
        }
        public string? Url { get; set; }
        public string? ProjectUrl { get; set; }
        public string? Description { get; set; }
        public IFormFile? File { get; set; }
        public DateTime DateAdded { get; set; }
        public string?  PublicId { get; set; }

    }
}
