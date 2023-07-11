using System;
using System.Globalization;

namespace Aula23EntradaDeDadosEmCSharpPARTE2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine()); // transforma em string em numero
            char ch = char.Parse(Console.ReadLine()); // transforma em string em char
            double n2 = double.Parse(Console.ReadLine());

            string[] vet = Console.ReadLine().Split(" ");
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3]);

            Console.WriteLine("você digitou:");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2);
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
        }
    }
}

