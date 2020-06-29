using Estapar.estacionamento.Entities.domain;
using Estapar.estacionamento.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Estapar.estacionamento.web.Mappers
{
    public static class MapperModeloCarro
    {
        public static ModeloCarroModelView ModeloCarroDomainToModeloCarroModelView(ModeloCarroDomain modeloCarro)
        {
            return new ModeloCarroModelView()
            {
                Id = modeloCarro.Id,
                Nome = modeloCarro.Nome,
                MarcaCarro = modeloCarro.MarcaCarro == null ? null: MapperMarcaCarro.MarcaCarroDomainToMarcaCarroModelView(modeloCarro.MarcaCarro)
            };
        }

        public static ModeloCarroDomain ModeloCarroModelViewToModeloCarroDomain(ModeloCarroModelView modeloCarro)
        {
            return new ModeloCarroDomain()
            {
                Id = modeloCarro.Id,
                Nome = modeloCarro.Nome,
                MarcaCarro = modeloCarro.MarcaCarro == null ? null : MapperMarcaCarro.MarcaCarroModelViewToMarcaCarroDomain(modeloCarro.MarcaCarro)
            };
        }

        public static List<ModeloCarroDomain> ListaModeloCarroModelViewToListaModeloCarroDomain(List<ModeloCarroModelView> modeloCarros)
        {
            List<ModeloCarroDomain> lista = new List<ModeloCarroDomain>();

            foreach (var p in modeloCarros)
            {
                lista.Add(ModeloCarroModelViewToModeloCarroDomain(p));
            }

            return lista;
        }

        public static List<ModeloCarroModelView> ListaModeloCarroDomainToListaModeloCarroModelView(List<ModeloCarroDomain> modeloCarros)
        {
            List<ModeloCarroModelView> lista = new List<ModeloCarroModelView>();

            foreach (var p in modeloCarros)
            {
                lista.Add(ModeloCarroDomainToModeloCarroModelView(p));
            }

            return lista;
        }
    }
}