using System;
using System.Collections.Generic;
using System.Text;

namespace Tesla.DomainService.Common
{
    public interface IServiceBase: IDisposable
    {
    }
    public interface IServiceBase<T> where T : class, IDisposable {
        
    }
}
