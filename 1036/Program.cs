using System;
using System.Globalization;

namespace _1036
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, delta, R1, R2;

            string[] valores = Console.ReadLine().Split(' ');
            A = double.Parse(valores[0]);
            B = double.Parse(valores[1]);
            C = double.Parse(valores[2]);

            delta = (Math.Pow(B, 2)) - (4 * A * C);

            R1 = (-B + Math.Sqrt(delta)) / (2 * A);
            R2 = (-B - Math.Sqrt(delta)) / (2 * A);

            if (delta < 0) 
            {
                Console.WriteLine("Impossivel calcular");
            }
            else if (A == 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                Console.WriteLine($"R1 = {R1.ToString("F5", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"R2 = {R2.ToString("F5", CultureInfo.InvariantCulture)}");
            }

        }
    }
}
