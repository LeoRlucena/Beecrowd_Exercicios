using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        double pi, raio, area;

        pi = 3.14159;

        raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        area = pi * Math.Pow(raio, 2);

        Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));

    }

}