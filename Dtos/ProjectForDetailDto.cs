using WebUygulaması.Models;

namespace WebUygulaması.Dtos
{
    public class ProjectForDetailDto
    {

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public List<Photo>? Photos { get; set; }

            
    }
}
