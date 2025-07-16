using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaDotNet.CursoCsharp.ForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Estrutura de Controle 04: FOR EACH
            List<String> pessoas = new List<String> { "Kaique", "Tiago", "Raul" };
            foreach (var item in pessoas)
            {
                Console.WriteLine("O nome da pessoa é: " + item);
            }
        }
    }
}
