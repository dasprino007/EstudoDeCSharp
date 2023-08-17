// ex1
using Aula43ExFixacao;
using System.ComponentModel;

Retangulo retangulo = new Retangulo();

Console.WriteLine("coloque altura e largura");
retangulo.altura = double.Parse(Console.ReadLine());
retangulo.largura = double.Parse(Console.ReadLine());

Console.WriteLine("Area = " + retangulo.Area());
Console.WriteLine("Area = " + retangulo.Perimetro());
Console.WriteLine("Area = " + retangulo.Diagonal());


Funcionario F1 = new Funcionario();

Console.Write("nome :");
F1.Nome = Console.ReadLine();
Console.Write("Salario bruto :");
F1.SalarioBruto = double.Parse(Console.ReadLine());
Console.Write("Imposto :");
F1.Imposto = double.Parse(Console.ReadLine());
Console.WriteLine("dados do produto: " + F1.ToString());
Console.Write("Digite a porcentagem para aumentar o salário:");
double porcetagem = double.Parse(Console.ReadLine());
F1.AumentarSalario(porcetagem);
Console.WriteLine("Dados atualizados: " + F1.ToString());


Alunos aluno = new Alunos();

Console.Write("Nome do aluno:");
aluno.Nome = Console.ReadLine();

Console.WriteLine("Digite as três notas do aluno:");
aluno.Nota1tri = double.Parse(Console.ReadLine());
aluno.Nota2tri = double.Parse(Console.ReadLine());
aluno.Nota3tri = double.Parse(Console.ReadLine());

Console.WriteLine("Nota Final = " + aluno.NotaFinal());
Console.WriteLine(aluno.Aprovado());