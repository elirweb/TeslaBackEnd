using Dapper;
using System.Linq;
using Tesla.Domain.Domain;
using Tesla.Infra.Context;
using Tesla.Infra.Interfaces;

namespace Tesla.Infra.Repository
{
    public class FreightTableRepository : Common.RepositoryBase<FreightTable>, IFreightTablesRepository
    {
        private EfCore context;

        public FreightTableRepository(EfCore efCore)
        {
            context = efCore;
        }
        public FreightTable GetFreight(string StartZipCode, string endZipCode)
        {
            string query = string.Empty;
            
            query = @"SELECT DeliveryTime,  [Value]  FROM FreightTable
                        WHERE StartZipCode BETWEEN @StartZipCode  AND  @endZipCode ";

     
            return context.Connection.Query<FreightTable>(query, new { StartZipCode = StartZipCode, endZipCode = endZipCode }).FirstOrDefault();
        }
    }
}
