using System;
using System.Globalization;

namespace ExercicioEncapsulamento01
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta;

            Console.Write("Entrar com o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();
            Console.WriteLine("Haverá deposito inicial? (s/n) ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre com o valor de depopsito inicial: ");
                double depInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(titular, numero,depInicial);
            }
            else
            {
                conta = new Conta(titular, numero);
            }

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine("Entre um valor para Depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados atualizados : ");
            Console.WriteLine(conta);

            Console.WriteLine("Entre com um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(conta);
        }
    }
}
