using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaAPI.Controllers
{
    public class EnderecoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
