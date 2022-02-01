using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using PizzariaAPI.DTOs.Cliente;
using PizzariaAPI.DTOs.Endereco;
using PizzariaAPI.DTOs.TaxaDeEntrega;
using PizzariaAPI.Models;

namespace PizzariaAPI
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Cliente, GetClienteDto>();
            CreateMap<AddClienteDto,Cliente>();

            CreateMap<Endereco, GetEnderecoDto>();

            CreateMap<TaxaDeEntrega, GetTaxaDeEntregaDto>();
        }
    }
}
