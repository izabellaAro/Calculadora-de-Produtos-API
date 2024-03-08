using CalculoProduto.DataAccess.Repositories;
using CalculoProduto.Entities;
using CalculoProduto.Models.Preparacao;

namespace CalculoProduto.Application.Services.Impl
{
    public class PreparacaoService : IPreparacaoService
    {
        private readonly IPreparacaoRepository _preparacaoRepository;

        public PreparacaoService(IPreparacaoRepository preparacaoRepository)
        {
            _preparacaoRepository = preparacaoRepository;
        }

        public async Task CadastrarPreparacao(CreatePreparacaoDto preparacaoDto)
        {
            var novaPreparacao = new Preparacao(preparacaoDto.Id, preparacaoDto.Nome, preparacaoDto.ProdutoId);
            foreach (var item in preparacaoDto.ItensPreparacao)
            {
                novaPreparacao.AdicionarItem(item.MateriaPrimaId, item.Qnt, item.Valor);
            }

            foreach (var insumo in preparacaoDto.InsumosPreparacao)
            {
                novaPreparacao.AdicionarInsumo(insumo.InsumoIndiretoId, insumo.Valor);
            }

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
