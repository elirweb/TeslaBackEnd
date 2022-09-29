using System;
using System.Collections.Generic;
using System.Text;

namespace Tesla.Infra.Common
{
    public interface IRepository: IDisposable
    {
        
    }

    public interface IRepository<T> where T : class {
        void dispose();
    }
}
