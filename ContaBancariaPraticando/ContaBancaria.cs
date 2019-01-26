using System;
using System.Globalization;


namespace ContaBancariaPraticando
{
    class ContaBancaria
    {
        public int NumeroConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        //construtor

        public ContaBancaria(int numeroConta, string titular)
        {
            NumeroConta = numeroConta;
            Titular = titular;
        }

        public ContaBancaria(int numeroConta, string titular, double saldo) : this(numeroConta, titular)
        {
            Saldo = saldo;
        }

        // metodos


        public void Deposito(double quantia)
        {
            Saldo = Saldo + quantia;
        }
        public void Saque(double quantia)
        {
            Saldo = Saldo - (quantia + 5.0);
        }




        //public override

        public override string ToString()
        {
            return "Conta: " + NumeroConta
                + ", Titular: " + Titular
                + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);

        }

    }
}
