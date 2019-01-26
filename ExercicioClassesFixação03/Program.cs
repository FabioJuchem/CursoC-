using System;
using System.Globalization;

namespace ExercicioClassesFixação03
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno Alun = new Aluno();

            Console.WriteLine("Digite o nome do aluno ");
            Alun.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno");
            Alun.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Alun.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Alun.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Nota Final: " + Alun.NotaFinal().ToString("F1",CultureInfo.InvariantCulture));

            if (Alun.Aprovado())
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado!!!");
                Console.WriteLine("Faltaram: " + Alun.NotaRestante());
            }



        }
    }
}
