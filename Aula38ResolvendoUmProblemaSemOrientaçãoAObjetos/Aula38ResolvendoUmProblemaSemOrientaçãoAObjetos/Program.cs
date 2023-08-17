using Aula38ResolvendoUmProblemaSemOrientaçãoAObjetos;
using System.Globalization;
/*
double XA, XB, XC, YA, YB, YC;


Console.WriteLine("entre com as medidadas do trinagulo x:");
XA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
XB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
XC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("entre com as medidadas do trinagulo Y:");
YA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
YB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
YC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double p = (XA + XB + XC) / 2.0;
double areaX = Math.Sqrt(p * (p - XA) * (p - XB) * (p - XC));

p = (YA + YB + YC) / 2.0;
double areaY = Math.Sqrt(p * (p - YA) * (p - YB) * (p - YC));

Console.WriteLine("Area de X =" + areaX.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine("Area de Y =" + areaY.ToString("F4", CultureInfo.InvariantCulture));

if (areaX > areaY)
{
    Console.WriteLine("Maior area X");
}
else
{
    Console.WriteLine("Maior area Y");
}*/

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

double p = (x.A + x.B + x.C) / 2.0;
double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

p = (y.A + y.B + y.C) / 2.0;
double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

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
