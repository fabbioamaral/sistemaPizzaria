using Microsoft.EntityFrameworkCore;
using PizzariaAPI.Data;
using PizzariaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaAPI.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly PizzariaContexto _context;

        public ClienteRepository(PizzariaContexto context)
        {
            _context = context;
        }
        
        public async Task CreateClienteAsync(Cliente cliente)
        {
            await _context.Clientes.AddAsync(cliente);
        }

        public async Task DeleteClienteAsync(int id)
        {
            Cliente cliente = await _context.Clientes.FindAsync(id);

            _context.Clientes.Remove(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task<Cliente> GetClienteAsync(int id)
        {
            return await _context.Clientes.FirstOrDefaultAsync(c=>c.ClienteId==id);
        }

        public async Task<IEnumerable<Cliente>> GetClientesAsync()
        {
            return await _context.Clientes.ToListAsync();
        }

        public async Task SaveProduto()
        {
            await _context.SaveChangesAsync();
        }

        public async Task UpdateClienteAsync(Cliente cliente)
        {
            _context.Entry(cliente).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
