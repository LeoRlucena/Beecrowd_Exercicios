using System;
using System.Globalization;

namespace _1043
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, area, perimetro;
            string[] valores = Console.ReadLine().Split(' ');
            a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            c = double.Parse(valores[2], CultureInfo.InvariantCulture);


        }
    }
}
