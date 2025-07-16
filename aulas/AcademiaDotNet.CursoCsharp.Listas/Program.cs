using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaDotNet.CursoCsharp.Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // usando listas - seu tamanho é aumentado a cada inserção
            List<String> listaNomes = new List<String>();
            listaNomes.Add("Kaique");
            listaNomes.Add("Gabriel");

            Console.Write("Posição inicial da lista: " + listaNomes[0] + ", com o tamanho de lista: " + listaNomes.Count());
            Console.ReadLine();

            bool existeNaLista = listaNomes.Contains("Gabriel"); // verifica se existe um valor na lista, retornando TRUE ou FALSE
            Console.Write("Existe 'Gabriel' na lista? " + existeNaLista);
            Console.ReadLine();
        }
    }
}
