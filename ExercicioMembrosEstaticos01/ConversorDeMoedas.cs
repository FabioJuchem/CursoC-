using System;

namespace ExercicioMembrosEstaticos01
{
    class ConversorDeMoedas
    {
        public static double iof = 6.0;

        public static double ValorTotalAPagar(double quantia, double cotacao)
        {
            double total = quantia * cotacao;
            return total * iof / 100 + total;
        }


    }
}
