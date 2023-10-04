using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using WebUygulaması.Data;
using WebUygulaması.Dtos;
using WebUygulaması.Models;

namespace WebUygulaması.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private IAppRepository _appRepository;
        private IMapper _mapper;
        public ProjectsController(IAppRepository appRepository, IMapper mapper)
        {
            _appRepository = appRepository;
            _mapper = mapper;
        }

        public IActionResult GetProjects()
        {
            var projects = _appRepository.GetProjects().ToList();
            var projectsToReturn = _mapper.Map<List<ProjectForListDto>>(projects);    
                
            return Ok(projectsToReturn);


        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add([FromBody]Project project)
        {
            _appRepository.Add(project);
            _appRepository.SaveAll();
            return Ok(project);
        }

        [HttpGet]
        [Route("detail")]
        public IActionResult GetProjectById(int id)
        {
            var project = _appRepository.GetProjectById(id);
            var projectToReturn = _mapper.Map<ProjectForDetailDto>(project);

            return Ok(projectToReturn);


        }

        [HttpGet]
        [Route("Photos")]
        public IActionResult GetPhotosByProject(int id)
        {
            var photos = _appRepository.GetPhotosByProject(id);
            return Ok(photos);
        }
    }
}
