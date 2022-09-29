using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using Tesla.Domain.Domain;

namespace Tesla.Infra.Context
{
    public class EfCore: IDisposable
    {
        public IDbConnection Connection { get; }
        public IDbTransaction Transaction { get; set; }
        public readonly IConfiguration configuration;
        public EfCore(IConfiguration config)
        {
            configuration = config;
            Connection = new SqlConnection(Util.Constant.GetStrinConnection);
            Connection.Open();
        }

        public void Dispose()=> Connection.Dispose();
        
    }
}
