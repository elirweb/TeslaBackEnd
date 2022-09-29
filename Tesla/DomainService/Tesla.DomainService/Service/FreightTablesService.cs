using System;
using System.Collections.Generic;
using System.Text;
using Tesla.Domain.Domain;
using Tesla.DomainService.Common;
using Tesla.Infra.Common;

namespace Tesla.DomainService.Service
{
    public class FreightTablesService : ServiceBase, DomainService.Interfaces.IFreightTables
    {
        private readonly Domain.Interfaces.IFreightTable freightTable ;
        public FreightTablesService(IRepository repo, Domain.Interfaces.IFreightTable freight) : base(repo)
        {
            freightTable = freight;
        }

        public FreightTable Calculation(string StartZipCode, string endZipCode)
        {
            return freightTable.Calculation(StartZipCode, endZipCode);
        }
    }
}
