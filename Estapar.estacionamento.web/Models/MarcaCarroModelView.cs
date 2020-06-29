using System.ComponentModel;

namespace Estapar.estacionamento.web.Models
{
    public class MarcaCarroModelView
    {
        public int Id { get; set; }

        [DisplayName("Marca")]
        public string Nome { get; set; }
    }
}