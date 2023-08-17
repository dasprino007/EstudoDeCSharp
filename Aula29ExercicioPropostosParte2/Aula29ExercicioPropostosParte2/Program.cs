using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ex 1
            /*int num1 = int.Parse(Console.ReadLine());

            if ( num1 >= 0 ) 
            {
                Console.WriteLine("não negativo");
            }
            else
            {
                Console.WriteLine("negativo");
            }*/

            // ex2
            /*int num2 = int.Parse(Console.ReadLine());

            if(num2 % 2 == 0)
            {
                Console.WriteLine("par");
            }

            else
            {
                Console.WriteLine("impar");
            }*/

            // ex3
            /*
            string[] vet = Console.ReadLine().Split(" ");

            int num3 = int.Parse(vet[0]);
            int num4 = int.Parse(vet[1]);

            if (num3 % num4 == 0 || num4 % num3 == 0 )
            {
                Console.WriteLine("multiplos");
            }

            else 
            {
                Console.WriteLine("Não multiplo");
            }*/

            //ex4
            /*string[] vet1 = Console.ReadLine().Split(" ");

            int num4 = int.Parse(vet1[0]);
            int num5 = int.Parse(vet1[1]);
            int total = 0;

            if (num4 < num5)
            {
                total = num5 - num4;
            }
            else
            {
                total = 24;
            }

            Console.WriteLine("O JOGO DURO " + total + " HORA(S)");*/

            // ex5
            /*
            string[] vet2 = Console.ReadLine().Split(" ");

            int cod = int.Parse(vet2[0]);
            int qnt = int.Parse(vet2[1]);
            double total = 0.0;

            if(cod == 1)
            {
                total = 4.00 * qnt;
            }
            else if (cod == 2)
            {
                total = 4.50 * qnt;
            }
            else if (cod == 3)
            {
                total = 5.00 * qnt;
            }
            else if (cod == 4)
            {
                total = 2.00 * qnt;
            }
            else if (cod == 5)
            {
                total = 1.50 * qnt;
            }

            Console.WriteLine("Total: R$ "+total.ToString("F2"));
            */
            // ex 6
            /*
            double N = double.Parse(Console.ReadLine());

            if (N < 0 || N < 100)
            {
                Console.WriteLine("fora de alcance");
            }
            else if (N >= 25)
            {
                Console.WriteLine("intervalo (25,50)");
            }
            else if (N >= 75)
            {
                Console.WriteLine("intervalo (50,75)");
            }
            else if (N >= 100)
            {
                Console.WriteLine("intervalo (75,100)");
            }
            */

            //ex7
            /*
            string[] vet3 = Console.ReadLine().Split(" ");

            double eixoX = double.Parse(vet3[0]);
            double eixoY = double.Parse(vet3[1]);

            if(eixoX >= 0.1 && eixoY >= 0.1)
            {
                Console.WriteLine("Q1");
            }
            else if (eixoX >= 0.1 && eixoY <= -0.1)
            {
                Console.WriteLine("Q4");
            }
            else if (eixoX <= -0.1 && eixoY >= 0.1)
            {
                Console.WriteLine("Q2");
            }
            else if (eixoX <= -0.1 && eixoY <= -0.1)
            {
                Console.WriteLine("Q2");
            }
            else if(eixoX == 0 && eixoY == 0)
            {
                Console.WriteLine("origem");
            }
            else if((eixoX == 0))
            {
                Console.WriteLine("Eixo X");
            }
            else if ((eixoY == 0))
            {
                Console.WriteLine("Eixo Y");
            }
            */

            // ex8

            double valor = double.Parse(Console.ReadLine());
            double total = 0.0;

            if (valor <= 2000) 
            {
                Console.WriteLine("isento");
            }
            else if(valor <= 3000)
            {
                total = (valor - 2000) * 0.08;
                Console.WriteLine("R$" + total.ToString("F2"));
            }
            else if (valor <= 4500)
            {
                total = (valor - 3000) * 0.18;
                Console.WriteLine("R$" + total.ToString("F2"));
            }
            else
            {
                total = (valor - 4500) * 0.28;
                Console.WriteLine("R$" + total.ToString("F2"));
            }

        }
    }
}
