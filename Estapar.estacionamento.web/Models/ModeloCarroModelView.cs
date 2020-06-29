using System.ComponentModel;

namespace Estapar.estacionamento.web.Models
{
    public class ModeloCarroModelView
    {
        public int Id { get; set; }

        [DisplayName("Modelo")]
        public string Nome { get; set; }

        [DisplayName("Marca do carro")]
        public MarcaCarroModelView MarcaCarro { get; set; }
    }
}