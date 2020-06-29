using Dapper;
using Estapar.estacionamento.domain.Interfaces.IRepositories;
using Estapar.estacionamento.Entities.domain;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Estapar.estacionamento.infrastructure.repository.Repositories
{
    public class ModeloCarroRepository : IModeloCarroRepository
    {
        private IFactoryConnection _dbConnection;

        private string selecionaTodos = "SP_S_MODELO_CARRO_TODOS_POR_MARCA";

        public ModeloCarroRepository(IFactoryConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<IEnumerable<ModeloCarroDomain>> ObterListaAsync(int id)
        {
            using (var con = _dbConnection.GetConnection)
            {
                DynamicParameters p = new DynamicParameters();

                p.AddDynamicParams(new { @idMarcaCarro = id });
                var data = await con.QueryAsync<ModeloCarroDomain>(selecionaTodos, param: p, commandType: CommandType.StoredProcedure);

                return data;
            }
        }
    }
}
