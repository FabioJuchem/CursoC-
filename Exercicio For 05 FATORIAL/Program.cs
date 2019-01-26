using System;

namespace Exercicio_For_05_FATORIAL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero que deseja obter o fatorial");
            int n = int.Parse(Console.ReadLine());

            int fat = 1;
            for (int i = 1; i <= n; i++)
            {
                fat = fat * i;
            }
            Console.WriteLine(fat);
        }
    }
}
