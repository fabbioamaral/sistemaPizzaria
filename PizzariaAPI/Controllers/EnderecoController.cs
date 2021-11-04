using Microsoft.AspNetCore.Mvc;
using PizzariaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaAPI.Controllers
{
    [ApiController]
    [Route("enderecos")]
    public class EnderecoController : ControllerBase
    {
        private readonly IEnderecoRepository enderecoRepository;
        public EnderecoController(IEnderecoRepository enderecoRepository)
        {
            this.enderecoRepository = enderecoRepository;
        }

        //GET: api/enderecos
        [HttpGet]
        public async Task<IEnumerable<Endereco>> GetEnderecosAsync()
        {
            return await enderecoRepository.GetEnderecosAsync();
        }

        //GET: api/enderecos/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Endereco>> GetEnderecoAsync(int id)
        {
            var endereco = await enderecoRepository.GetEnderecoAsync(id);

            if (endereco == null)
                return NotFound();

            return endereco;
        }

        //POST: api/enderecos
        [HttpPost]
        public async Task PostEnderecoAsync(Endereco endereco)
        {
            await enderecoRepository.CreateEnderecoAsync(endereco);
            await enderecoRepository.SaveEndereco();
        }

        //PUT: api/enderecos/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult> PutEnderecoAsync(int id,Endereco endereco)
        {
            var enderecoASerAtualizado = await enderecoRepository.GetEnderecoAsync(id);

            if (enderecoASerAtualizado == null)
                return NotFound();

            enderecoASerAtualizado.Logradouro = endereco.Logradouro;
            enderecoASerAtualizado.NumeroEndereco = endereco.NumeroEndereco;
            enderecoASerAtualizado.CEP = endereco.CEP;
            enderecoASerAtualizado.Complemento = endereco.Complemento;
            enderecoASerAtualizado.Bairro = endereco.Bairro;
            enderecoASerAtualizado.Cidade = endereco.Cidade;
            enderecoASerAtualizado.Referencia = endereco.Referencia;
            enderecoASerAtualizado.TaxaDeEntregaId = endereco.TaxaDeEntregaId;
            enderecoASerAtualizado.TaxaDeEntrega = endereco.TaxaDeEntrega;
            enderecoASerAtualizado.ClienteId = endereco.ClienteId;
            enderecoASerAtualizado.Cliente = endereco.Cliente;

            await enderecoRepository.UpdateEnderecoAsync(enderecoASerAtualizado);
            await enderecoRepository.SaveEndereco();

            return NoContent();
        }

        //DELETE: api/enderecos/id
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteEnderecoAsync(int id)
        {
            var enderecoASerDeletado = await enderecoRepository.GetEnderecoAsync(id);

            if (enderecoASerDeletado == null)
                return NotFound();

            await enderecoRepository.DeleteEnderecoAsync(id);
            return NoContent();
        }
    }
}
