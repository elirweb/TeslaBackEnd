using Microsoft.EntityFrameworkCore;
using Tesla.Domain.Domain;

namespace Tesla.Infra.Context
{
    public class EfCore: DbContext
    {
        public DbSet<Products> Products { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<FreightTable> FreightTables { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(Util.Constant.GetStrinConnection);
        }
    }
}
