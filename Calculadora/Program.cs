using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Calculadora.Models;
using System.ComponentModel.Design;

namespace Calculadora
{
    public class Program
    {
        static void Main(string[] args)
        {
            Menu();
            Console.Write("Informe o valor: ");
            int operacao = int.Parse(Console.ReadLine());

            if(operacao == 0 || operacao == 5)
            {
                System.Environment.Exit(0);
                return;
            }

            Console.Write("\nInforme o primeiro valor: ");
            double valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("\nInforme o segundo valor: ");
            double valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var valorOperacao = CalculadoraOperacoes.ObterOperacao(operacao);

            var calc = new CalculadoraOperacoes(valorOperacao, valor1, valor2);

            calc.Resultado = calc.Calcula(valor1, valor2, calc.TipoOperacao);

            Console.WriteLine(calc);
            Console.ReadLine();
        }

        private static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Qual tipo de operação que voce quer executar?\nSomar = 1\nSubtrair = 2\nMultiplicar = 3\nDividir = 4\nSair do programa = 5\n");
        }
    }
}
