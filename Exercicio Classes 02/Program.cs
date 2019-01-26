using System;
using System.Globalization;

namespace Exercicio_Classes_02
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionario func1, func2;
            func1 = new Funcionario();
            func2 = new Funcionario();

            Console.WriteLine("Digite o nome e o salario do primeiro funcionario:");
            func1.nome = Console.ReadLine();
            func1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o nome e o salario do segundo funcionario:");
            func2.nome = Console.ReadLine();
            func2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salMedio = (func1.salario + func2.salario) / 2;

            Console.WriteLine("O salario medio dos funcionarios é: " + salMedio.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
