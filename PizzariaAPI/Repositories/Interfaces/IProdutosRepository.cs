using PizzariaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaAPI.Repositories
{
    public interface IProdutosRepository
    {
        Task<Produto> GetProdutoAsync(int id);
        Task<IEnumerable<Produto>> GetProdutosAsync();
        Task CreateProdutoAsync(Produto produto);
        Task UpdateProdutoAsync(Produto produto);
        Task DeleteProdutoAsync(int id);
        Task SaveProduto();
        
    }
}
