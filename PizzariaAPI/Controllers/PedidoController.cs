using Microsoft.AspNetCore.Mvc;
using PizzariaAPI.Models;
using PizzariaAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PizzariaAPI.Controllers
{
    [Route("pedidos")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoRepository pedidoRepository;
        public PedidoController(IPedidoRepository pedidoRepository)
        {
            this.pedidoRepository = pedidoRepository;
        }
        
        // GET: /pedidos
        [HttpGet]
        public async Task<IEnumerable<Pedido>> GetPedidos()
        {
            return await pedidoRepository.GetPedidosAsync();
        }

        // GET /pedidos/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Pedido>> GetPedido(int id)
        {
            var pedido = await pedidoRepository.GetPedidoAsync(id);

            if (pedido == null)
                return NotFound();

            return pedido;
        }

        // POST /pedidos
        [HttpPost]
        public async Task CriarPedido(Pedido pedido)
        {
            await pedidoRepository.CreatePedidoAsync(pedido);
            await pedidoRepository.SavePedido();
        }

        // DELETE /pedidos
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletarPedido(int id)
        {
            var pedido = await pedidoRepository.GetPedidoAsync(id);

            if (pedido == null)
                return NotFound();

            await pedidoRepository.DeletePedidoAsync(id);
            return NoContent();
        }
    }
}
