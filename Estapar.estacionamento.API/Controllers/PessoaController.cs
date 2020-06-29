using Estapar.estacionamento.application;
using Estapar.estacionamento.domain.Interfaces.IRepositories;
using Estapar.estacionamento.Entities.domain;
using Estapar.estacionamento.infrastructure.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Estapar.estacionamento.API.Controllers
{
    [RoutePrefix("api/pessoa")]
    public class PessoaController : ApiController
    {
        private readonly IPessoaService _PessoaService;

        public PessoaController(IPessoaService PessoaService) => _PessoaService = PessoaService;

        [Route("v1/deletar/{id}")]
        public async Task<IHttpActionResult> Delete(int id)
        {
            var resultado = false;

            await BaseExceptionSystem<bool>.BaseHandleExcetion(async () =>
            {
                resultado = await _PessoaService.DeletarAsync(id);
            }, Mensagem.appNameAPI);

            if (resultado)
            {
                return Ok(resultado);
            }
            else
            {
                return BadRequest();
            }
        }

        [Route("v1/inserir")]
        public async Task<IHttpActionResult> Post(PessoaDomain pessoa)
        {
            int resultado = 0;

            await BaseExceptionSystem<bool>.BaseHandleExcetion(async () =>
            {
                    resultado = await _PessoaService.InsertAsync(pessoa);              
            }, Mensagem.appNameAPI);

            if (resultado > 0)
            {
                return Ok(true);
            }
            else
            {
                return BadRequest();
            }
        }

        [Route("v1/atualizar")]
        public async Task<IHttpActionResult> Put(PessoaDomain Pessoa)
        {
            bool resultado = false;

            await BaseExceptionSystem<bool>.BaseHandleExcetion(async () =>
            {
                resultado = await _PessoaService.UpdateAsync(Pessoa);
            }, Mensagem.appNameAPI);

            if (resultado)
            {
                return Ok(true);
            }
            else
            {
                return BadRequest();
            }
        }

        [Route("v1/obterlista")]
        public async Task<IHttpActionResult> Get()
        {
            IEnumerable<PessoaDomain> resultado = null;

            await BaseExceptionSystem<List<PessoaDomain>>.BaseHandleExcetion(async () =>
            {
                resultado = await _PessoaService.ObterListaAsync();

            }, Mensagem.appNameAPI);

            return Ok(resultado);
        }

        [Route("v1/obter/{id}")]
        public async Task<IHttpActionResult> Get(int id)
        {
            PessoaDomain resultado = null;

            await BaseExceptionSystem<PessoaDomain>.BaseHandleExcetion(async () =>
            {
                resultado = await _PessoaService.ObterPorIdAsync(id);

            }, Mensagem.appNameAPI);

            return Ok(resultado);
        }
    }
}
