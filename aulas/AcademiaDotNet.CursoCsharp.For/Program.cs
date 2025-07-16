using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaDotNet.CursoCsharp.For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Estrutura de Controle 01: FOR
            int tamanho = 10;

            for (int i = 0; i <= tamanho; i++)
            {
                Console.WriteLine("O valor da variável i é: " + i);
                Console.ReadKey(); // não executa todo o FOR automaticamente
            }
        }
    }
}
