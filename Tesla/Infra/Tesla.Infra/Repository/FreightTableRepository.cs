using Dapper;
using System.Linq;
using Tesla.Domain.Domain;
using Tesla.Infra.Context;
using Tesla.Infra.Interfaces;

namespace Tesla.Infra.Repository
{
    public class FreightTableRepository : Common.RepositoryBase<Products>, IFreightTablesRepository
    {
        private EfCore context;

        public FreightTableRepository(EfCore efCore)
        {
            context = efCore;
        }
        public FreightTable GetFreight(string StartZipCode, string endZipCode)
        {
            var query = @"SELECT DeliveryTime [Tempo de Entrega], [Value] as [Valor do Frete]  FROM FreightTable
                            WHERE StartZipCode BETWEEN @StartZipCode AND @endZipCode  "
            ;

            return context.Connection.Query<FreightTable>(query, new { StartZipCode = StartZipCode, endZipCode = endZipCode }).FirstOrDefault();
        }
    }
}
