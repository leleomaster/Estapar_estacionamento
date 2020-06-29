using Dapper;
using Estapar.estacionamento.domain.Interfaces.IRepositories;
using Estapar.estacionamento.Entities.domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Estapar.estacionamento.infrastructure.repository.Repositories
{
    public class PessoaRepository : IPessoaRepository
    {
        private IFactoryConnection _dbConnection;

        private string insere = "SP_I_PESSOA";
        private string atualiza = "SP_U_PESSOA";
        private string deleta = "SP_D_PESSOA";
        private string selecionaTodos = "SP_S_PESSOA_TODOS";
        private string selecionaUm = "SP_S_PESSOA_UM";

        public PessoaRepository(IFactoryConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
        
        public async Task<bool> DeletarAsync(int id)
        {
            using (var con = _dbConnection.GetConnection)
            {
                DynamicParameters p = new DynamicParameters();

                p.AddDynamicParams(new { idPessoa = id });

                return await con.ExecuteAsync(deleta, param: p, commandType: CommandType.StoredProcedure) > 0;
            }
        }

        public async Task<int> InsertAsync(PessoaDomain pessoa)
        {
            using (var con = _dbConnection.GetConnection)
            {
                DynamicParameters p = new DynamicParameters();

                p.AddDynamicParams(new { cpf = pessoa.Cpf });
                p.AddDynamicParams(new { dataNascimento = pessoa.DataNascimento });
                p.AddDynamicParams(new { nome = pessoa.Nome });
                con.Execute(insere, param: p, commandType: CommandType.StoredProcedure);

                return await con.ExecuteAsync(insere, param: p, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<bool> UpdateAsync(PessoaDomain pessoa)
        {
            using (var con = _dbConnection.GetConnection)
            {
                DynamicParameters p = new DynamicParameters();

                p.AddDynamicParams(new { idpessoa = pessoa.Id });
                p.AddDynamicParams(new { cpf = pessoa.Cpf });
                p.AddDynamicParams(new { dataNascimento = pessoa.DataNascimento });
                p.AddDynamicParams(new { nome = pessoa.Nome });

                return await con.ExecuteAsync(atualiza, param: p, commandType: CommandType.StoredProcedure) > 0;
            }
        }

        public async Task<IEnumerable<PessoaDomain>> ObterListaAsync()
        {
            using (var con = _dbConnection.GetConnection)
            {
                var data = await con.QueryAsync<PessoaDomain>(selecionaTodos);

                return data;
            }
        }

        public async Task<PessoaDomain> ObterPorIdAsync(int id)
        {
            using (var con = _dbConnection.GetConnection)
            {
                DynamicParameters p = new DynamicParameters();

                p.AddDynamicParams(new { idPessoa = id });

                var data = await con.QueryAsync<PessoaDomain>(selecionaUm, param: p, commandType: CommandType.StoredProcedure);

                return data.FirstOrDefault();
            }
        }
    }
}
