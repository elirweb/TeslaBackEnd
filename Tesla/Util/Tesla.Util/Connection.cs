using Microsoft.EntityFrameworkCore;

namespace Tesla.Util
{
    public class Connection : DbContext
    {
        public Connection(DbContextOptions<Connection> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Constant.GetStrinConnection);
        }
    }
}
