using PizzariaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaAPI.Repositories.Interfaces
{
    public interface IPedidoProduto
    {
        Task<PedidoProduto> GetPedidoProdutoAsync(int id);
        Task<IEnumerable<PedidoProduto>> GetPedidosProdutosAsync();
        Task CreatePedidoProdutoAsync(PedidoProduto pedidoProduto);
        Task UpdatePedidoProdutoAsync(PedidoProduto pedidoProduto);
        Task DeletePedidoProdutoAsync(int id);
        Task SavePedidoProduto();
    }
}
