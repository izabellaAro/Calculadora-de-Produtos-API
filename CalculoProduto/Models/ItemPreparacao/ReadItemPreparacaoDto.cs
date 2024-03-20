using CalculoProduto.Models.MateriaPrima;

namespace CalculoProduto.Models.ItemPreparacao
{
    public class ReadItemPreparacaoDto
    {
        public int Id { get; set; }
        //preparacao
        public ReadMateriaPrimaDto MateriaPrima { get; set; }
        public double Qnt { get; set; }
        public double Valor { get; set; }

    }
}
