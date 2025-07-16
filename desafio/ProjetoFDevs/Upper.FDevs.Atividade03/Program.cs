using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upper.FDevs.Atividade03
{
    internal class Program
    {
        // Atividade 03: Desenvolva uma calculadora simples que permita ao usuário realizar operações de SOMA, SUBTRAÇÃO, MULTIPLICAÇÃO e DIVISÃO.
        // O programa deve solicitar dois números e a operação desejada. Exiba o resultado no console.
        static void Main(string[] args)
        {
            Console.WriteLine("---- Calculadora Simples ----\n");

            Console.Write("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nEscolha a operação desejada:\n");
            Console.WriteLine("1. Soma (+)");
            Console.WriteLine("2. Subtração (-)");
            Console.WriteLine("3. Multiplicação (*)");
            Console.WriteLine("4. Divisão (/)");
            string operacao = Console.ReadLine();
            double resultado = 0;
           
            // Validando com SWITCH CASE
            switch (operacao.ToLower())
            {
                case "1":
                case "+":
                case "soma":
                    operacao = "Soma";
                    resultado = Math.Round(num1 + num2, 2);
                    Console.WriteLine("OPERAÇÃO: " + operacao);
                    Console.WriteLine("{0} + {1} = " + resultado, num1, num2);
                    break;

                case "2":
                case "-":
                case "subtração":
                case "subtracao":
                    operacao = "Subtração";
                    resultado = Math.Round(num1 - num2, 2);
                    Console.WriteLine("OPERAÇÃO: " + operacao);
                    Console.WriteLine("{0} - {1} = " + resultado, num1, num2);
                    break;

                case "3":
                case "*":
                case "multiplicação":
                case "multiplicacao":
                    operacao = "Multiplicação";
                    resultado = Math.Round(num1 * num2, 2);
                    Console.WriteLine("OPERAÇÃO: " + operacao);
                    Console.WriteLine("{0} x {1} = " + resultado, num1, num2);
                    break;

                case "4":
                case "/":
                case "divisão":
                case "divisao":
                    if (num2 != 0)
                    {
                        operacao = "Divisão";
                        resultado = Math.Round(num1 / num2, 2);
                        Console.WriteLine("OPERAÇÃO: " + operacao);
                        Console.WriteLine("{0} / {1} = " + resultado, num1, num2);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Resultado indefinido. Por favor, informe outro número no lugar de {0}!", num2);
                        break;
                    }

                default:
                    Console.WriteLine("Operação inválida. Por favor, tente novamente.");
                    break;
            }
        }
    }
}
