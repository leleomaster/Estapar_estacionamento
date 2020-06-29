using Estapar.estacionamento.domain.Interfaces.IRepositories;
using Estapar.estacionamento.Entities.domain;
using Estapar.estacionamento.infrastructure.repository;
using Estapar.estacionamento.infrastructure.repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estapar.estacionamento.application
{
    public class ManobraCarroService : IManobraCarroService
    {
        IManobraCarroRepository _manobraCarroRepository;
        public ManobraCarroService(IManobraCarroRepository manobraCarroRepository)
        {
            _manobraCarroRepository = manobraCarroRepository;
        }

        public async Task<bool> DeletarAsync(int id)
        {
            var resultado = false;

            //var pessoa = Mapper.Map<PessoaViewModel, PessoaEntity>(t);

            resultado =  await _manobraCarroRepository.DeletarAsync(id);

            return resultado;
        }

        public async Task<int> InsertAsync(ManobraCarroDomain manobraCarro)
        {
            return await _manobraCarroRepository.InsertAsync(manobraCarro);
        }

        public async Task<IEnumerable<ManobraCarroDomain>> ObterListaAsync()
        {
            return await _manobraCarroRepository.ObterListaAsync();
        }

        public async Task<ManobraCarroDomain> ObterPorIdAsync(int id)
        {
            return await _manobraCarroRepository.ObterPorIdAsync(id);
        }

        public async Task<bool> UpdateAsync(ManobraCarroDomain manobraCarro)
        {
            return await _manobraCarroRepository.UpdateAsync(manobraCarro);
        }
    }
}
