namespace WebUygulaması.Dtos
{
    public class PhotoForReturnDto
    {
        public string? Url { get; set; }
        public string? Description { get; set; }
        public int Id { get; set; }
        public bool IsMain { get; set; }
        public DateTime DateAdded { get; set; }
        public string? PublicId { get; set; }
        public string? ProjectUrl { get; set; }
    }
}
