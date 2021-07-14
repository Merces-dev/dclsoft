using System;

namespace dotNet___Desafio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            //Faço a pergunta via CLI
            System.Console.Write("Digite quantos anos de vida você tem: ");
            //Leio a resposta via CLI
            pessoa.Anos = Int32.Parse(Console.ReadLine());

            System.Console.Write("Digite quantos meses de vida você tem (Sem contar os anos): ");
            pessoa.Meses = Int32.Parse(Console.ReadLine());

            System.Console.Write("Digite quantos dias de vida você tem (Sem contar os anos e meses): ");
            pessoa.Dias = Int32.Parse(Console.ReadLine());

            //Chamo a função CalcularIdadeEmDias() pelo objeto pessoa que já teve seus atributos setados através do Console.ReadLine()
            pessoa.CalcularIdadeEmDias();
        }
    }
}
