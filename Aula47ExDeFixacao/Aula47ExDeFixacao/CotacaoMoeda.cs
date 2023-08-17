using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Aula47ExDeFixacao
{
    internal class CotacaoMoeda
    {
        static public double ConDollar(double dollar, double valor)
        {
            double total = dollar * valor;
            return total += total * 0.60;
        }
    }
}
