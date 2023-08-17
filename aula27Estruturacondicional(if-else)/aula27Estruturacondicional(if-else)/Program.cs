using System;

namespace aula27Estruturacondicional_if_else_ // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

              Console.WriteLine("entre com um numero inteiro:");
              int x = int.Parse(Console.ReadLine());

              if (x % 2 == 0)//par
              {
                  Console.WriteLine("par!");
              }
              else
              {
                  Console.WriteLine("impar!"); 
              }

            Console.WriteLine("qual é a hora atual?");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("bom dia");
            }

            else if(hora < 18) 
            {
                Console.WriteLine("boa tarde!");
            }

            else
            {
                Console.WriteLine("boa noite");
            }
        }
    }
}
