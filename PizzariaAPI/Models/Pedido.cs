using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaAPI.Models
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public decimal ValorItens { get; set; }
        public decimal Desconto { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime DataPedido { get; set; }
        public int FormaDePagamentoId { get; set; }
        public FormaDePagamento FormaDePagamento { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public ICollection<PedidoDetalhes> DetalhesDoPedido { get; set; }
        public int EnderecoId { get; set; }
        public Endereco Endereco { get; set; }
    }
}
