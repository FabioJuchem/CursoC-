using System;

namespace Exercicio_For_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de numeros desejado!");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        
        }
    }
}
