using System.Collections.Generic;
using Tesla.Domain.Domain;

namespace Tesla.DomainService.Interfaces
{
    public interface IProduct
    {
        List<Products> GetAll(string ordination);

        List<Products> BestSaller();

        List<Products> GetProductbyParameter(string parameter);
    }
}
