using PizzariaAPI.DTOs.Cliente;
using PizzariaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaAPI.Repositories
{
    public interface IClienteRepository
    {
        Task<ServiceResponse<GetClienteDto>> GetClienteAsync(int id);
        Task<ServiceResponse<ICollection<GetClienteDto>>> GetClientesAsync();
        Task CreateClienteAsync(Cliente cliente);
        Task UpdateClienteAsync(Cliente cliente);
        Task DeleteClienteAsync(int id);
        Task SaveProduto();
    }
}
