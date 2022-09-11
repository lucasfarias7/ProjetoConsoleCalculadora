using Calculadora.Services;
using System.Text;

namespace Calculadora.Models
{
    public class CalculadoraOperacoes
    {
        public Operacoes TipoOperacao { get; set; }
        public double Valor1 { get; set; }
        public double Valor2 { get; set; }
        public double Resultado { get; set; }

        public CalculadoraOperacoes(Operacoes tipoOperacao, double valor1, double valor2)
        {
            TipoOperacao = tipoOperacao;
            Valor1 = valor1;
            Valor2 = valor2;
        }

        public double Calcula(double valor1, double valor2, Operacoes tipo)
        {
            Resultado = CalculaService.Calcula(valor1, valor2, tipo);
            return Resultado;
        }

        public static Operacoes ObterOperacao(int operacao)
        {
            switch (operacao)
            {
                case 1: return Operacoes.Soma;
                case 2: return Operacoes.Subtracao;
                case 3: return Operacoes.Multiplicacao;
                case 4: return Operacoes.Divisao;
                default: return 0;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"\nValores escolhidos para a operação - {Valor1} e {Valor2}");
            sb.AppendLine($"Operação escolhida - {TipoOperacao}");
            sb.AppendLine($"Resultado - {Resultado}");

            return sb.ToString(); 
        }
    }
}
