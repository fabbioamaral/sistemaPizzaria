using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzariaAPI.Models;

namespace PizzariaAPI.Repositories
{
    public interface IPedidoRepository
    {
        Task<Pedido> GetPedidoAsync(int id);
        Task<IEnumerable<Pedido>> GetPedidosAsync();
        Task CreatePedidoAsync(Pedido pedido);
        Task DeletePedidoAsync(int id);
        Task SavePedido();
    }
}
