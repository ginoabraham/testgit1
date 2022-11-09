using DotnetCoreSample1.Models.Domain;

namespace DotnetCoreSample1.Repositories
{
    public interface IRegionRepository
    {
        Task<IEnumerable<Region>> GetAllRegionsAsync();
    }
}
