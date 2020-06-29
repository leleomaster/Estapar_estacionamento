using System;
using System.Data;

namespace Estapar.estacionamento.domain.Interfaces.IRepositories
{
    public interface IFactoryConnection : IDisposable
    {
        IDbConnection GetConnection { get; }
    }
}
