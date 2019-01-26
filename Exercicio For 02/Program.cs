using System;
using System.Globalization;

namespace Exercicio_For_02
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int dentro = 0;
            int fora = 0;

            Console.WriteLine("Digite a quantidader de numeors inteiros serão digitados");
            int x = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            for (int i = 1;i <= x; i++)
            {
                Console.WriteLine("Digite um valor inteiro");
                int num = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (num >= 10 && num <= 20)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }
            }
            Console.WriteLine(dentro + "in");
            Console.WriteLine(fora + "out");
        }

    }
}
