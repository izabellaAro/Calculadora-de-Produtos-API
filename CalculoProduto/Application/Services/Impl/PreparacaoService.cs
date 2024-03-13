using CalculoProduto.DataAccess.Repositories;
using CalculoProduto.Entities;
using CalculoProduto.Models.Precificacao;
using CalculoProduto.Models.Preparacao;

namespace CalculoProduto.Application.Services.Impl
{
    public class PreparacaoService : IPreparacaoService
    {
        private readonly IPreparacaoRepository _preparacaoRepository;
        private readonly IProdutoRepository _produtoRepository;

        public PreparacaoService(IPreparacaoRepository preparacaoRepository, IProdutoRepository produtoRepository)
        {
            _preparacaoRepository = preparacaoRepository;
            _produtoRepository = produtoRepository;
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
            return listaPreparacoes.Select(preparacao => new ReadPreparacaoDto
            {
                Id = preparacao.Id,
                Nome = preparacao.Nome,
                ProdutoId = preparacao.ProdutoId,
                ItensPreparacao = preparacao.ItensPreparacao
                    .Select(item => new ReadItemPreparacaoDto {
                        Id = item.Id,
                        MateriaPrimaId = item.MateriaPrimaId,
                        Qnt = item.Qnt,
                        Valor = item.Valor
                    }).ToList(),
                InsumosPreparacao = preparacao.InsumosPreparacao
                    .Select(insumo => new ReadInsumoPreparacaoDto
                    {
                        Id = insumo.Id,
                        InsumoIndiretoId = insumo.InsumoIndiretoId,
                        Valor = insumo.Valor
                    }).ToList(),
                PrecificacaoDto = new ReadPrecificacaoDto
                {
                    CustoMO = preparacao?.Precificacao?.CustoMO ?? 0,
                    PercentualLucro = preparacao?.Precificacao?.PercentualLucro ?? 0
                }
            }).ToList();
        }

        public async Task<ReadPreparacaoDto> BuscaPreparacaoId(int id)
        {
            var preparacao = await _preparacaoRepository.BuscaPreparacaoId(id);
            if (preparacao == null) return null;

            return new ReadPreparacaoDto
            {
                Id = preparacao.Id,
                Nome = preparacao.Nome,
                ProdutoId = preparacao.ProdutoId,
                ItensPreparacao = preparacao.ItensPreparacao
                    .Select(item => new ReadItemPreparacaoDto
                    {
                        Id = item.Id,
                        MateriaPrimaId = item.MateriaPrimaId,
                        Qnt = item.Qnt,
                        Valor = item.Valor
                    }).ToList(),
                InsumosPreparacao = preparacao.InsumosPreparacao
                    .Select(insumo => new ReadInsumoPreparacaoDto
                    {
                        Id = insumo.Id,
                        InsumoIndiretoId = insumo.InsumoIndiretoId,
                        Valor = insumo.Valor
                    }).ToList()
            };
        }
    }
}
