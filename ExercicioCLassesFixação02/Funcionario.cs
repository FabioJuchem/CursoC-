using System;
using System.Globalization;


namespace ExercicioCLassesFixação02
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiq()
        {
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem) / 100.0;
        }

        public override string ToString()
        {
            return "Funcionario: " + Nome + ", $ " + SalarioLiq().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
