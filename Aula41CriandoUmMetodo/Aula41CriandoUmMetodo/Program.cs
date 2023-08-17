using Aula41CriandoUmMetodo;
using System.Globalization;

Triangulo x, y;

x = new Triangulo();
y = new Triangulo();

Console.WriteLine("entre com as medidadas do trinagulo x:");
x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("entre com as medidadas do trinagulo Y:");
y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


double areaX = x.Area();

double areaY = y.Area();

Console.WriteLine("Area de X =" + areaX.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine("Area de Y =" + areaY.ToString("F4", CultureInfo.InvariantCulture));

if (areaX > areaY)
{
    Console.WriteLine("Maior area X");
}
else
{
    Console.WriteLine("Maior area Y");
}
