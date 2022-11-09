using AutoMapper;
using DotnetCoreSample1.Models.Domain;
using DotnetCoreSample1.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DotnetCoreSample1.Controllers
{
    
   

    [ApiController]
    [Route("[controller]")]
    public class RegionsController : Controller
    {
        private readonly IRegionRepository regionRepository;

        public RegionsController(IRegionRepository regionRepository, IMapper mapper)
        {
            this.regionRepository = regionRepository;
            Mapper = mapper;
        }

        public IMapper Mapper { get; }

        [HttpGet]
        public async Task<IActionResult> GetAllRegions()
        {
            
            var regions= await regionRepository.GetAllRegionsAsync();

            //var regionsDTO = new List<Models.DTO.Region>();

            //regions.ToList().ForEach(region =>
            //{
            //    var regionDTO = new Models.DTO.Region()
            //    {
            //        Id = region.Id,
            //        Code = region.Code,
            //        Name = region.Name,
            //        Lat = region.Lat,
            //        Long = region.Long,
            //        Populatioon = region.Populatioon,
            //    };

            //    regionsDTO.Add(regionDTO);

            //}
            //);
            var regionsDTO = Mapper.Map<List<Models.DTO.Region>>(regions);

            return Ok(regionsDTO);
        }
    }
}
