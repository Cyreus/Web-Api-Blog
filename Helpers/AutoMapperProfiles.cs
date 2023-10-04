using AutoMapper;
using WebUygulaması.Dtos;
using WebUygulaması.Models;

namespace WebUygulaması.Helpers
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Project, ProjectForListDto>()
                .ForMember(dest=>dest.PhotoUrl, opt =>
                {
                    opt.MapFrom(src=>src.Photos.FirstOrDefault(p=>p.IsMain)!.Url);
                });
            CreateMap<Project, ProjectForDetailDto>();
            CreateMap<PhotoForCreationDto, Photo>();
            CreateMap<PhotoForReturnDto, Photo>();
        }


    }
}
