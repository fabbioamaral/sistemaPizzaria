using PizzariaAPI.DTOs.TaxaDeEntrega;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaAPI.DTOs.Endereco
{
    public class GetEnderecoDto
    {
        public string Logradouro { get; set; }
        public int NumeroEndereco { get; set; }
        public string CEP { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Referencia { get; set; }

        public GetTaxaDeEntregaDto TaxaDeEntrega { get; set; }
    }
}
