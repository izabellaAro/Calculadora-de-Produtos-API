using CalculoProduto.Models.InsumoIndireto;

namespace CalculoProduto.Application.Services
{
    public interface IInsumoIndiretoService
    {
        Task CadastraInsumoIndireto(CreateInsumoIndiretoDto insumoIndiretoDto);
        Task<IEnumerable<ReadInsumoIndiretoDto>> ListaInsumoIndireto();
        Task<ReadInsumoIndiretoDto> BuscaInsIndiretoId(int id);
    }
}
