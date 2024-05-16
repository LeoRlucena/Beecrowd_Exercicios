using System;

namespace _1101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int m = int.Parse(valores[0]);
            int n = int.Parse(valores[1]);
            int soma = 0;

            while(m > 0 && n > 0)
            {
                if (m <= 0 && n <= 0)
                {
                    break;
                }

                if (m < n)
                {
                    int temp = n;
                    n = m;
                    m = temp;

                }

                soma = n;

                while (n < m)
                {
                    
                    Console.Write($"{n} ");
                    n += 1;
                    soma = soma + n;
                }

                Console.WriteLine($"{m} Sum={soma}");

                valores = Console.ReadLine().Split(' ');
                m = int.Parse(valores[0]);
                n = int.Parse(valores[1]);
                soma = 0;
            }
        }
    }
}
