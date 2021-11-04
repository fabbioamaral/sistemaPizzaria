using PizzariaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaAPI.Repositories
{
    public interface IFormaDePagamentoRepository
    {
        Task<IEnumerable<FormaDePagamento>> GetFormasDePagamentosAsync();
    }
}
