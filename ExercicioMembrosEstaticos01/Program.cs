using System;
using System.Globalization;

namespace ExercicioMembrosEstaticos01
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Qual é a cotação do dolar? ");
            double cot = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Quantos Dolares voce vai comprar? ");
            double quant = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = ConversorDeMoedas.ValorTotalAPagar(cot, quant);

            Console.WriteLine("Valor a ser pago em reais: " + resultado);

        }
    }
}
