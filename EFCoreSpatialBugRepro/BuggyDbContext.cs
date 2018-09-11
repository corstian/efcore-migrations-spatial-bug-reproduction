using Microsoft.EntityFrameworkCore;

namespace EFCoreSpatialBugRepro
{
    class BuggyDbContext : DbContext
    {
        public DbSet<Fly> Flies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\.;Initial Catalog=EFCoreSpatialBugRepro;Integrated Security=True;", q => q.UseNetTopologySuite());
            base.OnConfiguring(optionsBuilder);
        }
    }
}
