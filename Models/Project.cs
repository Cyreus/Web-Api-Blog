using System.Text;

namespace WebUygulaması.Models
{
    public class Project
    {
        public Project()
        {
            Photos = new List<Photo>();
        }
        public int Id { get; set; }
        public int UserId { get; set; } 

        public string Name { get; set; } 
        public string Description { get; set; }  

        public List<Photo> Photos { get; set; }

        public User? User { get; set; }
        
        //{
        //    get
        //    {
        //        return new User{UserName = "Mehmet", Id = 1, PasswordHash = Encoding.ASCII.GetBytes("author"), PasswordSalt = Encoding.ASCII.GetBytes("author"), Projects = new List<Project>()};

        //    }
        //    set
        //    {

        //    } }

    }
}
