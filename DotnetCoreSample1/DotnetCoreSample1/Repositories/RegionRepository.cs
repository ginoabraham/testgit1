using DotnetCoreSample1.Data;
using DotnetCoreSample1.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace DotnetCoreSample1.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private readonly NZWalksDbContext nZWalksDbContext;

        public RegionRepository(NZWalksDbContext nZWalksDbContext)
        {
            this.nZWalksDbContext = nZWalksDbContext;
        }

        public async Task<IEnumerable<Region>> GetAllRegionsAsync()
        {
            return await nZWalksDbContext.Regions.ToListAsync();
        }

        async Task<Region> IRegionRepository.GetRegionAsync(Guid id)
        {
            return await nZWalksDbContext.Regions.FirstOrDefaultAsync(x => x.Id == id);
;        }

        async Task<Region> IRegionRepository.AddRegionAsync(Region region)
        {

            region.Id = new Guid();
            await nZWalksDbContext.AddAsync(region);
            await nZWalksDbContext.SaveChangesAsync();

            return region;
        }
    }
}
