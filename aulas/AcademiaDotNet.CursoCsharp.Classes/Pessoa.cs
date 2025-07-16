using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaDotNet.CursoCsharp.Classes
{
    public class Pessoa
    {
        // propriedades
        public string nome { get; set; }
        public string cpf { get; set; }
        public string numeroContaCorrente { get; set; }
        public double saldo { get; set; }

        // métodos (ações) 
        public double EfetuarDeposito(double valorDeposito)
        {
            double saldo = this.saldo; // usando o valor fornecido no atributo saldo
            return saldo = saldo + valorDeposito;
        }
    }
}
