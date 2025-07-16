using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaDotNet.CursoCsharp.Variaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // valor já estabelecido
            var nome = "Kaique";

            Console.Write("Nome da primeira variável (nome): " + nome); // retorna no console o valir da variável
            Console.ReadLine(); // ReadLine, diferentemente do Read, quebra linhas automaticamente

            // recebendo o valor
            Console.Write("Digite o nome da segunda variável (sobrenome): ");
            var sobrenome = Console.ReadLine();

            // concatenando nomes
            var nomeCompleto = nome + " " + sobrenome;

            Console.Write("Nome completo: " + nomeCompleto);
            Console.ReadLine();
        }
    }
}
