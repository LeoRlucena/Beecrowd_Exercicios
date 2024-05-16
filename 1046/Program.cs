using System;
using System.Globalization;

namespace _1046
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] horas = Console.ReadLine().Split(' ');
            int inicio = int.Parse(horas[0]);
            int final = int.Parse(horas[1]);

            int duracao;

            if (inicio < final)
            {
                duracao = final + inicio;
            }
            else
            {
                duracao = 24 - inicio + final;                
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}
