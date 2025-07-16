using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaDotNet.CursoCsharp.If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Estrutura de Controle 02: IF ELSE

            double saldoConta = 100.0;

            Console.Write("Digite um valor para debitar da sua conta: ");
            var debitar = Convert.ToDouble(Console.ReadLine());

            saldoConta = saldoConta - debitar;

            if (saldoConta == 100)
            {
                Console.WriteLine("O saldo continua o mesmo!");
            }
            else if (saldoConta > 0)
            {
                Console.WriteLine("O saldo continua positivo! Ainda restam {0} na conta.", saldoConta);
            }
            else
            {
                Console.WriteLine("O saldo ficou negativo!");
            }
        }
    }
}
