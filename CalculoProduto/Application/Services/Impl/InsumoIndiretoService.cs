using CalculoProduto.DataAccess.Repositories;
using CalculoProduto.Entities;
using CalculoProduto.Models.InsumoIndireto;

namespace CalculoProduto.Application.Services.Impl
{
    public class InsumoIndiretoService : IInsumoIndiretoService
    {
        private readonly IInsumoIndiretoRepository _insumoIndiretoRepository;

        public InsumoIndiretoService(IInsumoIndiretoRepository insumoIndiretoRepository)
        {
            _insumoIndiretoRepository = insumoIndiretoRepository;
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

            return new ReadInsumoIndiretoDto
            {
                Id = insumoIndireto.Id,
                Especificacao = insumoIndireto.Especificao,
                Valor = insumoIndireto.Valor
            };
        }

        public async Task<IEnumerable<ReadInsumoIndiretoDto>> ListaInsumoIndireto()
        {
            var listaInsumoIndireto = await _insumoIndiretoRepository.Listar();
            return listaInsumoIndireto.Select(insumoIndireto => new ReadInsumoIndiretoDto
            {
                Id = insumoIndireto.Id,
                Especificacao = insumoIndireto.Especificao,
                Valor = insumoIndireto.Valor
            }).ToList();
        }
    }
}
