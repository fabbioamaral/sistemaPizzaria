using PizzariaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzariaAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace PizzariaAPI.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly PizzariaContexto _context;

        public PedidoRepository(PizzariaContexto context)
        {
            _context = context;
        }
        public async Task CreatePedidoAsync(Pedido pedido)
        {
            await _context.Pedidos.AddAsync(pedido);
        }

        public async Task DeletePedidoAsync(int id)
        {
            Pedido pedido = await _context.Pedidos.FindAsync(id);

            _context.Pedidos.Remove(pedido);
            await _context.SaveChangesAsync();
        }

        public async Task<Pedido> GetPedidoAsync(int id)
        {
            return await _context.Pedidos.Include(p => p.FormaDePagamento).
                Include(p => p.Cliente).Include(p => p.Endereco).FirstOrDefaultAsync(p=>p.PedidoId==id);
        }

        public async Task<IEnumerable<Pedido>> GetPedidosAsync()
        {
            return await _context.Pedidos.Include(p => p.FormaDePagamento).
                Include(p => p.Cliente).Include(p => p.Endereco).ToListAsync();
        }

        public async Task SavePedido()
        {
            await _context.SaveChangesAsync();
        }
    }
}
