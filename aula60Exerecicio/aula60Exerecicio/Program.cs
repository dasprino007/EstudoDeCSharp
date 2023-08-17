// See https://aka.ms/new-console-template for more information
using aula60Exerecicio;

ContaBanco conta;

Console.Write("Entre o número da conta:");
int num = int.Parse(Console.ReadLine());
Console.Write("Entre o titular da conta:");
string nome = Console.ReadLine();
Console.Write("Haverá depósito inicial (s/n)?");
string verdade = Console.ReadLine();

if(verdade == "s")
{
    Console.Write("Entre o valor de depósito inicial:");
    double venda = double.Parse(Console.ReadLine());

     conta = new ContaBanco(num, nome, venda);
}

else
{
    conta = new ContaBanco(num, nome);
}

Console.WriteLine("Dados da conta:");
Console.WriteLine(conta.ToString());

Console.Write("Entre um valor para depósito:");
double dinheiro  = double.Parse(Console.ReadLine());

conta.Depositar(dinheiro);

Console.WriteLine("Dados atualizados:");
Console.WriteLine(conta.ToString()); 

Console.Write("Entre um valor para sacar:");
dinheiro = double.Parse(Console.ReadLine());

conta.Saquar(dinheiro);

Console.WriteLine("Dados atualizados:");
Console.WriteLine(conta.ToString());

