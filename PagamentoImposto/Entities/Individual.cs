using PagamentoImposto.Entities;

namespace PagamentoImposto.Entities
{
    class Individual : Contribuinte
    {

        public double DespesasComSaude { get; set; }

        public Individual()
        {

        }

        public Individual(string nome, double rendaAnual, double despesasComSaude) : base(nome, rendaAnual)
        {
            DespesasComSaude = despesasComSaude;
        }

        public override double imposto()
        {
          if (RendaAnual < 2000.00)
            {
                return RendaAnual * 0.15 - DespesasComSaude * 0.5;
            }
          else
            {
                return RendaAnual * 0.25 - DespesasComSaude * 0.5;
            }
        }
    }
}
