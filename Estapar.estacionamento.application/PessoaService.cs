using Estapar.estacionamento.domain.Interfaces.IRepositories;
using Estapar.estacionamento.Entities.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estapar.estacionamento.application
{
    public class PessoaService : IPessoaService
    {
        IPessoaRepository _PessoaRepository;
        public PessoaService(IPessoaRepository PessoaRepository)
        {
            _PessoaRepository = PessoaRepository;
        }

        public async Task<bool> DeletarAsync(int id)
        {
            var resultado = false;

            resultado = await _PessoaRepository.DeletarAsync(id);

            return resultado;
        }

        public async Task<int> InsertAsync(PessoaDomain pessoa)
        {
            //var pessoa = Mapper.Map<PessoaViewModel, PessoaEntity>(t);
            return await _PessoaRepository.InsertAsync(pessoa);
        }

        public async Task<IEnumerable<PessoaDomain>> ObterListaAsync()
        {
            //var pessoa = Mapper.Map<PessoaViewModel, PessoaEntity>(t);
            return await _PessoaRepository.ObterListaAsync();
        }

        public async Task<PessoaDomain> ObterPorIdAsync(int id)
        {
            //var pessoa = Mapper.Map<PessoaViewModel, PessoaEntity>(t);
            return await _PessoaRepository.ObterPorIdAsync(id);
        }

        public async Task<bool> UpdateAsync(PessoaDomain Pessoa)
        {
            return await _PessoaRepository.UpdateAsync(Pessoa);
        }
    }
}
