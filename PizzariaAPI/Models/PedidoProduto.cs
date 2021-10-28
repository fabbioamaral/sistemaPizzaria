using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaAPI.Models
{
    public class PedidoProduto
    {
        public int PedidoProdutoId { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public decimal DescontoNoItem { get; set; }
        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }
    }
}
