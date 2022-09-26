using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Tesla.Infra.Context;

namespace Tesla.Infra.Common
{
    public class RepositoryBase<T> : IRepository<T> where T : class
    {
        protected readonly EfCore _context;
        protected readonly DbSet<T> Entity = null;

        public RepositoryBase(EfCore ef)
        {
            _context = ef;
            Entity = _context.Set<T>();

        }
        public List<T> Get()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
