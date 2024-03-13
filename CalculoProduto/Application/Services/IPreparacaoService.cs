using CalculoProduto.Models.Preparacao;

namespace CalculoProduto.Application.Services
{
    public interface IPreparacaoService
    {
        Task CadastrarPreparacao(CreatePreparacaoDto preparacaoDto);
        Task<IEnumerable<ReadPreparacaoDto>> ListaPreparacoes();
        Task<ReadPreparacaoDto> BuscaPreparacaoId(int id);
        //Task CriarPreparacao(double valorMaoObra, double percentualLucro); 
    }
}
