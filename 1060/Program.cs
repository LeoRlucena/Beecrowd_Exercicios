using System;

namespace _1060
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor1 = Convert.ToInt32(Console.ReadLine());
            int valor2 = Convert.ToInt32(Console.ReadLine());
            int valor3 = Convert.ToInt32(Console.ReadLine());
            int valor4 = Convert.ToInt32(Console.ReadLine());
            int valor5 = Convert.ToInt32(Console.ReadLine());
            int valor6 = Convert.ToInt32(Console.ReadLine());
            int positivos = 0;

            if (valor1 > 0)
            {
                positivos = positivos + 1;
            }
            else if (valor2 > 0)
            {
                positivos = positivos + 1;                
            }
            else if (valor3 > 0)
            {
                positivos = positivos + 1;
            }
            else if (valor4 > 0)
            {
                positivos = positivos + 1;
            }
            else if (valor5 > 0)
            {
                positivos = positivos + 1;
            }
            else if (valor6 > 0)
            {
                positivos = positivos + 1;
            }
            Console.WriteLine($"{positivos} valores positivos");
        }
    }
}
