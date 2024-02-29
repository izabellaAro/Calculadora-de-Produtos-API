using CalculoProduto.Application.Services;
using CalculoProduto.Models.MateriaPrima;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculoProduto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MateriaPrimaController : ControllerBase
    {
        private readonly IMateriaPrimaService _materiaPrimaService;

        public MateriaPrimaController(IMateriaPrimaService materiaPrimaService)
        {
            _materiaPrimaService = materiaPrimaService;
        }

        [HttpPost]
        public async Task<IActionResult> CadastrarMP([FromBody] CreateMateriaPrimaDto materiaPrimaDto)
        {
            await _materiaPrimaService.CadastrarMP(materiaPrimaDto);
            return Ok();
        }

        [HttpGet]
        public async Task<IEnumerable<ReadMateriaPrimaDto>> ListarMP()
        {
            return await _materiaPrimaService.ListarMP();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> BuscaMPId(int id)
        {
            var materiaPrima = await _materiaPrimaService.BuscaMPId(id);
            if (materiaPrima == null) return NotFound();

            return Ok(materiaPrima);
        }
    }
}
