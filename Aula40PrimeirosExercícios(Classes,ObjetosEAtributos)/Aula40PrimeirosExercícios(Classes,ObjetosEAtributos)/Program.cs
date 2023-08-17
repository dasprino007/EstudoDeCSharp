using Aula40PrimeirosExercícios_Classes_ObjetosEAtributos_;
using System.Globalization;


Pessoa pessoa1 = new Pessoa(); 
Pessoa pessoa2 = new Pessoa();


Console.WriteLine("Dados da primeira pessoa :");
Console.Write("nome :");
pessoa1.nome = Console.ReadLine();
Console.Write("idade :");
pessoa1.idade = int.Parse(Console.ReadLine());
Console.WriteLine("Dados da segunda pessoa :");
Console.Write("nome :");
pessoa2.nome = Console.ReadLine();
Console.Write("idade :");
pessoa2.idade = int.Parse(Console.ReadLine());

if(pessoa1.idade > pessoa2.idade)
{
    Console.WriteLine("Pessoa mais velha:" + pessoa1.nome);
}

else
{
    Console.WriteLine("Pessoa mais velha:" + pessoa2.nome);
}


Funcionarios F1 = new Funcionarios();
Funcionarios F2 = new Funcionarios();


Console.WriteLine("Dados do primeiro funcionario :");
Console.Write("nome :");
F1.nome = Console.ReadLine();
Console.Write("salario :");
F1.salario = double.Parse(Console.ReadLine());
Console.WriteLine("Dados do segundo funcionario :");
Console.Write("nome :");
F2.nome = Console.ReadLine();
Console.Write("salario :");
F2.salario = double.Parse(Console.ReadLine());

double salMedio = (F1.salario + F2.salario) / 2.0;

Console.WriteLine("salario medio:" + salMedio.ToString("F2", CultureInfo.InvariantCulture));
