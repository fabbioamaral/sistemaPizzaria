using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaAPI.Models
{
    public class Endereco
    {
        public int EnderecoId { get; set; }
        public string Logradouro { get; set; }
        public int NumeroEndereco { get; set; }
        public string CEP { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }  
        public string Referencia { get; set; }
        public int TaxaDeEntregaId { get; set; }
        public TaxaDeEntrega TaxaDeEntrega { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public ICollection<Pedido> Pedidos { get; private set; }
    }
}
