using System;

namespace Exercicio_Condicional_02
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um numero");
            double x = double.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
        }
    }
}
