using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upper.FDevs.Atividade01
{
    internal class Program
    {
        // Atividade 01: Desenvolva um projeto que utilize uma estrutura de repetição FOR para calcular a soma dos números de 1 a 10.
        static void Main(string[] args)
        {
            int tamanho = 10;
            int total = 0;

            Console.WriteLine("---- Soma dos números de 1 a 10 ---- \n");
            Console.ReadKey();

            for (int i = 0; i <= tamanho; i++)
            {
                int anterior = total;
                total = total + i;

                if (total > 1)
                {
                    Console.WriteLine("Soma atual ({0} + {1}): " + total, anterior, i);
                    Console.ReadKey();
                }
            };

            Console.WriteLine("\nSoma total de 1 a 10: " + total);
            Console.ReadLine();
        }
    }
}