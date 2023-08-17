using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula60Exerecicio
{
    internal class ContaBanco
    {
        public int NumConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public ContaBanco(int numConta, string titular)
        {
            NumConta = numConta;
            Titular = titular;
            
        }

        public ContaBanco(int numConta, string titular, double saldo) : this(numConta, titular) 
        {
            saldo = Saldo;
        }

        public double Depositar(double deposito)
        {
           return Saldo += deposito;
        }

        public double Saquar(double saquar)
        {
            return Saldo -= saquar + 5.0;
        }

        public override string ToString()
        {
            return "Conta "
                + NumConta
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
