using System;

namespace Exercicio_While_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva duas cordenadas do ponto cartesiano");
            string[] vet = Console.ReadLine().Split(' ');
            double x = int.Parse(vet[0]);
            double y = int.Parse(vet[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro");
                }
                else
                {
                    Console.WriteLine("Quarto" );
                }
                vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);
            }


        }
    }
}
