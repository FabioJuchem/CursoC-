using System;

namespace Exercicio_While_03
{
    class Program
    {
        static void Main(string[] args)
        {

            int gas = 0;
            int alc = 0;
            int die = 0;

            Console.WriteLine("Digite o codigo combustivel abastecido");
            int cod = int.Parse(Console.ReadLine());

            while (cod != 4)
            {
                if (cod == 1)
                {
                    gas++;
                }
                else if (cod == 2)
                {
                    alc++;
                }
                else if (cod == 3)
                {
                    die++;
                }
                else
                {
                    Console.WriteLine("Digite um codigo valido");
                }
                Console.WriteLine("Proximo");
                cod = int.Parse(Console.ReadLine());
                
            }
            Console.WriteLine("Muito Obrgado");
            Console.WriteLine("Abastecimentos com Gasolina:  "  +gas   );
            Console.WriteLine("Abastecimentos com Alcool:  "  + alc);
            Console.WriteLine("Abastecimentos com Diesel:  " +die);
        }
    }
}
