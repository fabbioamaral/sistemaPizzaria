using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaAPI.Models
{
    public class TaxaDeEntrega
    {
        public int TaxaDeEntregaId { get; set; }
        public string Bairro { get; set; }
        public decimal Preco { get; set; }
        public ICollection<Endereco> Enderecos { get; private set; }
    }
}
