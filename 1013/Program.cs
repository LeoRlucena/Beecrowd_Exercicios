using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        double x1, x2, y1, y2, distancia;

        string[] v1 = Console.ReadLine().Split(' ');
        x1 = double.Parse(v1[0], CultureInfo.InvariantCulture);
        y1 = double.Parse(v1[1], CultureInfo.InvariantCulture);

        string[] v2 = Console.ReadLine().Split(' ');
        x2 = double.Parse(v2[0], CultureInfo.InvariantCulture);
        y2 = double.Parse(v2[1], CultureInfo.InvariantCulture);

        distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));
    }

}