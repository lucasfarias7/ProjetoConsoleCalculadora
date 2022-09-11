using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Calculadora.Models;

namespace Calculadora
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual tipo de operação que voce quer executar?\nSomar = 1\nSubtrair = 2\nMultiplicar = 3\nDividir = 4\n");
            Console.Write("Informe o valor: ");
            int operacao = int.Parse(Console.ReadLine());

            if(operacao == 0)
            {
                Console.WriteLine("Programa finalizado, escolha um numero valido!");
                Console.ReadLine();
                return;
            }

            var valorOperacao = CalculadoraOperacoes.ObterOperacao(operacao);

            Console.Write("\nInforme o primeiro valor: ");
            double valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("\nInforme o segundo valor: ");
            double valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var calc = new CalculadoraOperacoes(valorOperacao, valor1, valor2);

            calc.Resultado = calc.Calcula(valor1, valor2, calc.TipoOperacao);

            Console.WriteLine(calc);
            Console.ReadLine();
        }
    }
}
