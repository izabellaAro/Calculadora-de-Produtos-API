using AutoMapper;
using CalculoProduto.Entities;
using CalculoProduto.Models.Precificacao;
using CalculoProduto.Models.Preparacao;

namespace CalculoProduto.DataAccess.Mappers
{
    public class PreparacaoProfile : Profile
    {
        public PreparacaoProfile()
        {
            CreateMap<Preparacao, ReadPreparacaoDto>();
            CreateMap<CreatePreparacaoDto, Preparacao>();

            CreateMap<ItemPreparacao, ReadItemPreparacaoDto>();
            CreateMap<CreateItemPreparacaoDto, ItemPreparacao>();

            CreateMap<InsumoPreparacao, ReadInsumoPreparacaoDto>();
            CreateMap<CreateInsumoPreparacaoDto, InsumoPreparacao>();

            CreateMap<Precificacao, ReadPrecificacaoDto>();
            CreateMap<CreatePrecificacaoDto, Precificacao>();
        }
    }
}
