using AutoMapper;
using CalculoProduto.Entities;
using CalculoProduto.Models.MateriaPrima;

namespace CalculoProduto.DataAccess.Mappers
{
    public class MateriaPrimaProfile : Profile
    {
        public MateriaPrimaProfile()
        {
            CreateMap<MateriaPrima, ReadMateriaPrimaDto>();
            CreateMap<CreateMateriaPrimaDto, MateriaPrima>();
        }
    }
}
