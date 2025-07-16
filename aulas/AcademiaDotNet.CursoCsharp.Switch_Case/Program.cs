using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaDotNet.CursoCsharp.Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Estrutura de Controle 03: SWITCH CASE

            double saldoConta = 100.0;

            Console.Write("Digite um valor para debitar da sua conta: ");
            var debitar = Convert.ToDouble(Console.ReadLine());

            saldoConta = saldoConta - debitar;

            switch (saldoConta)
            {
                // se o valor do saldo for 50, executa aqui
                case 50.0:
                    Console.WriteLine("Você debitou 50$ da sua conta");
                    break;

                // se o valor do saldo for 50, executa aqui
                case 10.0:
                    Console.WriteLine("Você debitou 90$ da sua conta");
                    break;

                default:
                    Console.WriteLine("Você debitou {0}$ da sua conta", debitar);
                    break;
            }
        }
    }
}
