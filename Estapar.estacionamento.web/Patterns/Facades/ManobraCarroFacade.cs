using Estapar.estacionamento.Entities.domain;
using Estapar.estacionamento.web.Models;
using Estapar.estacionamento.web.Resquets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Estapar.estacionamento.web.Patterns.Facades
{
    public static class ManobraCarroFacade
    {
        public static ManobrarCarroModelView ManobrarCarroCadastrar(string urlMarcaCarro, string urlPessoa)
        {
            var pessoas = BaseRequest<PessoaDomain>.Get(urlPessoa);
            var marcaCarro = BaseRequest<MarcaCarroDomain>.Get(urlMarcaCarro);

            ManobrarCarroModelView manobrarCarro = new ManobrarCarroModelView
            {
                ListaMarcaCarro = Mappers.MapperMarcaCarro.ListaMarcaCarroDomainToListaMarcaCarroModelView(marcaCarro),
                ListaPessoa = Mappers.MapperPessoa.ListaPessoaDomainToListaPessoaModelView(pessoas),
                ListaModeloCarro = new List<ModeloCarroModelView>()
            };

            return manobrarCarro;
        }

        public static ManobrarCarroModelView ManobrarCarroEditar(string urlModeloCarro, string urlMarcaCarro, string urlPessoa, string urlManobraCarro, int id)
        {
            var pessoas = BaseRequest<PessoaDomain>.Get(urlPessoa);
            var marcaCarro = BaseRequest<MarcaCarroDomain>.Get(urlMarcaCarro);
            var manobrarCarro = BaseRequest<ManobraCarroDomain>.Get(urlManobraCarro, id, false).FirstOrDefault();
            var modeloCarro = BaseRequest<ModeloCarroDomain>.Get(urlModeloCarro, manobrarCarro.ModeloCarro.Id);

            var _manobrarCarro = Mappers.MapperManobraCarro.ManobraCarroDomainToManobraCarroModelView(manobrarCarro);

            _manobrarCarro.ListaPessoa = Mappers.MapperPessoa.ListaPessoaDomainToListaPessoaModelView(pessoas);
            _manobrarCarro.ListaMarcaCarro = Mappers.MapperMarcaCarro.ListaMarcaCarroDomainToListaMarcaCarroModelView(marcaCarro);
            _manobrarCarro.ListaModeloCarro = Mappers.MapperModeloCarro.ListaModeloCarroDomainToListaModeloCarroModelView(modeloCarro);
            _manobrarCarro.ListaModeloCarro.Distinct();

            return _manobrarCarro;
        }
    }
}