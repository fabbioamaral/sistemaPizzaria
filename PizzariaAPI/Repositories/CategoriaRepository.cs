using Microsoft.EntityFrameworkCore;
using PizzariaAPI.Data;
using PizzariaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaAPI.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly PizzariaContexto _context;

        public CategoriaRepository(PizzariaContexto context)
        {
            _context = context;
        }
        public async Task<Categoria> GetCategoriaAsync(int id)
        {
            return await _context.Categorias.FirstOrDefaultAsync(c=>c.CategoriaId==id);
        }

        public async Task<IEnumerable<Categoria>> GetCategoriasAsync()
        {
            return await _context.Categorias.ToListAsync();
        }
    }
}
