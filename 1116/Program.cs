using System;

namespace _1116
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                int x = int.Parse(valores[0]);
                int y = int.Parse(valores[1]);

                if (y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }

                else
                {
                    double divisao = (double)x / y;
                    Console.WriteLine(divisao.ToString("F1"));
                }
            }
        }
    }
}
