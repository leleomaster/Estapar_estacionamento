using Dapper;
using Estapar.estacionamento.domain.Interfaces.IRepositories;
using Estapar.estacionamento.Entities.domain;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Estapar.estacionamento.infrastructure.repository.Repositories
{
    public class MarcaCarroRepository : IMarcaCarroRepository
    {
        private IFactoryConnection _dbConnection;

        private string selecionaTodos = "SP_S_MARCA_CARRO_TODOS";

        public MarcaCarroRepository(IFactoryConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<IEnumerable<MarcaCarroDomain>> ObterListaAsync()
        {
            using (var con = _dbConnection.GetConnection)
            {
                var data = await con.QueryAsync<MarcaCarroDomain>(selecionaTodos, commandType: CommandType.StoredProcedure);

                return data;
            }
        }
    }
}
