using AutoMapper;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DotnetCoreSample1.Profiles
{
    public class RegionsProfile:Profile
    {
        public RegionsProfile()
        {
            CreateMap<Models.Domain.Region, Models.DTO.Region>().ReverseMap();


            // if we want to map the columns one by one if the names dont match
            //CreateMap<Models.Domain.Region, Models.DTO.Region>()
            //    .ForMember(dest => dest.Id, options => options.MapFrom(src => src.Id));
;        }
    }
}
