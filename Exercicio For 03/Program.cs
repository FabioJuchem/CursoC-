using System;
using System.Globalization;

namespace Exercicio_For_03
{
    class Program
    {
        static void Main(string[] args)
        {
             

            Console.WriteLine("Digite a quantidade de testes");
            int teste = int.Parse(Console.ReadLine());

            for (int i = 1; i <= teste; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                double a = double.Parse(vet[0], CultureInfo.InvariantCulture);
                double b = double.Parse(vet[1], CultureInfo.InvariantCulture);
                double c = double.Parse(vet[2], CultureInfo.InvariantCulture);

                double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));

            }


        }
    }
}
