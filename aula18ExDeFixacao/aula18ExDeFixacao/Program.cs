using System;
using System.Globalization;

namespace aula18ExDeFixacao // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "computador";
            string produto2 = "mesa de escritorio";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'm';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double media = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine("{0}, cujo o preço é $ {1:F2}",produto1,preco1);
            Console.WriteLine("{0}, cujo o preço é $ {1:F2}", produto2, preco2);
            Console.WriteLine("\n");
            Console.WriteLine("registro: {0} anos de idade, codigo {1} e genero {2}",idade,codigo,genero);
            Console.WriteLine("\n");
            Console.WriteLine("medida de oito casas decimais:{0:F8}", media);
            Console.WriteLine("arredondando (três casas decimais): {0:F3}", media);
            Console.WriteLine($"separador decimal invarient culture: {media.ToString(CultureInfo.InvariantCulture)}");
        }
    }
}