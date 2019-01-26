using System;
using System.Globalization;

namespace ExercicioClassesFixação0._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

            Console.WriteLine("Digite o nome, Salario Bruto e impostos pagos pelo funcionario: ");
            func.Nome = Console.ReadLine();
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionario: " + func);

            Console.WriteLine("Digite a porcentagem de aumento do funcionario");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            func.AumentoSalario(porcent);

            Console.WriteLine("Dados Atualizados: " + func);

        }
    }
}
