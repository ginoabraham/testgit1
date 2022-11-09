using DotnetCoreSample1.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace DotnetCoreSample1.Data
{
    public class NZWalksDbContext : DbContext
    {
        public NZWalksDbContext(DbContextOptions<NZWalksDbContext> options) : base(options)
            { }

        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulties { get; set; }
    }
}
