using System.Collections.Generic;
using System.Reflection.Metadata;
using Tesla.Domain.Domain;
using Tesla.DomainService.Interfaces;
namespace Tesla.Aplication.App
{
    public class ProductApp : Interfaces.IProduct
    {
        private readonly DomainService.Interfaces.IProduct _product;

        public ProductApp(IProduct product)
        {
            _product = product;
        }

        public List<Products> BestSaller()
        {
            return _product.BestSaller();
        }

        public List<Products> GetAll(string parameter)
        {
            return _product.GetAll(parameter);
        }

        public Products GetById(int id)
        {
            return _product.GetByld(id);
        }

        public List<Products> GetProductbyParameter(string parameter)
        {
            return _product.GetProductbyParameter(parameter);
        }
    }
}
