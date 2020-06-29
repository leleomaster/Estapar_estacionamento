using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estapar.estacionamento.Entities.domain
{
    public class ManobraCarroDomain
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public string Data { get; set; }
        public string Ativo { get; set; }
        public ModeloCarroDomain ModeloCarro { get; set; }
        public PessoaDomain Pessoa { get; set; }

    }
}
