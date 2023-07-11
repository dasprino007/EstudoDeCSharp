using System;

namespace aula19OperacaoDeAtribucao // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a *= 3;
            Console.WriteLine(a);

            string s = "ABC";
            Console.WriteLine(s);

            s += "DEF";
            Console.WriteLine(s);

            int c = 10;
            int d = ++c;
            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}