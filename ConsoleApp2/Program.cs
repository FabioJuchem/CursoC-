using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Digite um numero" );
            double x = double.Parse(Console.ReadLine());

            if (x >= 0)
            {
                Console.WriteLine("NÃO NEGATIVO");
            }
            else
            {
                Console.WriteLine("NEGATIVO");
            }



        }
    }
}
