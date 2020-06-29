using Estapar.estacionamento.domain.Interfaces.IRepositories;
using Estapar.estacionamento.Entities.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estapar.estacionamento.application
{
    public class ModeloCarroService : IModeloCarroService
    {
        IModeloCarroRepository _modeloCarroRepository;
        public ModeloCarroService(IModeloCarroRepository modeloCarroRepository)
        {
            _modeloCarroRepository = modeloCarroRepository;
        }

        public async Task<IEnumerable<ModeloCarroDomain>> ObterListaAsync(int idMarcaCarro)
        {
            return await _modeloCarroRepository.ObterListaAsync(idMarcaCarro);
        }
    }
}
