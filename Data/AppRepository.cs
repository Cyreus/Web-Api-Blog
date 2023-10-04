using Microsoft.EntityFrameworkCore;
using WebUygulaması.Models;

namespace WebUygulaması.Data
{
    public class AppRepository : IAppRepository
    {
        private DataContext _context;

        public AppRepository(DataContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T: class
        {
            _context.Remove(entity);
        }

        public bool SaveAll()
        {
            return _context.SaveChanges() > 0;
        }

        public List<Project> GetProjects()
        {
            var projects = _context.Projects.Include(c=>c.Photos).ToList();
            return projects;
        }

        public List<Photo> GetPhotosByProject(int id)
        {
            var photos = _context.Photos.Where(p => p.ProjectId == id).ToList();
            return photos;
        }

        public Project GetProjectById(int projectId)
        {
            var project = _context.Projects.Include(c => c.Photos).FirstOrDefault(c => c.Id == projectId);
            return project;
        }

        public Photo GetPhoto(int id)
        {
            var photo = _context.Photos.FirstOrDefault(p => p.Id == id);
            return photo;
        }
    }
}
