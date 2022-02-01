using PizzariaAPI.Data;
using PizzariaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaAPI.Repositories
{
    public class PedidoProdutoRepository
    {
        //private readonly PizzariaContexto _context;

        //public PedidoProdutoRepository(PizzariaContexto context)
        //{
        //    _context = context;
        //}

        //public async Task CreateClienteAsync(PedidoProduto pedidoProduto)
        //{
        //    await _context.PedidoProduto.AddAsync(pedidoProduto);
        //}

        //public async Task DeleteClienteAsync(int id)
        //{
        //    PedidoProduto pedidoProduto = await _context.Clientes.FindAsync(id);

        //    _context.Clientes.Remove(pedidoProduto);
        //    await _context.SaveChangesAsync();
        //}

        //public async Task<Cliente> GetClienteAsync(int id)
        //{
        //    return await _context.Clientes.FirstOrDefaultAsync(c => c.ClienteId == id);
        //}

        //public async Task<IEnumerable<Cliente>> GetClientesAsync()
        //{
        //    return await _context.Clientes.ToListAsync();
        //}

        //public async Task SaveProduto()
        //{
        //    await _context.SaveChangesAsync();
        //}

        //public async Task UpdateClienteAsync(PedidoProduto pedidoProduto)
        //{
        //    _context.Entry(cliente).State = EntityState.Modified;
        //    await _context.SaveChangesAsync();
        //}
    }
}
