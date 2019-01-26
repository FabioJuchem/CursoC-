using System;

namespace Exercicio_Condicional_05
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o codigo, a quantidade do item: ");
            string[] vet = Console.ReadLine().Split(' ');
            int cod = int.Parse(vet[0]);
            double quant = double.Parse(vet[1]);
            double total;

            if (cod == 1)
            {
                total = quant * 4.00;
                Console.WriteLine("Valor Total :" + total);
            }
            else if (cod == 2)
            {
                total = quant * 4.50;
                Console.WriteLine("Valor Total :" + total);
            }
            else if (cod == 3)
            {
                total = quant* 5;
                Console.WriteLine("Valor Total :" + total);
            }
            else if (cod == 4)
            {
                total = quant * 2.00;
                Console.WriteLine("Valor Total :" + total);
            }
            else
            {
                total = quant * 1.50;
                Console.WriteLine("Valor Total :" + total);
            }






        }
    }
}
