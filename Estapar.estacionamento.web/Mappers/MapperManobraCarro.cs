using Estapar.estacionamento.Entities.domain;
using Estapar.estacionamento.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Estapar.estacionamento.web.Mappers
{
    public static class MapperManobraCarro
    {
        public static ManobrarCarroModelView ManobraCarroDomainToManobraCarroModelView(ManobraCarroDomain manobraCarro)
        {
            return new ManobrarCarroModelView()
            {
                Id = manobraCarro.Id,
                Data = manobraCarro.Data,
                Placa = manobraCarro.Placa,
                Pessoa = manobraCarro.Pessoa == null ? null : MapperPessoa.PessoaDomainToPessoaModelView(manobraCarro.Pessoa),
                ModeloCarro = manobraCarro.ModeloCarro == null ? null : MapperModeloCarro.ModeloCarroDomainToModeloCarroModelView(manobraCarro.ModeloCarro)
            };
        }

        public static ManobraCarroDomain ManobraCarroModelViewToManobraCarroDomain(ManobrarCarroModelView manobraCarro)
        {
            return new ManobraCarroDomain()
            {
                Id = manobraCarro.Id,
                Data = manobraCarro.Data,
                Placa = manobraCarro.Placa,
                Pessoa = manobraCarro.Pessoa == null ? null : MapperPessoa.PessoaModelViewToPessoaDomain(manobraCarro.Pessoa),
                ModeloCarro = manobraCarro.ModeloCarro == null ? null : MapperModeloCarro.ModeloCarroModelViewToModeloCarroDomain(manobraCarro.ModeloCarro)
            };
        }

        public static List<ManobraCarroDomain> ListaManobraCarroModelViewToListaManobraCarroDomain(List<ManobrarCarroModelView> manobraCarros)
        {
            List<ManobraCarroDomain> lista = new List<ManobraCarroDomain>();

            foreach (var p in manobraCarros)
            {
                lista.Add(ManobraCarroModelViewToManobraCarroDomain(p));
            }

            return lista;
        }

        public static List<ManobrarCarroModelView> ListaManobraCarroDomainToListaManobraCarroModelView(List<ManobraCarroDomain> manobraCarros)
        {
            List<ManobrarCarroModelView> lista = new List<ManobrarCarroModelView>();

            foreach (var p in manobraCarros)
            {
                lista.Add(ManobraCarroDomainToManobraCarroModelView(p));
            }

            return lista;
        }
    }
}