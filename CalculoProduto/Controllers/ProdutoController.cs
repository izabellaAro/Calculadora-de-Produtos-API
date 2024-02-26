using CalculoProduto.Application.Services;
using CalculoProduto.Entities;
using CalculoProduto.Services.Impl;
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
        public IActionResult CriarPreparacao()
        {
            _produtoService.CadastrarProduto();
            return Ok();
        }

    }
}
