using AutoMapper;
using CalculoProduto.DataAccess.Repositories;
using CalculoProduto.Entities;
using CalculoProduto.Models.Produto;

namespace CalculoProduto.Application.Services.Impl
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IMapper _mapper;
        public ProdutoService(IProdutoRepository produtoRepository, IMapper mapper)
        {
            _produtoRepository = produtoRepository;
            _mapper = mapper;
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

            return _mapper.Map<ReadProdutoDto>(produto);
        }

        public async Task<IEnumerable<ReadProdutoDto>> ListaProdutos()
        {
            var listaProdutos = await _produtoRepository.Listar();
            return _mapper.Map<List<ReadProdutoDto>>(listaProdutos);
        }
    }
}
