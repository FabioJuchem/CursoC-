using System;
using System.Globalization;

namespace ExercicioClassesFixação0._2
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentoSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.00);
        }

        public override string ToString()
        {
            return Nome
                + ", $"
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
