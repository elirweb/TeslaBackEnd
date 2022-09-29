using Microsoft.Extensions.DependencyInjection;
using Tesla.Infra.Common;

namespace Tesla.IOC
{
    public class Bootstrap
    {
        public static void Register(IServiceCollection service) 
        {

            service.AddScoped<Tesla.Aplication.Interfaces.IProduct, Tesla.Aplication.App.ProductApp>();

            service.AddScoped<Tesla.Aplication.Interfaces.IFreightTables, Tesla.Aplication.App.FreightTablesApp>();


            service.AddScoped<Tesla.DomainService.Interfaces.IProduct, Tesla.DomainService.Service.ProductService> ();

            service.AddScoped<Tesla.DomainService.Interfaces.IFreightTables, Tesla.DomainService.Service.FreightTablesService>();


            service.AddScoped<Tesla.Domain.Interfaces.IProduct, Tesla.Infra.Repository.ProductsRepository>();

            service.AddScoped<Tesla.Domain.Interfaces.IFreightTable, Tesla.Infra.Repository.FreightTableRepository>();


            service.AddScoped(typeof(IRepository<>), typeof(RepositoryBase<>));

            service.AddScoped<Infra.Context.EfCore>();

        }
    }
}
