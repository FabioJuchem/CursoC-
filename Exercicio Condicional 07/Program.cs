using System;

namespace Exercicio_Condicional_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois pontos do plano cartesiano");
            string[] vet = Console.ReadLine().Split(' ');

            double x = double.Parse(vet[0]);
            double y = double.Parse(vet[1]);

            if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("ORIGEM");
            }
            else if (x == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (y == 0.0)
            {
                Console.WriteLine("EIXO Y");
            }
            else if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Quandrante Q1");
            }
            else if (x > 0.0 && y < 0.0)
            {
                Console.WriteLine("Quadrante q4" );
            }
            else if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Quadrante q1");
            }
            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Quadrante q2");
            }
            else if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Quadrante q3");
            }
        }
    }
}
