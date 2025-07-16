using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaDotNet.CursoCsharp.Enum
{
    // criando ENUMS
    enum DiasDaSemana
    {
        // é possível atribuir valores para cada ENUM
        Domingo = 0,
        SegundaFeira = 1,
        TercaFeira = 2,
        QuartaFeira = 3,
        QuintaFeira = 4,
        SextaFeira = 5,
        Sabado = 6
    };

    enum DiasUteisDaSemana
    {
        SegundaFeira,
        TercaFeira,
        QuartaFeira,
        QuintaFeira,
        SextaFeira
    };

    internal class Program
    {
        static void Main(string[] args)
        {
            // usando os enums que foram criados acima - enums evitam que um valor diferente seja atribuido para certos lugares do código, limitando-os
            var diasUteisDaSemana = DiasUteisDaSemana.SextaFeira;
            int diaDaSemana = (int)DiasDaSemana.Sabado; // conversão do tipo do valor (DiasDaSemana) para INT

            Console.Write("Dia útil da semana (texto): " + diasUteisDaSemana);
            Console.ReadLine();
            Console.Write("Dia da semana (valor): " + diaDaSemana);
            Console.ReadLine();
        }
    }
}
