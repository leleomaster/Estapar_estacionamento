using Estapar.estacionamento.Entities.domain;
using Estapar.estacionamento.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Estapar.estacionamento.web.Mappers
{
    public static class MapperMarcaCarro
    {
        public static MarcaCarroModelView MarcaCarroDomainToMarcaCarroModelView(MarcaCarroDomain marcaCarro)
        {
            return new MarcaCarroModelView()
            {
                Id = marcaCarro.Id,
                Nome = marcaCarro.Nome
            };
        }

        public static MarcaCarroDomain MarcaCarroModelViewToMarcaCarroDomain(MarcaCarroModelView marcaCarro)
        {
            return new MarcaCarroDomain()
            {
                Id = marcaCarro.Id,
                Nome = marcaCarro.Nome
            };
        }

        public static List<MarcaCarroDomain> ListaMarcaCarroModelViewToListaMarcaCarroDomain(List<MarcaCarroModelView> MarcaCarros)
        {
            List<MarcaCarroDomain> lista = new List<MarcaCarroDomain>();

            foreach (var p in MarcaCarros)
            {
                lista.Add(MarcaCarroModelViewToMarcaCarroDomain(p));
            }

            return lista;
        }

        public static List<MarcaCarroModelView> ListaMarcaCarroDomainToListaMarcaCarroModelView(List<MarcaCarroDomain> MarcaCarros)
        {
            List<MarcaCarroModelView> lista = new List<MarcaCarroModelView>();

            foreach (var p in MarcaCarros)
            {
                lista.Add(MarcaCarroDomainToMarcaCarroModelView(p));
            }

            return lista;
        }
    }
}