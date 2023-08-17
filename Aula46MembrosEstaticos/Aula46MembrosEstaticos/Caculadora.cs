using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula46MembrosEstaticos
{
    internal class Caculadora
    {
        public static double Pi = 3.14;
        public static double volu(double raio)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(raio, 3);
        }
        public static double Circuferencia(double raio)
        {
            return 2.0 * Pi * raio;
        }
    }
}
