using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Estapar.estacionamento.web.Models
{
    public class ManobrarCarroModelView
    {
        public int Id { get; set; }
        public PessoaModelView Pessoa { get; set; }
        public ModeloCarroModelView ModeloCarro { get; set; }

        [DisplayName("Modelos do carros")]
        public List<ModeloCarroModelView> ListaModeloCarro { get; set; }
        [DisplayName("Marcas de carros")]
        public List<MarcaCarroModelView> ListaMarcaCarro { get; set; }

        [DisplayName("Pessoas")]       
        public List<PessoaModelView> ListaPessoa { get; set; }

        [DisplayName("Placa")]
        public string Placa { get; set; }

        [DisplayName("Data da manobra")]
        public string Data { get; set; }

        [DisplayName("Ativo")]
        public string Ativo { get; set; }



    }
}