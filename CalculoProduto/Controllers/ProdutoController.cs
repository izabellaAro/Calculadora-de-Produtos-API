using CalculoProduto.Application.Services;
using CalculoProduto.Models.Produto;
using Microsoft.AspNetCore.Mvc;

namespace CalculoProduto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpPost]
        public async Task<IActionResult> CadastrarProduto(CreateProdutoDto produtoDto)
        {
            await _produtoService.CadastrarProduto(produtoDto);
            return Ok();
        }

        [HttpGet]
        public async Task<IEnumerable<ReadProdutoDto>> ListaProdutos()
        {
            return await _produtoService.ListaProdutos();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> BuscaProdutoId(int id)
        {
            var produto = await _produtoService.BuscaProdutoId(id);
            if (produto == null) return NotFound();

            return Ok(produto);
        }

    }
}
