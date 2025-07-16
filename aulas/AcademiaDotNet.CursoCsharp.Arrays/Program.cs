using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaDotNet.CursoCsharp.Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // usando arrays
            String[] nomes = new String[3] { "Kaique Onencio", "", "" }; // inicializando um novo array de STRINGS com 3 posições, especificando apenas a primeira posição
            nomes[1] = "Marina Frankin";
            nomes[2] = "Luiz Eduardo";

            Console.Write("O valor da posição 0 é: " + nomes[0]);
            Console.ReadLine();
            Console.Write("O valor da posição 1 é: " + nomes[1]);
            Console.ReadLine();
            Console.Write("O valor da posição 2 é: " + nomes[2]);
            Console.ReadLine();
        }
    }
}
