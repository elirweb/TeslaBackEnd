using System;
using System.Collections.Generic;
using System.Text;
using Tesla.Infra.Context;

namespace Tesla.Infra.Repository
{
    public class ProductsRepository : Common.RepositoryBase<Domain.Products>, IDisposable
    {
        public ProductsRepository(EfCore ef) : base(ef)
        {
        }

        public void Dispose()
        {
            _context?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
