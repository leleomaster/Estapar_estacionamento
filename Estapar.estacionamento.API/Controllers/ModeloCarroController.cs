using Estapar.estacionamento.application;
using Estapar.estacionamento.domain.Interfaces.IRepositories;
using Estapar.estacionamento.Entities.domain;
using Estapar.estacionamento.infrastructure.repository;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace Estapar.estacionamento.API.Controllers
{
    [RoutePrefix("api/modelocarro")]
    public class ModeloCarroController : ApiController
    {
        private readonly IModeloCarroService _ModeloCarroService;

        public ModeloCarroController(IModeloCarroService ModeloCarroService) => _ModeloCarroService = ModeloCarroService;


        [Route("v1/obterlista/{idMarcaCarro}")]
        public async Task<IHttpActionResult> Get(int idMarcaCarro)
        {
            IEnumerable<ModeloCarroDomain> resultado = null;

            await BaseExceptionSystem<List<ModeloCarroDomain>>.BaseHandleExcetion(async () =>
             {
                 resultado = await _ModeloCarroService.ObterListaAsync(idMarcaCarro);
             }, Mensagem.appNameAPI);

            return Ok(resultado);
        }
    }
}
