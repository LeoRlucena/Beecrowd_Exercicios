using System;

namespace _1134
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int combustivel = int.Parse(Console.ReadLine());
            int gasolina = 0;
            int alcool = 0;
            int diesel = 0;

            while (combustivel != 1 && combustivel != 2 && combustivel != 3 && combustivel != 4)
            {
                switch (combustivel)
                {
                    case 1:
                        alcool += 1;
                        combustivel = int.Parse(Console.ReadLine());
                        break;
                    case 2:
                        gasolina += 1;
                        combustivel = int.Parse(Console.ReadLine());
                        break;
                    case 3:
                        diesel += 1;
                        combustivel = int.Parse(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("MUITO OBRIGADO");
                        Console.WriteLine("Alcool: " + alcool);
                        Console.WriteLine("Gasolina: " + gasolina);
                        Console.WriteLine("Diesel: " + diesel);
                        break;
                }
            }
        }
    }
}
