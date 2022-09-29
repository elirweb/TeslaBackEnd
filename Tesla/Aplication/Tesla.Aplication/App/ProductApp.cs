using System.Collections.Generic;
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

        public List<Products> GetAll(string ordination)
        {
            return _product.GetAll(ordination);
        }

        public List<Products> GetProductbyParameter(string parameter)
        {
            return _product.GetProductbyParameter(parameter);
        }
    }
}
