using Estapar.estacionamento.Entities.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estapar.estacionamento.domain.Interfaces.IRepositories
{
    public interface IManobraCarroService
    {
        Task<IEnumerable<ManobraCarroDomain>> ObterListaAsync();
        Task<ManobraCarroDomain> ObterPorIdAsync(int id);
        Task<int> InsertAsync(ManobraCarroDomain manobraCarro);
        Task<bool> UpdateAsync(ManobraCarroDomain manobraCarro);
        Task<bool> DeletarAsync(int id);
    }
}
