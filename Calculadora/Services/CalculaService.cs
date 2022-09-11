using Calculadora.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculaService
    {
        private static double Resultado { get; set; }

        public static double Calcula(double valor1, double valor2, Operacoes tipo)
        {
            switch ((int)tipo)
            {
                case 1: Resultado = Somar(valor1, valor2);
                    break;
                case 2: Resultado = Subtrair(valor1, valor2);
                    break;
                case 3: Resultado = Multiplicar(valor1, valor2);
                    break;
                case 4: Resultado = Dividir(valor1, valor2);
                    break;
                default: return Resultado;
            }

            return Resultado;
        }

        private static double Dividir(double valor1, double valor2)
        {
            try
            {
                return valor1 / valor2;
            }
            catch (DivideByZeroException)
            {
                return -1;
            }
        }

        private static double Multiplicar(double valor1, double valor2)
        {
            return valor1 * valor2;
        }

        private static double Subtrair(double valor1, double valor2)
        {
            return valor1 - valor2;
        }

        private static double Somar(double valor1, double valor2)
        {
            return valor1 + valor2;
        }
    }
}
