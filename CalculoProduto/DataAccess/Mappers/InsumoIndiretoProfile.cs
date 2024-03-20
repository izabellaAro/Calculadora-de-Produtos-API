using AutoMapper;
using CalculoProduto.Entities;
using CalculoProduto.Models.InsumoIndireto;

namespace CalculoProduto.DataAccess.Mappers
{
    public class InsumoIndiretoProfile : Profile
    {
        public InsumoIndiretoProfile()
        {
            CreateMap<InsumoIndireto, ReadInsumoIndiretoDto>();
            CreateMap<CreateInsumoIndiretoDto, InsumoIndireto>();
        }
    }
}
