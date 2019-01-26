using System;
using System.Globalization;

namespace ExercicioEncapsulamento01
{
    class Conta
    {
        public string Nome { get; set; }
        public int NumeroConta { get; private set; }
        public double Saldo { get; private set; }

        //Construtor
        public Conta(string nome, int numeroConta)
        {
            Nome = nome;
            NumeroConta = numeroConta;
            
        }
        public Conta(string nome , int numeroConta , double saldo) :this(nome, numeroConta)
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

        // override

        public override string ToString()
        {
            return "Conta " + NumeroConta +
                " , Titular: " + Nome +
                " , Saldo: " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }












    }
}
