using Estapar.estacionamento.application;
using Estapar.estacionamento.Entities.domain;
using Estapar.estacionamento.infrastructure.repository;
using Estapar.estacionamento.web.Models;
using System.Collections.Generic;

namespace Estapar.estacionamento.web.Mappers
{
    public static class MapperPessoa
    {
        public static PessoaModelView PessoaDomainToPessoaModelView(PessoaDomain pessoa)
        {
            return new PessoaModelView()
            {
                Id = pessoa.Id,
                Cpf = pessoa.Cpf,
                DataNascimento = pessoa.DataNascimento,
                Nome = pessoa.Nome
            };
        }

        public static PessoaDomain PessoaModelViewToPessoaDomain(PessoaModelView pessoa)
        {
            return new PessoaDomain()
            {
                Id = pessoa.Id,
                Cpf = pessoa.Cpf,
                DataNascimento = pessoa.DataNascimento,
                Nome = pessoa.Nome
            };
        }

        public static List<PessoaDomain> ListaPessoaModelViewToListaPessoaDomain(List<PessoaModelView> pessoas)
        {
            List<PessoaDomain> lista = new List<PessoaDomain>();

            foreach (var p in pessoas)
            {
                lista.Add(PessoaModelViewToPessoaDomain(p));
            }

            return lista;
        }

        public static List<PessoaModelView> ListaPessoaDomainToListaPessoaModelView(List<PessoaDomain> pessoas)
        {
            List<PessoaModelView> lista = new List<PessoaModelView>();
            
            foreach (var p in pessoas)
            {
                lista.Add(PessoaDomainToPessoaModelView(p));
            }
            
            return lista;
        }
    }
}