using System;

namespace Aula20ConversaoImplicitaeCasting
{
   internal class Progam
    {
        static void Main(string[] args)
        {
            float x = 4.5f;

            double y = x;

            double a;
            float b;

            a = 5.1;
            b = (float)a; // fez o casting mas a perda de informação
            Console.WriteLine(b);

            int c = 5;
            int d = 2;

            double resultado = (double)a / b;
    Console.WriteLine(resultado);
        }
    }
}
