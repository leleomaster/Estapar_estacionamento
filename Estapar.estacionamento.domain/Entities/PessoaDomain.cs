using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estapar.estacionamento.Entities.domain
{
    public class PessoaDomain
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Ativo { get; set; }
        public string DataNascimento { get; set; }
        public IList<ManobraCarroDomain> ListaManobraCarro { get; set; }
    }
}
