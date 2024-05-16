using System;

namespace _1134
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gasolina = 0;
            int alcool = 0;
            int diesel = 0;

            int tipo = int.Parse(Console.ReadLine());

            while (tipo != 4)
            {
                if (tipo == 1)
                {
                    alcool += 1;
                }
                else if (tipo == 2)
                {
                    gasolina += 1;
                }
                else if (tipo == 3)
                {
                    diesel += 1;
                }

                tipo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
