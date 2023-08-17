using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula43ExFixacao
{
    internal class Alunos
    {
        public string Nome;
        public double Nota1tri;
        public double Nota2tri;
        public double Nota3tri;
        public int Media = 60;

        public double NotaFinal()
        {
            return Nota1tri + Nota2tri + Nota3tri;
        }

        public string Aprovado()
        {
            if (NotaFinal() >= Media)
            {
                return "Aprovado";
            }
            else
            {
                return "reprovado \nFaltam = " + (Media - NotaFinal()).ToString("F2");
            }
        }
    }
}
