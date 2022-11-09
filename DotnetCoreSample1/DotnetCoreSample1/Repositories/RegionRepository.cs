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
    }
}
