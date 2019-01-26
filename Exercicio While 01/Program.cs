using System;

namespace Exercicio_While_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Digite a senha: ");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha incorreta!");
                Console.WriteLine("Tente novamente");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso permitido");
        }
    }
}
