using Microsoft.Extensions.DependencyInjection;
using Tesla.Infra.Common;

namespace Tesla.IOC
{
    public class Bootstrap
    {
        public static void Register(IServiceCollection service) 
        {
           
            service.AddScoped(typeof(IRepository<>), typeof(RepositoryBase<>));

            service.AddScoped<Infra.Context.EfCore>();

        }
    }
}
