using Microsoft.AspNetCore.Mvc;
using PizzariaAPI.DTOs.Cliente;
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

        //GET: /clientes
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<ICollection<GetClienteDto>>>> GetClientesAsync()
        {
            return Ok(await clienteRepository.GetClientesAsync());
        }

        //GET: /clientes/{id} 
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetClienteDto>>> GetClienteAsync(int id)
        {
            var cliente = await clienteRepository.GetClienteAsync(id);

            if (cliente == null)
                return NotFound();

            return Ok(cliente);
        }

        //POST: /clientes
        [HttpPost]
        public async Task PostClienteAsync(Cliente cliente)
        {
            await clienteRepository.CreateClienteAsync(cliente);
            await clienteRepository.SaveProduto();
        }

        ////PUT: /clientes/{id}
        //[HttpPut("{id}")]
        //public async Task<ActionResult> PutClienteAsync(int id, Cliente cliente)
        //{
        //    var clienteASerAtualizado = await clienteRepository.GetClienteAsync(id);

        //    if (clienteASerAtualizado == null)
        //        return NotFound();

        //    clienteASerAtualizado.ClienteNome = cliente.ClienteNome;
        //    clienteASerAtualizado.ClienteTelefone = cliente.ClienteTelefone;
        //    clienteASerAtualizado.ObservacaoInterna = cliente.ObservacaoInterna;
        //    clienteASerAtualizado.DataUltimaAtualizacao = DateTime.Now;

        //    await clienteRepository.UpdateClienteAsync(clienteASerAtualizado);
        //    await clienteRepository.SaveProduto();

        //    return NoContent();
        //}

        //DELETE: /clientes/{id}
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
