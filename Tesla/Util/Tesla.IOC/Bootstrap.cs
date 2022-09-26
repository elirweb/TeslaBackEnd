using Microsoft.Extensions.DependencyInjection;
using System;
using Tesla.Infra.Common;
using static System.Net.Mime.MediaTypeNames;

namespace Tesla.IOC
{
    public class Bootstrap
    {
        public static void Register(IServiceCollection service) 
        {
            service.AddScoped<Service.IProduct, Service.ProductService> ();

            service.AddScoped(typeof(IRepository<>), typeof(RepositoryBase<>));

            service.AddScoped<Infra.Context.EfCore>();

        }
    }
}
