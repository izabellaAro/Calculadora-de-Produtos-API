using CalculoProduto.Models.InsumoIndireto;

namespace CalculoProduto.Models.InsumoPreparacao
{
    public class ReadInsumoPreparacaoDto
    {
        public int Id { get; set; }
        public double Valor { get; set; }
        public ReadInsumoIndiretoDto InsumoIndireto { get; set; }

        //preparacao
    }
}
