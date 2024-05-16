using System;

namespace _1095
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int I = 1;
            
            for (int J = 60; J >= 0; J = J - 5)
            {
                Console.WriteLine($"I={I} J={J}");
                I = I + 3;               
            }
        }
    }
}
