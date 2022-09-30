using System;
using System.Collections.Generic;
using System.Text;
using Tesla.Domain.Domain;

namespace Tesla.Infra.Interfaces
{
    public interface IProductRepository: Common.IRepository
    {
        List<Products> GetAll(string ordination);

        List<Products> BestSaller();

        List<Products> GetProductbyParameter(string parameter);
    }
}
