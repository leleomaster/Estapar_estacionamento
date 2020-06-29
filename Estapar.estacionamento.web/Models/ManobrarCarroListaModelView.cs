using System.ComponentModel;

namespace Estapar.estacionamento.web.Models
{
    public class ManobrarCarroListaModelView
    {
        [DisplayName("Manobrar o carro")]
        public ManobrarCarroModelView ManobrarCarro { get; set; }
    }
}