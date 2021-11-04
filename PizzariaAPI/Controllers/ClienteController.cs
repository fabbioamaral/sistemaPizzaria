using Microsoft.AspNetCore.Mvc;
using PizzariaAPI.Models;
using PizzariaAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaAPI.Controllers
{
    [ApiController]
    [Route("clientes")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepository clienteRepository;

        public ClienteController(IClienteRepository clienteRepository)
        {
            this.clienteRepository = clienteRepository;
        }

        //GET: api/clientes
        [HttpGet]
        public async Task<IEnumerable<Cliente>> GetClientesAsync()
        {
            return await clienteRepository.GetClientesAsync();
        }

        //GET: api/clientes/{id} 
        [HttpGet("{id}")]
        public async Task<ActionResult<Cliente>> GetClienteAsync(int id)
        {
            var cliente = await clienteRepository.GetClienteAsync(id);

            if (cliente == null)
                return NotFound();

            return cliente;
        }

        //POST: api/clientes
        [HttpPost]
        public async Task PostClienteAsync(Cliente cliente)
        {
            await clienteRepository.CreateClienteAsync(cliente);
            await clienteRepository.SaveProduto();
        }

        //PUT: api/clientes/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult> PutClienteAsync(int id, Cliente cliente)
        {
            var clienteASerAtualizado = await clienteRepository.GetClienteAsync(id);

            if (clienteASerAtualizado == null)
                return NotFound();

            clienteASerAtualizado.ClienteNome = cliente.ClienteNome;
            clienteASerAtualizado.ClienteTelefone = cliente.ClienteTelefone;
            clienteASerAtualizado.ObservacaoInterna = cliente.ObservacaoInterna;
            clienteASerAtualizado.DataUltimaAtualizacao = DateTime.Now;

            await clienteRepository.UpdateClienteAsync(clienteASerAtualizado);
            await clienteRepository.SaveProduto();

            return NoContent();
        }

        //DELETE: api/clientes/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteClienteAsync(int id)
        {
            var clienteASerDeletado = clienteRepository.GetClienteAsync(id);

            if (clienteASerDeletado == null)
                return NotFound();

            await clienteRepository.DeleteClienteAsync(id);
            return NoContent();
        }


    }
}
