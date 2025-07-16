using AcademiaDotNet.CursoCsharp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// OBS: lembrar de definir o projeto de inicialização no Gerenciador de Soluções
// namespace é uma forma de separação, a classe 'Program' pertence ao namespace AcademiaDotNet.CursoCsharp.ConsoleApplication
namespace AcademiaDotNet.CursoCsharp.Classes
{
    class Program
    {

        static void Main(string[] args)
        {
            // instanciando um novo usuario de classe PESSOA por atributos manualmente
            Pessoa usuario = new Pessoa();
            usuario.nome = "Kaique";
            usuario.cpf = "111.222.333-00";
            usuario.numeroContaCorrente = "010203";
            usuario.saldo = 1125;

            // instanciando um novo usuário de classe PESSOA diretamente utilizando os nomes das propriedades (dessa forma, a ordem não importa, mas é uma boa prática manter em ordem)
            Pessoa usuario2 = new Pessoa()
            {
                cpf = "222.222.111-11",
                nome = "Pedro",
                numeroContaCorrente = "020103",
                saldo = 100
            };

            // fazendo uma lista de objetos de tipo PESSOA
            List<Pessoa> ListaDePessoas = new List<Pessoa>();
            ListaDePessoas.Add(usuario);
            ListaDePessoas.Add(usuario2);

            foreach (var item in ListaDePessoas)
            {
                Console.WriteLine("---- Pessoa ----");
                Console.WriteLine("Nome: " + item.nome);
                Console.WriteLine("CPF: " + item.cpf);
                Console.WriteLine("Conta Corrente: " + item.numeroContaCorrente);
                Console.WriteLine("Saldo: R$" + item.saldo);
                Console.WriteLine("Saldo (+50 reais): R$" + item.EfetuarDeposito(50)); // usando o método
                Console.WriteLine("");
            }
        }
    }   
}
