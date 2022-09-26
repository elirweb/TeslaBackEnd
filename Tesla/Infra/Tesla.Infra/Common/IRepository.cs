using System;
using System.Collections.Generic;
using System.Text;

namespace Tesla.Infra.Common
{
    public interface IRepository<T> where T :class
    {
        List<T> Get();
        T GetById(int id);
    }
}
