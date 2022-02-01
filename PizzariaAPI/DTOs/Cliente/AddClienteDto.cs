using PizzariaAPI.DTOs.Endereco;
using PizzariaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaAPI.DTOs.Cliente
{
    public class AddClienteDto
    {
        public int ClienteNome { get; set; }
        public string ClienteTelefone { get; set; }
        public string ObservacaoInterna { get; set; }
        public ICollection<GetEnderecoDto> Enderecos { get; set; }

    }
}
