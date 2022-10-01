using System.Collections.Generic;
using Tesla.Domain.Domain;
using Tesla.Infra.Common;

namespace Tesla.DomainService.Interfaces
{
    public interface IProduct: IRepository
    {
        List<Products> GetAll(string parameter);

        List<Products> BestSaller();

        List<Products> GetProductbyParameter(string parameter);
    }
}
