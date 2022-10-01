using System.Collections.Generic;
using System.Reflection.Metadata;
using Tesla.Domain.Domain;
using Tesla.DomainService.Common;

namespace Tesla.DomainService.Service
{
    public class ProductService : ServiceBase, DomainService.Interfaces.IProduct
    {
        private readonly Infra.Interfaces.IProductRepository productRepository;
        public ProductService(Infra.Interfaces.IProductRepository product)
            : base(product)
        {
            productRepository = product;
        }
        public List<Products> BestSaller()
        {
            return productRepository.BestSaller();
        }

        public List<Products> GetAll(string ordination)
        {
            return productRepository.GetAll(ordination);
        }

        public Products GetByld(int id)
        {
            return productRepository.GetById(id);
        }

        public List<Products> GetProductbyParameter(string parameter)
        {
            return productRepository.GetProductbyParameter(parameter);
        }
    }
}
