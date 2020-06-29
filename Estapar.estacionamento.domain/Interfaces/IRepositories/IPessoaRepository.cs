using Estapar.estacionamento.Entities.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estapar.estacionamento.domain.Interfaces.IRepositories
{
    public interface IPessoaRepository
    {
        Task<IEnumerable<PessoaDomain>> ObterListaAsync();
        Task<PessoaDomain> ObterPorIdAsync(int id);
        Task<int> InsertAsync(PessoaDomain pessoa);
        Task<bool> UpdateAsync(PessoaDomain pessoa);
        Task<bool> DeletarAsync(int id);
    }
}
