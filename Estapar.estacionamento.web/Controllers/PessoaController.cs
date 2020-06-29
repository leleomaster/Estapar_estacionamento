using Estapar.estacionamento.Entities.domain;
using Estapar.estacionamento.web.Communs;
using Estapar.estacionamento.web.Mappers;
using Estapar.estacionamento.web.Models;
using Estapar.estacionamento.web.Resquets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Estapar.estacionamento.web.Controllers
{
    public class PessoaController : Controller
    {
        [HttpGet]
        public ActionResult Lista()
        {
            var resultado = BaseRequest<PessoaDomain>.Get(UrlApi.urlPessoaObter);

            return View(MapperPessoa.ListaPessoaDomainToListaPessoaModelView(resultado));
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(PessoaModelView pessoa)
        {
            BaseRequest<PessoaDomain>.Post(MapperPessoa.PessoaModelViewToPessoaDomain(pessoa), UrlApi.urlPessoaCadastrar);

            return RedirectToAction("Lista");
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
            var resultado = BaseRequest<PessoaDomain>.Get(UrlApi.urlPessoaObterPorId, id, false).FirstOrDefault();

            return View(MapperPessoa.PessoaDomainToPessoaModelView(resultado));
        }

        [HttpPost]
        public ActionResult Editar(PessoaModelView pessoa)
        {
            BaseRequest<PessoaDomain>.Put(MapperPessoa.PessoaModelViewToPessoaDomain(pessoa), UrlApi.urlPessoaAtualizar);

            return RedirectToAction("Lista");
        }

        public ActionResult Detalhar(int id)
        {
            var resultado = BaseRequest<PessoaDomain>.Get(UrlApi.urlPessoaObterPorId, id, false).FirstOrDefault();

            return View(MapperPessoa.PessoaDomainToPessoaModelView(resultado));
        }

        public ActionResult Deletar(int id)
        {
            var resultado = BaseRequest<PessoaDomain>.Delete(id, UrlApi.urlPessoaDeletar);

            return RedirectToAction("Lista");
        }
    }
}