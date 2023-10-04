using WebUygulaması.Models;

namespace WebUygulaması.Data
{
    public interface IAppRepository
    {
        void Add<T>(T entity) where T:class;
        void Delete<T>(T entity) where T : class;
        bool SaveAll();

        List<Project> GetProjects();

        List<Photo> GetPhotosByProject(int id);

        Project GetProjectById(int projectId);
        Photo GetPhoto(int id);


    }
}
