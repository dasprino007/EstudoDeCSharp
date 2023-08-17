// See https://aka.ms/new-console-template for more information
using aula56Propriedades;
using System.Net.Http.Headers;

Produto p = new Produto("tv",200.0,10);

Console.WriteLine(p.Nome);

p.Nome = "tv 4k";