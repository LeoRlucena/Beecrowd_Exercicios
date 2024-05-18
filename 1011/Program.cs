using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        double R, V, pi;

        pi = 3.14159;

        R = double.Parse(Console.ReadLine());

        V = (double) (4.0 / 3.0) * pi * Math.Pow(R, 3);

        Console.WriteLine("VOLUME = " + V.ToString("F3", CultureInfo.InvariantCulture));


    }

}