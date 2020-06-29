using System.Collections.Generic;
using System.ComponentModel;

namespace Estapar.estacionamento.web.Models
{
    public class PessoaModelView
    {
        public int Id { get; set; }

        [DisplayName("CPF")]
        public string Cpf { get; set; }

        [DisplayName("Data de nascimento")]
        public string DataNascimento { get; set; }

        [DisplayName("Nome")]
        public string Nome { get; set; }

        [DisplayName("Ativo")]
        public string Ativo { get; set; }


        [DisplayName("Manobra de carros")]
        public IList<ManobrarCarroListaModelView> ListaManobraCarro { get; set; }

        [DisplayName("Modelos do carros")]
        public IList<ModeloCarroModelView> ListaModeloCarro { get; set; }


        [DisplayName("Marcas de carros")]
        public IList<MarcaCarroModelView> ListaMarcaCarro { get; set; }

    }
}