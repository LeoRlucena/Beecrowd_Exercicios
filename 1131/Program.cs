using System;

namespace _1131
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int empates = 0;
            int vitoriasInter = 0;
            int vitoriasGremio = 0;
            int novoGrenal = 1;

            while (novoGrenal == 1)
            {          
                string[] gols = Console.ReadLine().Split(' ');
                int golsInter = int.Parse(gols[0]);
                int golsGremio = int.Parse(gols[1]);

                if (golsInter > golsGremio)
                {
                    vitoriasInter += 1;
                }
                else if (golsGremio > golsInter)
                {
                    vitoriasGremio += 1;
                }
                else
                {
                    empates += 1;
                }

                Console.WriteLine("Novo Grenal (1-sim 2-nao");
                novoGrenal = int.Parse(Console.ReadLine());
            }

            int total = vitoriasGremio + vitoriasInter + empates;

            Console.WriteLine(total + " grenais");
            Console.WriteLine("Inter: " + vitoriasInter);
            Console.WriteLine("Gremio: " + vitoriasGremio);
            Console.WriteLine("Empates: " + empates);

            if (vitoriasInter > vitoriasGremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else if (vitoriasGremio > vitoriasInter)
            {
                Console.WriteLine("Gremio venceu mais");
            }
            else
            {
                Console.WriteLine("Nao houve vencedor");
            }
        }
    }
}
