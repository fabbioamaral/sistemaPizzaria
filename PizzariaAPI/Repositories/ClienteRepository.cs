using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PizzariaAPI.Data;
using PizzariaAPI.DTOs.Cliente;
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
        private readonly IMapper _mapper;

        public ClienteRepository(PizzariaContexto context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
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

        public async Task<ServiceResponse<GetClienteDto>> GetClienteAsync(int id)
        {
            var serviceResponse = new ServiceResponse<GetClienteDto>();

            var dbCliente = await _context.Clientes
                .Include(c=>c.Enderecos)
                .FirstOrDefaultAsync(c=>c.ClienteId==id);

            serviceResponse.Data = _mapper.Map<GetClienteDto>(dbCliente);
            return serviceResponse;
        }

        public async Task<ServiceResponse<ICollection<GetClienteDto>>> GetClientesAsync()
        {
            var serviceResponse = new ServiceResponse<ICollection<GetClienteDto>>();
            var dbCliente = await _context.Clientes
                .Include(c=>c.Enderecos).ThenInclude(e=>e.TaxaDeEntrega)
                .ToListAsync();

            serviceResponse.Data = dbCliente.Select(c=> _mapper.Map<GetClienteDto>(c)).ToList();
            return serviceResponse;
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
