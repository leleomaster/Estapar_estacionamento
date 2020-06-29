using Estapar.estacionamento.domain.Interfaces.IRepositories;
using Estapar.estacionamento.Entities.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estapar.estacionamento.application
{
    public class MarcaCarroService : IMarcaCarroService
    {
        IMarcaCarroRepository _marcaCarroRepository;
        public MarcaCarroService(IMarcaCarroRepository marcaCarroRepository)
        {
            _marcaCarroRepository = marcaCarroRepository;
        }

        public async Task<IEnumerable<MarcaCarroDomain>> ObterListaAsync()
        {
            return await _marcaCarroRepository.ObterListaAsync();
        }
    }
}
