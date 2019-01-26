using System;

namespace Exercicio_Classes_01
{
    class Program
    {
        static void Main(string[] args)
        {

            Pessoa primeira, segunda;
            primeira = new Pessoa();
            segunda = new Pessoa();
            
            Console.WriteLine("Descreva os dados da primeira pessoa");
            primeira.nome = Console.ReadLine();
            primeira.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Descreva os dados da segunda pessoa");
            segunda.nome = Console.ReadLine();
            segunda.idade = int.Parse(Console.ReadLine());

            if ( primeira.idade > segunda.idade)
            {
                Console.WriteLine("Pessoa mais velha : " + primeira.nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha : " + segunda.nome);
            }


        }
    }
}
