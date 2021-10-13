using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaAPI.Models
{
    public class FormaDePagamento
    {
        public int FormaDePagamentoId { get; set; }
        public string FormaDePagamentoNome { get; set; }
        public ICollection<Pedido> Pedidos { get; set; }
    }
}
