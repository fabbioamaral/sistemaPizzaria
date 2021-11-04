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
    [Route("categorias")]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaRepository categoriaRepository;

        public CategoriaController(ICategoriaRepository categoriaRepository)
        {
            this.categoriaRepository = categoriaRepository;
        }

        //GET: api/categorias
        [HttpGet]
        public async Task<IEnumerable<Categoria>> GetCategoriasAsync()
        {
            return await categoriaRepository.GetCategoriasAsync();
        }

        //GET: api/categorias/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Categoria>> GetCategoriaAsync(int id)
        {
            var categoria = await categoriaRepository.GetCategoriaAsync(id);

            if (categoria == null)
                return NotFound();

            return categoria;
        }

    }
}
