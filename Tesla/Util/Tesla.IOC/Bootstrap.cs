using Microsoft.Extensions.DependencyInjection;
using Tesla.Domain.Domain;
using Tesla.Infra.Common;

namespace Tesla.IOC
{
    public class Bootstrap
    {
        public static void Register(IServiceCollection service)
        {
            #region App
            service.AddScoped<Aplication.Interfaces.IProduct, Aplication.App.ProductApp>();
            service.AddScoped<Aplication.Interfaces.IFreightTables, Aplication.App.FreightTablesApp>();

            #endregion
            #region Service
            service.AddScoped<DomainService.Interfaces.IProduct, DomainService.Service.ProductService>();
            service.AddScoped<DomainService.Interfaces.IFreightTables, DomainService.Service.FreightTablesService>();
            #endregion

            #region Infra
            service.AddScoped<Infra.Interfaces.IProductRepository, Infra.Repository.ProductsRepository>();
            service.AddScoped<Infra.Interfaces.IFreightTablesRepository, Infra.Repository.FreightTableRepository>();
            #endregion

            #region Db
            service.AddScoped(typeof(IRepository<>), typeof(RepositoryBase<>));
            service.AddScoped<Infra.Context.EfCore>();
            #endregion
        }
    }
}
