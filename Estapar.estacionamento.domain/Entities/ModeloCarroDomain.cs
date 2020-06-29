using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estapar.estacionamento.Entities.domain
{
    public class ModeloCarroDomain
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public MarcaCarroDomain MarcaCarro { get; set; }
    }
}
