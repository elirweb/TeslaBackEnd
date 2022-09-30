using System;
using Tesla.Infra.Common;

namespace Tesla.DomainService.Common
{
    public class ServiceBase : IServiceBase, IDisposable
    {
        private readonly IRepository repository;

        public ServiceBase(IRepository repo)
        {
            repository = repo;
        }
        public void Dispose()
        {
            if (repository != null)
            {
                repository.Dispose();
            }
        }
    }
}
