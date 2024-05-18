using System;
using System.Globalization;

namespace _1042
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, maior, meio, menor;
            string[] valores = Console.ReadLine().Split(' ');

            n1 = int.Parse(valores[0]);
            n2 = int.Parse(valores[1]);
            n3 = int.Parse(valores[2]);

            if (n1 < n2 && n1 < n3)
            {
                menor = n1;
                if (n2 < n3)
                {
                    meio = n2;
                    maior = n3;
                }
                else
                {
                    meio = n3;
                    maior = n2;
                }
            }
            else if (n2 < n3)
            {
                menor = n2;
                if (n1 < n3)
                {
                    meio = n1;
                    maior = n3;
                }
                else
                {
                    meio = n3;
                    maior = n1;
                }
            }
            else
            {
                menor = n3;
                if (n1 < n2)
                {
                    meio = n1;
                    maior = n2;
                }
                else
                {
                    meio = n2;
                    maior = n1;
                }
            }

            Console.WriteLine(menor);
            Console.WriteLine(meio);
            Console.WriteLine(maior);
            Console.WriteLine();
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
        }
    }
}
