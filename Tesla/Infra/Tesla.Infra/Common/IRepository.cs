using System;

namespace Tesla.Infra.Common
{
    public interface IRepository : IDisposable
    {

    }

    public interface IRepository<T> where T : class
    {
        void dispose();
    }
}
