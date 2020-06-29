using Estapar.estacionamento.Entities.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estapar.estacionamento.domain.Interfaces.IRepositories
{
    public interface IModeloCarroService
    {
        Task<IEnumerable<ModeloCarroDomain>> ObterListaAsync(int idMarcaCarro);
    }
}
