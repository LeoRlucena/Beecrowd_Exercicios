using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        int funcionario, horas;
        double preco, salario;

        funcionario = int.Parse(Console.ReadLine());
        horas = int.Parse(Console.ReadLine());
        preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        salario = preco * horas;

        Console.WriteLine("NUMBER = " + funcionario);
        Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
     

    }

}