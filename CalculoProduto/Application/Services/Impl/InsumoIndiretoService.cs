using AutoMapper;
using CalculoProduto.DataAccess.Repositories;
using CalculoProduto.Entities;
using CalculoProduto.Models.InsumoIndireto;

namespace CalculoProduto.Application.Services.Impl
{
    public class InsumoIndiretoService : IInsumoIndiretoService
    {
        private readonly IInsumoIndiretoRepository _insumoIndiretoRepository;
        private readonly IMapper _mapper;

        public InsumoIndiretoService(IInsumoIndiretoRepository insumoIndiretoRepository, IMapper mapper)
        {
            _insumoIndiretoRepository = insumoIndiretoRepository;
            _mapper = mapper;
        }

        public async Task CadastraInsumoIndireto(CreateInsumoIndiretoDto insumoIndiretoDto)
        {
            var novoInsumo = new InsumoIndireto(insumoIndiretoDto.Especificacao, insumoIndiretoDto.Valor);
            await _insumoIndiretoRepository.AddAsync(novoInsumo);
        }

        public async Task<ReadInsumoIndiretoDto> BuscaInsIndiretoId(int id)
        {
            var insumoIndireto = await _insumoIndiretoRepository.BuscaInsIndiretoId(id);
            if (insumoIndireto == null) return null;

            return _mapper.Map<ReadInsumoIndiretoDto>(insumoIndireto);
        }

        public async Task<IEnumerable<ReadInsumoIndiretoDto>> ListaInsumoIndireto()
        {
            var listaInsumoIndireto = await _insumoIndiretoRepository.Listar();

            return _mapper.Map<List<ReadInsumoIndiretoDto>>(listaInsumoIndireto);
        }
    }
}
