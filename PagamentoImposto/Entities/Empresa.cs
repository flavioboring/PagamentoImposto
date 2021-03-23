using System;
using System.Collections.Generic;
using System.Text;

namespace PagamentoImposto.Entities
{
    class Empresa : Contribuinte
    {
        public int QuantidadeFuncionarios { get; set; }

        public Empresa()
        {

        }

        public Empresa(string nome, double rendaAnual, int quantidadeFuncionarios) : base(nome, rendaAnual)
        {
            QuantidadeFuncionarios = quantidadeFuncionarios;
        }

        public override double imposto()
        {
            if (QuantidadeFuncionarios > 10)
            {
                return RendaAnual * 0.14;
            }
            else
            {
                return RendaAnual * 0.16;
            }
        }
    }
}
