using System;
using System.Collections.Generic;
using System.Text;

namespace Tesla.Service
{
    public interface IProduct
    {
        List<Domain.Products> Get();

        Domain.Products GetById(int id);
    }
}
