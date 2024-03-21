using CalculoProduto.DataAccess.Repositories;
using CalculoProduto.Entities;
using CalculoProduto.Models.Precificacao;

namespace CalculoProduto.Application.Services.Impl
{
    public class PrecificacaoService : IPrecificacaoService
    {
        private readonly IPrecificacaoRepository _precificacaoRepository;

        public PrecificacaoService(IPrecificacaoRepository precificacaoRepository)
        {
            _precificacaoRepository = precificacaoRepository;
        }

        public async Task CriarPrecificacao(CreatePrecificacaoDto precificacaoDto)
        {
            var novaPrecificacao = new Precificacao(precificacaoDto.Id, precificacaoDto.CustoMO, precificacaoDto.PercentualLucro);
            await _precificacaoRepository.AddAsync(novaPrecificacao);
        }
    }
}
