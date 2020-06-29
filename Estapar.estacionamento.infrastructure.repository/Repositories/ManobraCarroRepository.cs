using System.Collections.Generic;
using System.Data;
using Estapar.estacionamento.domain.Interfaces.IRepositories;
using Estapar.estacionamento.Entities.domain;
using Dapper;
using System.Data.SqlClient;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Estapar.estacionamento.infrastructure.repository.Repositories
{
    public class ManobraCarroRepository : IManobraCarroRepository
    {
        private IFactoryConnection _dbConnection;

        private string insere = "SP_I_MANOBRA_CARRO";
        private string atualiza = "SP_U_MANOBRA_CARRO";
        private string deleta = "SP_D_MANOBRA_CARRO";
        private string selecionaTodos = "SP_S_MANOBRA_CARRO_TODOS";
        private string selecionaUm = "SP_S_MANOBRA_CARRO";

        public ManobraCarroRepository(IFactoryConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<bool> DeletarAsync(int id)
        {
            using (var con = _dbConnection.GetConnection)
            {
                DynamicParameters p = new DynamicParameters();

                p.AddDynamicParams(new { idManobraCarro = id });

                return await con.ExecuteAsync(deleta, param: p, commandType: CommandType.StoredProcedure) > 0;
            }
        }

        public async Task<int> InsertAsync(ManobraCarroDomain manobraCarro)
        {
            using (var con = _dbConnection.GetConnection)
            {
                DynamicParameters p = new DynamicParameters();

                p.AddDynamicParams(new { idModeleCarro = manobraCarro.ModeloCarro.Id });
                p.AddDynamicParams(new { placaCarro = manobraCarro.Placa });
                p.AddDynamicParams(new { idPessoa = manobraCarro.Pessoa.Id });

                return await con.ExecuteAsync(insere, param: p, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<IEnumerable<ManobraCarroDomain>> ObterListaAsync()
        {
            using (var con = _dbConnection.GetConnection)
            {
                var data = await  con.QueryAsync<ManobraCarroDomain, PessoaDomain, ModeloCarroDomain, MarcaCarroDomain, ManobraCarroDomain>(
                selecionaTodos,
                (manoCarro, pessoa, modeloCarro, marcaCarro) =>
                {
                    manoCarro.ModeloCarro = modeloCarro;
                    manoCarro.ModeloCarro.MarcaCarro = marcaCarro;
                    manoCarro.Pessoa = pessoa;

                    return manoCarro;
                },
                splitOn: "idPessoa,idModeloCarro,idMarcaCarro"
                );

                return data;
            }
        }

        public async Task<ManobraCarroDomain> ObterPorIdAsync(int id)
        {
            using (var con = _dbConnection.GetConnection)
            {
                DynamicParameters p = new DynamicParameters();

                p.AddDynamicParams(new { idManobraCarro = id });

                var data = await  con.QueryAsync<ManobraCarroDomain, PessoaDomain, ModeloCarroDomain, MarcaCarroDomain, ManobraCarroDomain>(
                selecionaUm,
                (manoCarro, pessoa, modeloCarro, marcaCarro) =>
                {
                    manoCarro.ModeloCarro = modeloCarro;
                    manoCarro.ModeloCarro.MarcaCarro = marcaCarro;
                    manoCarro.Pessoa = pessoa;

                    return manoCarro;
                },
                param: p,
                splitOn: "idPessoa,idModeloCarro,idMarcaCarro",
                commandType: CommandType.StoredProcedure
                );

                return data.FirstOrDefault();
            }
        }

        public async Task<bool> UpdateAsync(ManobraCarroDomain manobraCarro)
        {
            using (var con = _dbConnection.GetConnection)
            {
                DynamicParameters p = new DynamicParameters();

                p.AddDynamicParams(new { idManobraCarro = manobraCarro.Id });
                p.AddDynamicParams(new { idModeleCarro = manobraCarro.ModeloCarro.Id });
                p.AddDynamicParams(new { placaCarro = manobraCarro.Placa });
                p.AddDynamicParams(new { idPessoa = manobraCarro.Pessoa.Id });

                return await con.ExecuteAsync(atualiza, param: p, commandType: CommandType.StoredProcedure) > 0;
            }
        }
    }
}
