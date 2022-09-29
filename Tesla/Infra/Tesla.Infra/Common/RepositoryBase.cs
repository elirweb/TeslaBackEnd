using System;

namespace Tesla.Infra.Common
{
    public class RepositoryBase<T> : IRepository
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
