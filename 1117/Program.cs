using System;
using System.Globalization;

namespace _1117
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1 = double.Parse(Console.ReadLine());
            while (nota1 < 0.0 || nota1 > 10.0)
            {
                Console.WriteLine("nota invalida");
                nota1 = double.Parse(Console.ReadLine());
            }

            double nota2 = double.Parse(Console.ReadLine());
            while (nota2 < 0.0 || nota2 > 10.0)
            {
                Console.WriteLine("nota invalida");
                nota2 = double.Parse(Console.ReadLine());
            }

            double media = (nota1 + nota2) / 2;
            Console.WriteLine($"media = {media.ToString("F2") + CultureInfo.InvariantCulture}");
        }
    }
}
