using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        int p1, n1, p2, n2;
        double v1, v2, total;

        string[] valores = Console.ReadLine().Split(' ');
        p1 = int.Parse(valores[0]);
        n1 = int.Parse(valores[1]);
        v1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

        string[] valores2 = Console.ReadLine().Split(' ');
        p2 = int.Parse(valores2[0]);
        n2 = int.Parse(valores2[1]);
        v2 = double.Parse(valores2[2], CultureInfo.InvariantCulture);

        total = v1 * n1 + v2 * n2;

        Console.WriteLine("VALOR A PAGAR = R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

        

    }

}