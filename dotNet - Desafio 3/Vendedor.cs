using System;

namespace dclsoft
{
    public class Vendedor
    {
        public float SalarioFixo { get; set; }
        public float ValorVendas { get; set; }
        public float ValorPorCarro { get; set; }
        public int CarrosVendidos { get; set; }
        public float SalarioFinal { get; set; }

        /// <summary>
        /// Calcula o salário final do vendedor e o justifica com seus cálculos 
        /// </summary>
        public void CalculoSalarioFinal()
        {
            SalarioFinal = (float)(SalarioFixo + (ValorVendas * 0.05) + (CarrosVendidos * ValorPorCarro));
            Console.WriteLine(("############################"));
            Console.WriteLine();
            Console.WriteLine(("Valor de Quantidade de Carros X Taxa fixa por carro: R$ " + CarrosVendidos * ValorPorCarro));
            Console.WriteLine(("Valor de 5% das Vendas Totais: R$ " + (ValorVendas * 0.05)));
            Console.WriteLine(("Valor Sálario Fixo: R$ " + SalarioFixo));
            Console.WriteLine();
            Console.WriteLine(("############################"));
            Console.WriteLine();
            Console.WriteLine(("Valor Salário FINAL: R$ " + SalarioFinal));
            Console.WriteLine();
            Console.WriteLine(("############################"));


        }

    }
}