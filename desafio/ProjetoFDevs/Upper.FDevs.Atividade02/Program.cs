using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upper.FDevs.Atividade02
{
    internal class Program
    {
        // Atividade 02: Crie um programa que calcule o índice de Massa Corporal (IMC). Solicite ao usuário que insira seu peso (em quilogramas) e sua altura (em metros).
        // O IMC é calculado pela fórmula:  peso / (altura * altura). Exiba o resultado indicando a faixa de classificação.
        static void Main(string[] args)
        {
            // obs: é preciso escrever os valores com VÍRGULA por conta da região, senão dá um valor baixíssimo
            Console.WriteLine("---- Calculador de Massa Corporal (IMC) ----");

            Console.Write("Digite o seu peso (em kg): ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a sua altura (em metros): ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double imc = Math.Round(peso / (altura * altura), 2); // arredondando para duas casas decimais
            string classificacao = "";

            Console.WriteLine("Valor do IMC: " + imc);

            if (imc < 18.5)
            {
                classificacao = "Abaixo do Peso";
            }
            else if (imc < 25)
            {
                classificacao = "Peso Normal";
            }
            else if (imc < 30)
            {
                classificacao = "Obesidade grau I";
            }
            else if (imc <= 40)
            {
                classificacao = "Obesidade grau II";
            }
            else
            {
                classificacao = "Obesidade grau III";
            };

            Console.WriteLine("Classificação: " + classificacao);
        }
    }
}
