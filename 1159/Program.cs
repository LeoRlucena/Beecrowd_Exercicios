using System;

namespace _1159
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());

            while (X != 0)
            {
                if (X % 2 == 0)
                {
                    X = X + (X + 2) + (X + 4) + (X + 6) + (X + 8);
                    Console.WriteLine(X);
                    X = int.Parse(Console.ReadLine());
                }
                else
                {
                    X += 1;
                    X = X + (X + 2) + (X + 4) + (X + 6) + (X + 8);
                    Console.WriteLine(X);
                    X = int.Parse(Console.ReadLine());
                }                
            }
        }
    }
}
