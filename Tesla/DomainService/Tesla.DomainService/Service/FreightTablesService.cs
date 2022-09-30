using Tesla.Domain.Domain;
using Tesla.DomainService.Common;
using Tesla.Infra.Common;

namespace Tesla.DomainService.Service
{
    public class FreightTablesService : ServiceBase, Interfaces.IFreightTables
    {
     private Infra.Interfaces.IFreightTablesRepository freightTablesRepository;
        public FreightTablesService(Infra.Interfaces.IFreightTablesRepository freight) : base(freight)
        {
            freightTablesRepository = freight;
        }

        public FreightTable GetFreight(string startZipCode, string endZipCode)
        {
            return freightTablesRepository.GetFreight(startZipCode, endZipCode);
        }
    }
}
