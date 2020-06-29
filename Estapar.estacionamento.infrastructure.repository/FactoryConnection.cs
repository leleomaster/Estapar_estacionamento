using Estapar.estacionamento.domain.Interfaces.IRepositories;
using System;
using System.Configuration;
using System.Data;
using System.Data.Common;

namespace Estapar.estacionamento.infrastructure.repository
{
    public class FactoryConnection : IFactoryConnection
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["banco_dados_estapar"].ConnectionString;

        private bool disposed = false;

        public IDbConnection GetConnection
        {
            get
            {
                var factory = DbProviderFactories.GetFactory("System.Data.SqlClient");

                var conn = factory.CreateConnection();

                conn.ConnectionString = connectionString;

                return conn;
            }
        }

        ~FactoryConnection()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Free other state (managed objects).
                }

                disposed = true;
            }
        }
    }
}
