// See https://aka.ms/new-console-template for more information
using System;

namespace Course
{
    class program
    {
        static void Main(string[] args)
        {
            bool completo = false;
            char genero = 'f';
            char letra = '\u0041';
            sbyte n1 = 126;
            int n2 = 1000;
            int n3 = 214758347;
            long n4 = 2121212112L;// L = long
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "maria green";
            object obj1 = "alex Brown";
            object obj2 = 4.5;

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(nome);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
        }
    }
}