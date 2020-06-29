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
    [RoutePrefix("api/marcacarro")]
    public class MarcaCarroController : ApiController
    {
        private readonly IMarcaCarroService _MarcaCarroService;

        public MarcaCarroController(IMarcaCarroService MarcaCarroService) => _MarcaCarroService = MarcaCarroService;


        [Route("v1/obterlista")]
        public async Task<IHttpActionResult> Get()
        {
            IEnumerable<MarcaCarroDomain> resultado = null;

            await BaseExceptionSystem<List<MarcaCarroDomain>>.BaseHandleExcetion(async () =>
             {
                 resultado = await _MarcaCarroService.ObterListaAsync();
             }, Mensagem.appNameAPI);

            return Ok(resultado);
        }
    }
}
