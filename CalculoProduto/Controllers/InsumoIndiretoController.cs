using CalculoProduto.Application.Services;
using CalculoProduto.Models.InsumoIndireto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculoProduto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InsumoIndiretoController : ControllerBase
    {
        private readonly IInsumoIndiretoService _insumoIndiretoService;

        public InsumoIndiretoController(IInsumoIndiretoService insumoIndiretoService)
        {
            _insumoIndiretoService = insumoIndiretoService;
        }

        [HttpPost]
        public async Task<IActionResult> CadastraInsumoIndireto([FromBody] CreateInsumoIndiretoDto insumoIndiretoDto)
        {
            await _insumoIndiretoService.CadastraInsumoIndireto(insumoIndiretoDto);
            return Ok();
        }

        [HttpGet]
        public async Task<IEnumerable<ReadInsumoIndiretoDto>> ListaInsumoIndireto()
        {
            return await _insumoIndiretoService.ListaInsumoIndireto();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> BuscaInsIndiretoId(int id)
        {
            var insumoIndireto = await _insumoIndiretoService.BuscaInsIndiretoId(id);
            if(insumoIndireto == null) return NotFound();

            return Ok(insumoIndireto);
        }
    }   
}
