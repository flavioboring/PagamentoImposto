using System;
using System.Collections.Generic;
using System.Globalization;
using PagamentoImposto.Entities;


 namespace PagamentoImposto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contribuinte> list = new List<Contribuinte>();  
            Console.Write("Entre com a quantidade de pagadores de impostos: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                
                Console.Write("Pessoa física ou pessoa juridica? (f/j)");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Renda anual: ");
                double renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'f')
                {
                    Console.Write("Despesas com saúde: ");
                    double despesascomsaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(nome, renda, despesascomsaude));

                }
                else
                {
                    Console.Write("Quantidade de  funcionarios: ");
                    int funcionarios = int.Parse(Console.ReadLine());
                    list.Add(new Empresa(nome, renda, funcionarios));
                }
            }
            

            double sum = 0.0;
            Console.WriteLine();
            Console.WriteLine("IMPOSTOS PAGOS: ");
            foreach (Contribuinte contribuinte in list)
            {
                double imposto = contribuinte.imposto();
                Console.WriteLine(contribuinte.Nome + ": $" + imposto.ToString("F2", CultureInfo.InvariantCulture));

                sum += imposto;
            }
            Console.WriteLine();
            Console.WriteLine("IMPOSTOS PAGOS: " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
