using Dapper;
using System.Collections.Generic;
using System.Linq;
using Tesla.Domain.Domain;
using Tesla.Infra.Context;
using Tesla.Infra.Interfaces;

namespace Tesla.Infra.Repository
{
    public class ProductsRepository : Common.RepositoryBase<Products>, IProductRepository
    {
        private EfCore context;

        public ProductsRepository(EfCore efCore)
        {
            context = efCore;
        }
        public List<Products> BestSaller()
        {
            var query = @"
                            select prod.Id, prod.Name Produto, prod.Price,prod.Photo, cat.Name as [Categoria]  FROM Products prod
                            INNER JOIN Categories cat on cat.Id = prod.CategoryId
                            WHERE prod.Stock  = (prod.Stock - prod.StockReserved) AND prod.Stock >0
                            and Sales= (select Max(Sales) from Products)
                        ";

            return context.Connection.Query<Products>(query).ToList();
        }

        public List<Products> GetAll(string order)
        {
            var query = @"SELECT prod.Id, prod.Name [Produto], prod.Price,prod.Photo, cat.Name Categoria  FROM Products prod
                        INNER JOIN Categories cat on cat.Id = prod.CategoryId
                        WHERE prod.Stock  = (prod.Stock - prod.StockReserved) AND prod.Stock >0
                        order by prod.Name @order ";

            return context.Connection.Query<Products>(query, new { order = order }).ToList();
        }

        public List<Products> GetProductbyParameter(string parameter)
        {
            var query = @"select
                            prod.Id, prod.Name Produto, prod.Price,prod.Photo, cat.Name as [Categoria]  FROM Products prod
                            INNER JOIN Categories cat on cat.Id = prod.CategoryId
                            WHERE prod.Stock  = (prod.Stock - prod.StockReserved) AND prod.Stock >0
                            and prod.Price= @parameter ";

            return context.Connection.Query<Products>(query, new { parameter = parameter }).ToList();
        }
    }
}
