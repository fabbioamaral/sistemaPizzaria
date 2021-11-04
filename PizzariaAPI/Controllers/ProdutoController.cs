using Microsoft.AspNetCore.Mvc;
using PizzariaAPI.Data;
using PizzariaAPI.Models;
using PizzariaAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaAPI.Controllers
{
    [ApiController]
    [Route("produtos")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutosRepository produtoRepository;

        public ProdutoController(IProdutosRepository produtoRepository)
        {
            this.produtoRepository = produtoRepository;
        }

        //GET: api/produtos
        [HttpGet]
        public async Task<IEnumerable<Produto>> GetProdutosAsync()
        {
            return await produtoRepository.GetProdutosAsync();
        }

        //GET: api/produtos/{id} 
        [HttpGet("{id}")]
        public async Task<ActionResult<Produto>> GetProdutoAsync(int id)
        {
            var produto = await produtoRepository.GetProdutoAsync(id);

            if (produto == null)
                return NotFound();

            return produto;
        }

        //POST: api/produtos
        [HttpPost]
        public async Task PostProdutoAsync(Produto produto)
        {
            await produtoRepository.CreateProdutoAsync(produto);
            await produtoRepository.SaveProduto();
        }

        //PUT: api/produtos/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult> PutProdutoAsync(int id, Produto produto)
        {
            var produtoASerAtualizado = await produtoRepository.GetProdutoAsync(id);

            if (produtoASerAtualizado == null)
                return NotFound();

            produtoASerAtualizado.ProdutoNome = produto.ProdutoNome;
            produtoASerAtualizado.Preco = produto.Preco;
            produtoASerAtualizado.CategoriaId = produto.CategoriaId;
            produtoASerAtualizado.Categoria = produto.Categoria;
            produtoASerAtualizado.Pedidos = produto.Pedidos;

            await produtoRepository.UpdateProdutoAsync(produtoASerAtualizado);
            await produtoRepository.SaveProduto();

            return NoContent();
        }

        //DELETE: api/produtos/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteProdutoAsync(int id)
        {
            var produtoASerDeletado = produtoRepository.GetProdutoAsync(id);

            if (produtoASerDeletado == null)
                return NotFound();

            await produtoRepository.DeleteProdutoAsync(id);
            return NoContent();
        }
    }
}
