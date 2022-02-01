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
    [Route("formasdepagamento")]
    public class FormaDePagamentoController : ControllerBase
    {
        private readonly IFormaDePagamentoRepository formaDePagamentoRepository;

        public FormaDePagamentoController(IFormaDePagamentoRepository formaDePagamentoRepository)
        {
            this.formaDePagamentoRepository = formaDePagamentoRepository;
        }

        //GET: /formasdepagamento
        [HttpGet]
        public async Task<IEnumerable<FormaDePagamento>> GetFormasDePagamentoAsync()
        {
            return await formaDePagamentoRepository.GetFormasDePagamentosAsync();
        }
    }
}
