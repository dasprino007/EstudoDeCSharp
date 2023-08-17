using Aula42SegundoProblema;

Produto p = new Produto();

Console.WriteLine("entre os dados do produto: ");
Console.Write("Nome:");
p.Nome = Console.ReadLine();
Console.Write("Preço:");
p.Preco = double.Parse(Console.ReadLine());
Console.Write("Quantidade no estoque: ");
p.Quantidade = int.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("dados do produto: " + p.ToString());
Console.WriteLine();
Console.WriteLine("digitar o numero de produtos a ser adicionado");
int qte = int.Parse(Console.ReadLine());
p.AdicionarProdutos(qte);
Console.WriteLine("dados Atualizados: " + p.ToString());
Console.WriteLine("digitar o numero de produtos a ser removido");
qte = int.Parse(Console.ReadLine());
p.RemoverProdutos(qte);
Console.WriteLine("dados Atualizados: " + p.ToString());