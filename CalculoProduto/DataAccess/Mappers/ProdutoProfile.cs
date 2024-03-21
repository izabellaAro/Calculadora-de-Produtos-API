using AutoMapper;
using CalculoProduto.Entities;
using CalculoProduto.Models.Produto;

namespace CalculoProduto.DataAccess.Mappers
{
    public class ProdutoProfile : Profile
    {
        public ProdutoProfile()
        {
            CreateMap<Produto, ReadProdutoDto>();
            CreateMap<CreateProdutoDto, Produto>();
        }
    }
}
