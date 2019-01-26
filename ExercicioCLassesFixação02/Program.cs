using System;
using System.Globalization;

namespace ExercicioCLassesFixação02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

            Console.WriteLine("Digite o nome , Salario Bruto e Imposto dos funcionario em questão: ");
            func.Nome = Console.ReadLine();
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(func);

            Console.WriteLine("Digite em quanto deseja aumentar o salario do funcionario");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            func.AumentarSalario(porcent);

            Console.WriteLine("Dados atualizados: " + func);

        }
    }
}
