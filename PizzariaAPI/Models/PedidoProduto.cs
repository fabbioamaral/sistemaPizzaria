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
        public Produto Produto { get; private set; }
        public decimal DescontoNoItem { get; set; } = 0;
        public int PedidoId { get; set; }
        public Pedido Pedido { get; private set; }
    }
}
