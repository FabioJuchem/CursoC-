using System;
using System.Globalization;

namespace Exercicio_For_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite quantidade de numeros a dividir");
            int quant = int.Parse(Console.ReadLine());

            for ( int i = 1; i <= quant; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                double a = double.Parse(vet[0], CultureInfo.InvariantCulture);
                double b = double.Parse(vet[1], CultureInfo.InvariantCulture);

                 if ( b == 0)
                {
                    Console.WriteLine("Divisão Impossivel");
                }
                else
                {
                    double result = a / b;
                    Console.WriteLine("Resultado: " + result.ToString("f1",CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
