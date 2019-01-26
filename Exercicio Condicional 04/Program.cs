using System;

namespace Exercicio_Condicional_04
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite a hora inicial e a hora final");
            string[] vet = Console.ReadLine().Split(' ');
            int inic = int.Parse(vet[0]);
            int final = int.Parse(vet[1]);

            int totalhoras;

            if ( inic < final)
            {
                totalhoras = final - inic;
                Console.WriteLine("Total de horas jogadas: " + totalhoras);
            }
            else
            {
                totalhoras = 24 - inic + final;
                Console.WriteLine("Total de horas jogadas: " + totalhoras);
            }
        }
    }
}
