using CalculoProduto.Application.Services;
using CalculoProduto.Models.Preparacao;
using Microsoft.AspNetCore.Mvc;

namespace CalculoProduto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PreparacaoController : ControllerBase
    {
        private readonly IPreparacaoService _preparacaoService;

        public PreparacaoController(IPreparacaoService preparacaoService)
        {
            _preparacaoService = preparacaoService;
        }

        [HttpPost]
        public async Task<IActionResult> CadastrarPreparacao(CreatePreparacaoDto preparacaoDto)
        {
            await _preparacaoService.CadastrarPreparacao(preparacaoDto);
            return Ok();
        }

        [HttpGet]
        public async Task<IEnumerable<ReadPreparacaoDto>> ListaPreparacoes()
        {
            return await _preparacaoService.ListaPreparacoes();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> BuscaPreparacaoId(int id)
        {
            var preparacao = await _preparacaoService.BuscaPreparacaoId(id);
            if (preparacao == null) return NotFound();

            return Ok(preparacao);
        }
    }
}
