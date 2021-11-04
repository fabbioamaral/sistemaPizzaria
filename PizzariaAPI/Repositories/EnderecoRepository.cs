using Microsoft.EntityFrameworkCore;
using PizzariaAPI.Data;
using PizzariaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaAPI.Repositories
{
    public class EnderecoRepository : IEnderecoRepository
    {
        private readonly PizzariaContexto _context;
        public EnderecoRepository(PizzariaContexto context)
        {
            _context = context;
        }

        public async Task CreateEnderecoAsync(Endereco endereco)
        {
            await _context.Enderecos.AddAsync(endereco);
        }

        public async Task DeleteEnderecoAsync(int id)
        {
            Endereco endereco = await _context.Enderecos.FindAsync(id);

            _context.Enderecos.Remove(endereco);
            await _context.SaveChangesAsync();
        }

        public async Task<Endereco> GetEnderecoAsync(int id)
        {
            return await _context.Enderecos.Include(e => e.TaxaDeEntrega)
                .Include(e => e.Cliente).FirstOrDefaultAsync(e=>e.EnderecoId==id);
        }

        public async Task<IEnumerable<Endereco>> GetEnderecosAsync()
        {
            return await _context.Enderecos.Include(e => e.TaxaDeEntrega)
                .Include(e => e.Cliente).ToListAsync();
        }
        public async Task UpdateEnderecoAsync(Endereco endereco)
        {
            _context.Entry(endereco).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task SaveEndereco()
        {
            await _context.SaveChangesAsync();
        }
    }
}
