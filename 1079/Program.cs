using System;
using System.Globalization;

namespace _1079
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

           
            for (int i = 1; i <= N; i++)
            { 
                string[] aluno = Console.ReadLine().Split(' ');

                double n1 = double.Parse(aluno[0]);
                double n2 = double.Parse(aluno[1]);
                double n3 = double.Parse(aluno[2]);

                double media = (n1 * 2.0 + n2 * 3.0 + n3 * 5.0) / 10.0;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
