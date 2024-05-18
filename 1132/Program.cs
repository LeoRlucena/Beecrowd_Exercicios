using System;

namespace _1132
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine()); 
            int soma = 0;

            if ( X > Y )
            {
                int temp = X;
                X = Y;
                Y = temp;
            }

            for (int i = X; i <= Y; i++)
            {
                if (i % 13 != 0)
                {
                    soma = soma + i;
                }
            }

            Console.WriteLine(soma);
        }
    }
}
