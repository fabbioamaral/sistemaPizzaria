using Microsoft.EntityFrameworkCore;
using PizzariaAPI.Data;
using PizzariaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaAPI.Repositories
{
    public class FormaDePagamentoRepository : IFormaDePagamentoRepository
    {

        private readonly PizzariaContexto _context;

        public FormaDePagamentoRepository(PizzariaContexto context)
        {
            _context = context;
        }
        public async Task<IEnumerable<FormaDePagamento>> GetFormasDePagamentosAsync()
        {
            return await _context.FormasDePagamento.ToListAsync();
        }
    }
}
