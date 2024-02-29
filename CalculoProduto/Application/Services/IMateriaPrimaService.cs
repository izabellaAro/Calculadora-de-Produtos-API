using CalculoProduto.Entities;
using CalculoProduto.Models.MateriaPrima;

namespace CalculoProduto.Application.Services
{
    public interface IMateriaPrimaService
    {
        Task CadastrarMP(CreateMateriaPrimaDto materiaPrimaDto);
        Task<IEnumerable<ReadMateriaPrimaDto>> ListarMP();
        Task<ReadMateriaPrimaDto> BuscaMPId(int id);
    }
}
