using System;

namespace dotNet___Desafio_1
{
    public class Pessoa
    {
        public int Anos { get; set; }
        public int Meses { get; set; }
        public int Dias { get; set; }
        public int IdadeTotalDias { get; set; }

        /// <summary>
        /// Calcula a idade da pessoa em dias
        /// </summary>
        public void CalcularIdadeEmDias()
        {
            /// Enquanto Dias for maior ou igual a 30, retiro 30 dias do int Dias e Adiciono 1 à int Meses
            while (Dias >= 30)
            {
                Dias = Dias - 30;
                Meses = Meses + 1;
            }
            while (Meses >= 12)
            {
                Meses = Meses - 12;
                Anos = Anos + 1;
            }
            IdadeTotalDias = (Anos * 365) + (Meses * 30) + Dias;
            Console.WriteLine("Em " + Anos + " Anos, " + Meses + " Meses e " + Dias + " Dias, Você tem cerca de " + IdadeTotalDias + " Dias");

        }
    }
}