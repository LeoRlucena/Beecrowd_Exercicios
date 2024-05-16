using System;
using System.Globalization;

namespace _1043
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Leia 3 valores reais (A, B e C) e verifique se eles formam ou não um triângulo.
            //Em caso positivo, calcule o perímetro do triângulo e apresente a mensagem: Perimetro = XX.X
            //Em caso negativo, calcule a área do trapézio que tem A e B como base e C como altura, mostrando a mensagem
            //Area = XX.X

            double a, b, c, area, perimetro;
            string[] vet = Console.ReadLine().Split(' ');

            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            if (a < b + c && b < a + c && c < a + b)
            {
                perimetro = a + b + c;
                Console.WriteLine("Perimetro = " + perimetro.ToString("F1"), CultureInfo.InvariantCulture);
            }
            else
            {
                area = ((a + b) * c) / 2;
                Console.WriteLine("Area = " + area.ToString("F1"), CultureInfo.InvariantCulture);
            }
        }
    }
}
