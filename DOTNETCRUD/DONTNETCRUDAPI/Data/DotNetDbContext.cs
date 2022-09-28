using DONTNETCRUDAPI.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace DONTNETCRUDAPI.Data
{
    public class DotNetDbContext: DbContext
    {
        public DotNetDbContext(DbContextOptions<DotNetDbContext> options): base(options)
        {

        }

        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }

        public DbSet<WalkDifficulty> walkDifficulties { get; set; }


    }
}
