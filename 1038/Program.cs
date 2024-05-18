using System;
using System.Globalization;

namespace _1038
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigo, quantidade;
            double preco, item1, item2, item3, item4, item5;

            string[] vet = Console.ReadLine().Split(' ');
            codigo = int.Parse(vet[0]);
            quantidade = int.Parse(vet[1]);

            item1 = 4.00;
            item2 = 4.50;
            item3 = 5.00;
            item4 = 2.00;
            item5 = 1.50;

            switch (codigo)
            {
                case 1:
                    preco = item1 * quantidade;
                    Console.WriteLine($"Total: R$ {preco.ToString("F2") + CultureInfo.InvariantCulture}");
                    break;
                case 2:
                    preco = item2 * quantidade;
                    Console.WriteLine($"Total: R$ {preco.ToString("F2") + CultureInfo.InvariantCulture}");
                    break;
                case 3:
                    preco = item3 * quantidade;
                    Console.WriteLine($"Total: R$ {preco.ToString("F2") + CultureInfo.InvariantCulture}");
                    break;
                case 4:
                    preco = item4 * quantidade;
                    Console.WriteLine($"Total: R$ {preco.ToString("F2") + CultureInfo.InvariantCulture}");
                    break;
                case 5:
                    preco = item5 * quantidade;
                    Console.WriteLine($"Total: R$ {preco.ToString("F2") + CultureInfo.InvariantCulture}");
                    break;
            }
        }
    }
}
