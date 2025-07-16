using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaDotNet.CursoCsharp.Operacoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // fazendo operações
            double saldo = 100.0;
            saldo = saldo - 10.0; // diminui 10$ do saldo atual

            Console.Write("O saldo atual é: R$" + saldo);
            Console.ReadLine();
        }
    }
}
