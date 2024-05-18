using System;

namespace _1146
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; x != 0; i++)
            {
                while (i <= x)
                {
                    Console.Write($"{i} ");
                    i = i + 1;
                }

                i = 0;

                Console.WriteLine();

                x = int.Parse(Console.ReadLine());
            }
        }
    }
}
