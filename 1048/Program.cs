using System;
using System.Globalization;

namespace _1048
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario, reajuste;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario >= 0.0 && salario <= 400.0)
            {
                reajuste = salario * 15 / 100;
                salario = salario + reajuste;
                Console.WriteLine($"Novo salario: {salario.ToString("F2") + CultureInfo.InvariantCulture}");
                Console.WriteLine($"Reajuste ganho: {reajuste.ToString("F2") + CultureInfo.InvariantCulture}");
                Console.WriteLine("Em percentual: 15 %");
            }
            else if (salario > 400.0 && salario <= 800.0)
            {
                reajuste = salario * 12 / 100;
                salario = salario + reajuste;
                Console.WriteLine($"Novo salario: {salario.ToString("F2") + CultureInfo.InvariantCulture}");
                Console.WriteLine($"Reajuste ganho: {reajuste.ToString("F2") + CultureInfo.InvariantCulture}");
                Console.WriteLine("Em percentual: 12 %");
            }
            else if (salario > 800.0 && salario <= 1200.0)
            {
                reajuste = salario * 10 / 100;
                salario = salario + reajuste;
                Console.WriteLine($"Novo salario: {salario.ToString("F2") + CultureInfo.InvariantCulture}");
                Console.WriteLine($"Reajuste ganho: {reajuste.ToString("F2") + CultureInfo.InvariantCulture}");
                Console.WriteLine("Em percentual: 10 %");
            }
            else if (salario > 1200.0 && salario <= 2000.0)
            {
                reajuste = salario * 7 / 100;
                salario = salario + reajuste;
                Console.WriteLine($"Novo salario: {salario.ToString("F2") + CultureInfo.InvariantCulture}");
                Console.WriteLine($"Reajuste ganho: {reajuste.ToString("F2") + CultureInfo.InvariantCulture}");
                Console.WriteLine("Em percentual: 7 %");
            }
            else
            {
                reajuste = salario * 4 / 100;
                salario = salario + reajuste;
                Console.WriteLine($"Novo salario: {salario.ToString("F2") + CultureInfo.InvariantCulture}");
                Console.WriteLine($"Reajuste ganho: {reajuste.ToString("F2") + CultureInfo.InvariantCulture}");
                Console.WriteLine("Em percentual: 4 %");
            }
        }
    }
}
