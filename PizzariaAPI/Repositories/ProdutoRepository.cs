using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PizzariaAPI.Data;
using PizzariaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaAPI.Repositories
{
    public class ProdutoRepository : IProdutosRepository
    {
        private readonly PizzariaContexto _context;

        public ProdutoRepository(PizzariaContexto context)
        {
            _context = context;
        }

        public async Task CreateProdutoAsync(Produto produto)
        {
            await _context.Produtos.AddAsync(produto);
        }

        public async Task DeleteProdutoAsync(int id)
        {
            Produto produto = await _context.Produtos.FindAsync(id);

            _context.Produtos.Remove(produto);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Produto>> GetProdutosAsync()
        {
            return await _context.Produtos.Include(p => p.Categoria).ToListAsync();
            //Include eager loading: carregar a informação de Categoria do produto
        }

        public async Task<Produto> GetProdutoAsync(int id)
        {
            return await _context.Produtos.Include(p => p.Categoria).FirstOrDefaultAsync(p => p.ProdutoId == id);
        }


        public async Task UpdateProdutoAsync(Produto produto)
        {
            _context.Entry(produto).State = EntityState.Modified;
            await _context.SaveChangesAsync();           
        }

        public async Task SaveProduto()
        {
            await _context.SaveChangesAsync();
        }
    }
}
