using System;
using System.Globalization;

namespace ExercicioClassesFixação01
{
    class Program
    {
        static void Main(string[] args)
        {


            Retangulo ret;
            ret = new Retangulo();
            
            Console.WriteLine("Digite a largura e altura de um retangulo: ");
            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("AREA: " + ret.Area().ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO: " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL: " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
