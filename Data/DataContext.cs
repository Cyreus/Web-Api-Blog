using Microsoft.EntityFrameworkCore;
using WebUygulaması.Models;

namespace WebUygulaması.Data

{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
                
        }

        public DbSet<Photo> Photos { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }


        
    }

  
}
