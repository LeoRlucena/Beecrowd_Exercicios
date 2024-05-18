using System;
using System.Globalization;

namespace uri1060
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int b = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int c = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int d = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int e = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int cont = 0;

            if (a % 2 == 0)
            {
                cont = cont + 1;
            }
            if (b % 2 == 0)
            {
                cont = cont + 1;
            }
            if (c % 2 == 0)
            {
                cont = cont + 1;
            }
            if (d % 2 == 0)
            {
                cont = cont + 1;
            }
            if (e % 2 == 0)
            {
                cont = cont + 1;
            }

            Console.WriteLine(cont + " valores pares");
        }
    }
}

