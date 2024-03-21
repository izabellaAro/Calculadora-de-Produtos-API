using AutoMapper;
using CalculoProduto.DataAccess.Repositories;
using CalculoProduto.Entities;
using CalculoProduto.Models.Preparacao;

namespace CalculoProduto.Application.Services.Impl
{
    public class PreparacaoService : IPreparacaoService
    {
        private readonly IPreparacaoRepository _preparacaoRepository;
        private readonly IProdutoRepository _produtoRepository;
        private readonly IMapper _mapper;

        public PreparacaoService(IPreparacaoRepository preparacaoRepository,
            IProdutoRepository produtoRepository,
            IMapper mapper)
        {
            _preparacaoRepository = preparacaoRepository;
            _produtoRepository = produtoRepository;
            _mapper = mapper;
        }

        public async Task CadastrarPreparacao(CreatePreparacaoDto preparacaoDto)
        {
            var produto = await _produtoRepository.BuscaProdutoId(preparacaoDto.ProdutoId);

            var novaPreparacao = new Preparacao(preparacaoDto.Id, preparacaoDto.Nome, preparacaoDto.ProdutoId);
            foreach (var item in preparacaoDto.ItensPreparacao)
            {
                novaPreparacao.AdicionarItem(item.MateriaPrimaId, item.Qnt, item.Valor);
            }

            foreach (var insumo in preparacaoDto.InsumosPreparacao)
            {
                novaPreparacao.AdicionarInsumo(insumo.InsumoIndiretoId, insumo.Valor);
            }

            novaPreparacao.CriarPrecificacao(preparacaoDto.ValorMaoObra, preparacaoDto.PercentualLucro);

            await _preparacaoRepository.AddAsync(novaPreparacao);
        }

        public async Task<IEnumerable<ReadPreparacaoDto>> ListaPreparacoes()
        {
            var listaPreparacoes = await _preparacaoRepository.Listar();

            return _mapper.Map<List<ReadPreparacaoDto>>(listaPreparacoes);
        }

        public async Task<ReadPreparacaoDto> BuscaPreparacaoId(int id)
        {
            var preparacao = await _preparacaoRepository.BuscaPreparacaoId(id);
            if (preparacao == null) return null;

            return _mapper.Map<ReadPreparacaoDto>(preparacao);

        }
    }
}
