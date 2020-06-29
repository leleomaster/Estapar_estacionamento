using Estapar.estacionamento.application;
using Estapar.estacionamento.domain.Interfaces.IRepositories;
using Estapar.estacionamento.Entities.domain;
using Estapar.estacionamento.infrastructure.repository;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace Estapar.estacionamento.API.Controllers
{
    [RoutePrefix("api/manobraCarro")]
    public class ManobraCarroController : ApiController
    {
        private readonly IManobraCarroService _manobraCarroService;

        // public ManobraCarroController() { }
        public ManobraCarroController(IManobraCarroService manobraCarroService) => _manobraCarroService = manobraCarroService;

        [Route("v1/deletar/{id}")]
        public async Task<IHttpActionResult> Delete(int id)
        {
            var resultado = false;

            await BaseExceptionSystem<bool>.BaseHandleExcetion(async () =>
            {
                resultado = await _manobraCarroService.DeletarAsync(id);
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
        public async Task<IHttpActionResult> Post(ManobraCarroDomain manobraCarro)
        {
            int resultado = 0;

            await BaseExceptionSystem<bool>.BaseHandleExcetion(async () =>
            {
                resultado = await _manobraCarroService.InsertAsync(manobraCarro);
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
        public async Task<IHttpActionResult> Put(ManobraCarroDomain manobraCarro)
        {
            bool resultado = false;

            await BaseExceptionSystem<bool>.BaseHandleExcetion(async () =>
            {
                resultado = await _manobraCarroService.UpdateAsync(manobraCarro);
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
            IEnumerable<ManobraCarroDomain> resultado = null;

            await BaseExceptionSystem<List<ManobraCarroDomain>>.BaseHandleExcetion(async () =>
            {
                resultado = await _manobraCarroService.ObterListaAsync();
            }, Mensagem.appNameAPI);

            return Ok(resultado);
        }

        [Route("v1/obter/{id}")]
        public async Task<IHttpActionResult> Get(int id)
        {
            ManobraCarroDomain resultado = null;

            await BaseExceptionSystem<ManobraCarroDomain>.BaseHandleExcetion(async () =>
            {
                resultado = await _manobraCarroService.ObterPorIdAsync(id);
            }, Mensagem.appNameAPI);

            return Ok(resultado);
        }
    }
}
