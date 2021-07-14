using System;

namespace dclsoft
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instacio a classe Vendedor em um objeto vendedor
            Vendedor vendedor = new Vendedor();

            //Faço a pergunta via CLI
            System.Console.Write("Digite seu salário fixo: R$");

            //Leio a resposta via CLI
            vendedor.SalarioFixo = float.Parse(Console.ReadLine());

            System.Console.Write("Digite o valor total de suas vendas: R$");
            vendedor.ValorVendas = float.Parse(Console.ReadLine());

            System.Console.Write("Digite a quantidade de carros vendidos:");
            vendedor.CarrosVendidos = int.Parse(Console.ReadLine());
            
            System.Console.Write("Digite o valor à ser recebido por carro vendido: R$");
            vendedor.ValorPorCarro = float.Parse(Console.ReadLine());


            //Limpo o console
            Console.Clear();

            //Chamo a função CalculoSalarioFinal() pelo objeto vendedor que já teve seus atributos setados através do Console.ReadLine()
            vendedor.CalculoSalarioFinal();


        }
    }
}
