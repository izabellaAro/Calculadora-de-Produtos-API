using CalculoProduto.DataAccess.Repositories;
using CalculoProduto.Entities;
using CalculoProduto.Models.MateriaPrima;

namespace CalculoProduto.Application.Services.Impl
{
    public class MateriaPrimaService : IMateriaPrimaService
    {
        private readonly IMateriaPrimaRepository _materiaPrimaRepository;

        public MateriaPrimaService(IMateriaPrimaRepository materiaPrimaRepository)
        {
            _materiaPrimaRepository = materiaPrimaRepository;
        }

        public async Task<ReadMateriaPrimaDto> BuscaMPId(int id)
        {
            var materiaPrima = await _materiaPrimaRepository.BuscaMPId(id);
            if (materiaPrima == null) return null;

            return new ReadMateriaPrimaDto
            {
                Id = materiaPrima.Id,
                Nome = materiaPrima.Nome,
                Qnts = materiaPrima.Qnts,
                Valor = materiaPrima.Valor
            };
        }

        public async Task CadastrarMP(CreateMateriaPrimaDto materiaPrimaDto)
        {
            var novaMP = new MateriaPrima(materiaPrimaDto.Nome, materiaPrimaDto.Qnts, materiaPrimaDto.Valor);
            await _materiaPrimaRepository.AddAsync(novaMP);
        }

        public async Task<IEnumerable<ReadMateriaPrimaDto>> ListarMP()
        {
            var listaMateriaPrima = await _materiaPrimaRepository.Listar();
            return listaMateriaPrima.Select(materiaPrima => new ReadMateriaPrimaDto
            {
                Id = materiaPrima.Id,
                Nome = materiaPrima.Nome,
                Qnts = materiaPrima.Qnts,
                Valor = materiaPrima.Valor
            }).ToList();
        }
    }
}
