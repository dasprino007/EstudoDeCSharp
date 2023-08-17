using System.Globalization;


namespace Aula46MembrosEstaticos
{
    class Program
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {
            /*
            // versão 1
            Console.Write("entre o valor no raio :");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); ;

            double circ = Circuferencia(raio);
            double volume = volu(raio);
            
            Console.WriteLine("Circuferencia " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("volume " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Pi " + Pi.ToString("F2", CultureInfo.InvariantCulture));
            */
            /*
            // versão 2
            Caculadora calc = new Caculadora();

            Console.Write("entre o valor no raio :");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); ;

            double circ = calc.Circuferencia(raio);
            double volume = calc.volu(raio);

            Console.WriteLine("Circuferencia " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("volume " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Pi " + calc.Pi.ToString("F2", CultureInfo.InvariantCulture));
            */
            //versão 3
           
            Console.Write("entre o valor no raio :");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); ;

            double circ = Caculadora.Circuferencia(raio);
            double volume = Caculadora.volu(raio);

            Console.WriteLine("Circuferencia " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("volume " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Pi " + Caculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
        static double volu(double raio)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(raio, 3);
        }
        static double Circuferencia(double raio)
        {
            return 2.0 * Pi * raio;
        }
        
  
    }
}

