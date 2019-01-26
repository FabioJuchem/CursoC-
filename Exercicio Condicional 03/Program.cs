using System;

namespace Exercicio_Condicional_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois valores inteiros");
            string[] vet = Console.ReadLine().Split(' ');
            double a =double.Parse(vet[0]);
            double b =double.Parse(vet[1]);

            if (a % b == 0 || b % a == 0)
            {
                Console.WriteLine("São Multiplos");
            }
            else
            {
                Console.WriteLine("Não são multiplos");
            }
        }
    }
}
