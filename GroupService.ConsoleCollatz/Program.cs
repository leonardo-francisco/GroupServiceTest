using System;

namespace GroupService.ConsoleCollatz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maior_iteracoes = 0;
            int numero_maior = 0;
            for (int i = 1; i <= 1000000; i++)
            {
                int iterador = i;
                int num_iteracoes = 0;
               
                if (iterador % 2 == 0)
                {
                    iterador = iterador / 2;

                }
                else
                {

                    iterador = (iterador * 3) + 1;
                }
                num_iteracoes++;
                if (num_iteracoes > maior_iteracoes)
                {
                    maior_iteracoes = num_iteracoes;
                    numero_maior = i;
                }

                Console.WriteLine("Percorrendo as interacoes....{0}", i + " / Maior iteracao "+maior_iteracoes+" ,foi o numero "+numero_maior);
               
            }
            Console.WriteLine("Maior iteracao {0} foi o numero {1}", maior_iteracoes, numero_maior);
        }
    }
}
