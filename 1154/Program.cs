using System;
using System.Globalization;

namespace _1154
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = int.Parse(Console.ReadLine());
            int contIdade = 0;
            int soma = 0;
            double media;

            while (idade >= 0)
            {
                contIdade += 1;
                soma = soma + idade;
                idade = int.Parse(Console.ReadLine());
            }

            media = (double) soma / contIdade;

            Console.WriteLine(media.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}
