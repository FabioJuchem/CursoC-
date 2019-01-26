using System;
using System.Globalization;

namespace Exercicio_Condicional_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero");
            double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (numero < 0.0 || numero > 100.00)
            {
                Console.WriteLine("NUmero fora do intervalo");
            }
            else if(numero <= 25.00)
            { 
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (numero <=50.00)
            {
                Console.WriteLine("Intervalo [25,50]");
            }
            else if (numero <= 75.00)
            {
                Console.WriteLine("Intervalo [50,75]");
            }
            else
            {
                Console.WriteLine("Intervalo [75,100]");
            }
        }
    }
}
