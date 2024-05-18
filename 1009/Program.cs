using System;
using System.Globalization;
class URI
{

    static void Main(string[] args)
    {
        string nome;
        double salario, vendas, bonus;

        nome = Console.ReadLine();
        salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        bonus = vendas * 15 / 100 + salario;

        Console.WriteLine("TOTAL = R$ " + bonus.ToString("F2", CultureInfo.InvariantCulture));


    }

}