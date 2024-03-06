using CalculoProduto.Application.Services;
using CalculoProduto.DataAccess.Repositories;
using CalculoProduto.Entities;
using CalculoProduto.Models.Produto;

namespace CalculoProduto.Application.Services.Impl
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;
        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
        
        public async Task CadastrarProduto(CreateProdutoDto produtoDto)
        {
            var novoProduto = new Produto(produtoDto.Nome);
            await _produtoRepository.AddAsync(novoProduto);
        }

        public async Task<ReadProdutoDto> BuscaProdutoId(int id)
        {
            var produto = await _produtoRepository.BuscaProdutoId(id);
            if (produto == null) return null;

            return new ReadProdutoDto
            {
                Id = produto.Id,
                Nome = produto.Nome
            };
        }

        public async Task<IEnumerable<ReadProdutoDto>> ListaProdutos()
        {
            var listaProdutos = await _produtoRepository.Listar();
            return listaProdutos.Select(produto => new ReadProdutoDto
            {
                Id = produto.Id,
                Nome = produto.Nome
            }).ToList();
        }
    }
}
