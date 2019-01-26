using System;

namespace Exercicio_For_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero que deseja obter seus respectivos divisores");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
