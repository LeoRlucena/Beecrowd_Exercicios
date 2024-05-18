using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        int tempo, media_velocidade;
        double litros_necessarios;

        tempo = int.Parse(Console.ReadLine());
        media_velocidade = int.Parse(Console.ReadLine());

        litros_necessarios = (media_velocidade * tempo / 12.0);

        Console.WriteLine(litros_necessarios.ToString("F3", CultureInfo.InvariantCulture));
       

    }

}