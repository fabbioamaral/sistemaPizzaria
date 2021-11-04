using PizzariaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaAPI.Repositories
{
    public interface ICategoriaRepository
    {
        Task<Categoria> GetCategoriaAsync(int id);
        Task<IEnumerable<Categoria>> GetCategoriasAsync();
    }
}
