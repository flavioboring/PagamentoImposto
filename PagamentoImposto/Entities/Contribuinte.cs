using System;
using System.Collections.Generic;
using System.Text;
using PagamentoImposto.Entities;

namespace PagamentoImposto.Entities
{
    abstract class Contribuinte
    {
        public String Nome { get; set; }
        public double RendaAnual { get; set; }
        
        public Contribuinte()
        {

        }

        protected Contribuinte(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }
        public abstract double imposto();
                 
        
    }
}
