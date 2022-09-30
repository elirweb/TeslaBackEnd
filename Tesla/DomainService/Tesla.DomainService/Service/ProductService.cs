using System.Collections.Generic;
using Tesla.Domain.Domain;
using Tesla.DomainService.Common;

namespace Tesla.DomainService.Service
{
    public class ProductService : ServiceBase, DomainService.Interfaces.IProduct
    {
        private readonly Domain.Interfaces.IProduct product;
        private readonly Infra.Common.IRepository repository;
        public ProductService(Infra.Common.IRepository repo, Domain.Interfaces.IProduct prod)
            : base(repo)
        {
            product = prod;
            repository = repo;
        }
        public List<Products> BestSaller()
        {
            return product.BestSaller();
        }

        public List<Products> GetAll(string ordination)
        {
            return product.GetAll(ordination);
        }

        public List<Products> GetProductbyParameter(string parameter)
        {
            return product.GetProductbyParameter(parameter);
        }
    }
}
