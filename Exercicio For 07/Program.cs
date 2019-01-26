using System;

namespace Exercicio_For_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor");
            int valor = int.Parse(Console.ReadLine());

            for (int i = 1; i <= valor; i++)
            {
                int primeiro = i ;
                int segundo = i * i;
                int terceiro = i * i * i;

                Console.WriteLine(""+primeiro+" "+segundo+" "+terceiro);
            }
                
                
        }
    }
}
