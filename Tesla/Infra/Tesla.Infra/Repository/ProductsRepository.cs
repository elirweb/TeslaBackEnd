using System;
using Tesla.Domain.Domain;
using Tesla.Infra.Context;

namespace Tesla.Infra.Repository
{
    public class ProductsRepository : Common.RepositoryBase<Products>, IDisposable
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
