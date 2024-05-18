using System;
using System.Globalization;

namespace _1050
{
    class Program
    {
        static void Main(string[] args)
        {
            int DDD = Convert.ToInt32(Console.ReadLine());

            if (DDD == 61)
            {
                System.Console.WriteLine("Brasilia");
            }
            else if (DDD == 71)
            {
                System.Console.WriteLine("Salvador");
            }
            else if (DDD == 11)
            {
                System.Console.WriteLine("Sao Paulo");
            }
            else if (DDD == 21)
            {
                System.Console.WriteLine("Rio de Janeiro");
            }
            else if (DDD == 32)
            {
                System.Console.WriteLine("Juiz de Fora");
            }
            else if (DDD == 19)
            {
                System.Console.WriteLine("Campinas");
            }
            else if (DDD == 27)
            {
                System.Console.WriteLine("Vitoria");
            }
            else if (DDD == 31)
            {
                System.Console.WriteLine("Belo Horizonte");
            }
            else
            {
                System.Console.WriteLine("DDD nao cadastrado");
            }
        }
    }
}