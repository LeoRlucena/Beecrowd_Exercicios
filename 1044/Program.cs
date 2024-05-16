using System;
using System.Globalization;

namespace _1044
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int A = int.Parse(valores[0], CultureInfo.InvariantCulture);
            int B = int.Parse(valores[1], CultureInfo.InvariantCulture);

            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
