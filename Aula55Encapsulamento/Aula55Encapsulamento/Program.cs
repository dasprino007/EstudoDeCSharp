using System.Globalization;
using Aula55Encapsulamento;

Produto p = new Produto("tv",500,10);

Console.WriteLine(p.GetNome());

p.SetNome("tv 4k");

Console.WriteLine(p.GetNome());

p.SetNome("t");

Console.WriteLine(p.GetNome());
Console.WriteLine(p.GetPreco());