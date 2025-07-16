using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaDotNet.CursoCsharp.Constantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // usando constantes - diferentemente das variáveis, elas tem um valor fixo, que não é alterado
            const double pi = 3.14159;
            double raio = 5.3;
            double area = pi * (raio * raio);
            Console.WriteLine("O valor da área é: " + area);
        }
    }
}
