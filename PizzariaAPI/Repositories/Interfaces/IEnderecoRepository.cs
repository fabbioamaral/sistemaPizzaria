using PizzariaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaAPI
{
    public interface IEnderecoRepository
    {
        Task<Endereco> GetEnderecoAsync(int id);
        Task<IEnumerable<Endereco>> GetEnderecosAsync();
        Task CreateEnderecoAsync(Endereco endereco);
        Task UpdateEnderecoAsync(Endereco endereco);
        Task DeleteEnderecoAsync(int id);
        Task SaveEndereco();
    }
}
