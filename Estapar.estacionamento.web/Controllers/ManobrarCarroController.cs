using Estapar.estacionamento.Entities.domain;
using Estapar.estacionamento.web.Communs;
using Estapar.estacionamento.web.Models;
using Estapar.estacionamento.web.Patterns.Facades;
using Estapar.estacionamento.web.Resquets;
using System.Web.Mvc;

namespace Estapar.estacionamento.web.Controllers
{
    public class ManobrarCarroController : Controller
    {
        public ActionResult Lista()
        {
            var resultado = BaseRequest<ManobraCarroDomain>.Get(UrlApi.urlManobraCarroObter);

            return View(Mappers.MapperManobraCarro.ListaManobraCarroDomainToListaManobraCarroModelView(resultado));
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            var resultado = ManobraCarroFacade.ManobrarCarroCadastrar(UrlApi.urlMarcaCarroObter, UrlApi.urlPessoaObter);

            return View(resultado);
        }

        [HttpPost]
        public ActionResult Cadastrar(ManobrarCarroModelView manobrarCarro)
        {
            BaseRequest<ManobrarCarroModelView>.Post(manobrarCarro, UrlApi.urlManobraCarroCadastrar);
            return RedirectToAction("Lista");
        }
        
        public ActionResult Detalhar(int id)
        {
            var manobrarCarro = ManobraCarroFacade.ManobrarCarroEditar(UrlApi.urlModeloCarroObter, UrlApi.urlMarcaCarroObter, UrlApi.urlPessoaObter, UrlApi.urlManobraCarroObterPorId, id);

            return View(manobrarCarro);
        }

        public ActionResult Editar(int id)
        {
            var manobrarCarro = ManobraCarroFacade.ManobrarCarroEditar(UrlApi.urlModeloCarroObter,UrlApi.urlMarcaCarroObter, UrlApi.urlPessoaObter, UrlApi.urlManobraCarroObterPorId, id);

            return View(manobrarCarro);
        }

        [HttpPost]
        public ActionResult Editar(ManobrarCarroModelView manobrarCarro)
        {
            BaseRequest<ManobrarCarroModelView>.Put(manobrarCarro, UrlApi.urlManobraCarroAtualizar);

            return RedirectToAction("Lista");
        }

        public ActionResult Deletar(int id)
        {
            BaseRequest<ManobrarCarroModelView>.Delete(id, UrlApi.urlManobraCarroDeletar);

            return RedirectToAction("Lista");
        }
    }
}