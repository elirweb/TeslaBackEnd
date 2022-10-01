using Dapper;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
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
                            SELECT prod.Id, prod.Name [NameProduto], prod.Price,prod.Photo, cat.Name [NameCategoria] FROM Products prod
                            INNER JOIN Categories cat on cat.Id = prod.CategoryId
                            WHERE prod.Stock  = (prod.Stock - prod.StockReserved) AND prod.Stock >0
                            and Sales= (select Max(Sales) from Products)
                        ";

            return context.Connection.Query<Products>(query).ToList();
        }

        public List<Products> GetAll(string parameter)
        {
            var query = string.Empty;
            if (parameter.Equals("asc")) 
            {
                query = @"SELECT prod.Id, prod.Name [NameProduto], prod.Price,prod.Photo, cat.Name [NameCategoria] FROM Products prod
                        INNER JOIN Categories cat on cat.Id = prod.CategoryId
                        WHERE prod.Stock  = (prod.Stock - prod.StockReserved) AND prod.Stock >0
                        order by prod.Name asc ";
            } 
            else 
            {
                query = @"SELECT prod.Id, prod.Name [NameProduto], prod.Price,prod.Photo, cat.Name as [NameCategoria]  FROM Products prod
                        INNER JOIN Categories cat on cat.Id = prod.CategoryId
                        WHERE prod.Stock  = (prod.Stock - prod.StockReserved) AND prod.Stock >0
                        order by prod.Name desc ";

            }
            
            return context.Connection.Query<Products>(query).ToList();
        }

        public Products GetById(int id)
        {
            var query = string.Empty;
           
                query = @"SELECT prod.Id, prod.Name [NameProduto], prod.Price,prod.Photo, cat.Name as [NameCategoria]  FROM Products prod
                        INNER JOIN Categories cat on cat.Id = prod.CategoryId
                        WHERE prod.Stock  = (prod.Stock - prod.StockReserved) AND prod.Stock >0
                        AND prod.Id = @id
                        order by prod.Name desc ";

            return context.Connection.Query<Products>(query, new {id = id }).FirstOrDefault();
        }

        public List<Products> GetProductbyParameter(string parameter)
        {
            string query = string.Empty;
            if (parameter.Equals("(select Max(Price) from Products)"))
            {
                query = @"SELECT prod.Id, prod.Name [NameProduto], prod.Price,prod.Photo, cat.Name [NameCategoria] FROM Products prod
                            INNER JOIN Categories cat on cat.Id = prod.CategoryId
                            WHERE prod.Stock  = (prod.Stock - prod.StockReserved) AND prod.Stock >0
                            and prod.Price= (select Max(Price) from Products)";
            }
            else {
                query = @"SELECT prod.Id, prod.Name [NameProduto], prod.Price,prod.Photo, cat.Name [NameCategoria] FROM Products prod
                            INNER JOIN Categories cat on cat.Id = prod.CategoryId
                            WHERE prod.Stock  = (prod.Stock - prod.StockReserved) AND prod.Stock >0
                            and Sales= (select Max(Sales) from Products)";
            }
           

            return context.Connection.Query<Products>(query).ToList();
        }
    }
}
