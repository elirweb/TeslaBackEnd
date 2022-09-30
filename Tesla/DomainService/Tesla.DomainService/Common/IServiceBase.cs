using System;

namespace Tesla.DomainService.Common
{
    public interface IServiceBase : IDisposable
    {
    }
    public interface IServiceBase<T> where T : class, IDisposable
    {

    }
}
