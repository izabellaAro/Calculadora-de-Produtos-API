using AutoMapper;
using CalculoProduto.DataAccess.Repositories;
using CalculoProduto.Entities;
using CalculoProduto.Models.MateriaPrima;

namespace CalculoProduto.Application.Services.Impl
{
    public class MateriaPrimaService : IMateriaPrimaService
    {
        private readonly IMateriaPrimaRepository _materiaPrimaRepository;
        private readonly IMapper _mapper;

        public MateriaPrimaService(IMateriaPrimaRepository materiaPrimaRepository, IMapper mapper)
        {
            _materiaPrimaRepository = materiaPrimaRepository;
            _mapper = mapper;
        }

        public async Task<ReadMateriaPrimaDto> BuscaMPId(int id)
        {
            var materiaPrima = await _materiaPrimaRepository.BuscaMPId(id);
            if (materiaPrima == null) return null;

            return _mapper.Map<ReadMateriaPrimaDto>(materiaPrima);
        }

        public async Task CadastrarMP(CreateMateriaPrimaDto materiaPrimaDto)
        {
            var novaMP = new MateriaPrima(materiaPrimaDto.Nome, materiaPrimaDto.Qnts, materiaPrimaDto.Valor);
            await _materiaPrimaRepository.AddAsync(novaMP);
        }

        public async Task<IEnumerable<ReadMateriaPrimaDto>> ListarMP()
        {
            var listaMateriaPrima = await _materiaPrimaRepository.Listar();
            return _mapper.Map<List<ReadMateriaPrimaDto>>(listaMateriaPrima);
        }
    }
}
