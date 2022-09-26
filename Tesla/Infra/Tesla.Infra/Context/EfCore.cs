using Microsoft.EntityFrameworkCore;

namespace Tesla.Infra.Context
{
    public class EfCore: DbContext
    {
        public DbSet<Domain.Products> Products { get; set; }
        public DbSet<Domain.Categories> Categories { get; set; }
        public DbSet<Domain.FreightTable> FreightTables { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(Util.Constant.GetStrinConnection);
        }
    }
}
