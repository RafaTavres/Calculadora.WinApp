using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static Calculadora.WinApp.ModuloCalculadora.ClasseCalculadora;

namespace Calculadora.WinApp.ModuloCalculadora
{
    internal class CalculadoraRepository
    {
        public bool OperaoConcluida = false;
        public ClasseCalculadora calculadora = new ClasseCalculadora();
        public TelaHistorico telaHistorico = new TelaHistorico();
        public bool estagNoSegundoNumero = false;

        public CalculadoraRepository()
        {
            calculadora.historico = new List<string>();
        }

        public decimal Calcula(Operacao operacao)
        {
            if (operacao == Soma)
            {
                OperaoConcluida = true;
                return Soma(ConverteParaNumeros(calculadora.numero1), ConverteParaNumeros(calculadora.numero2));
            }
            if (operacao == Divisao)
            {
                OperaoConcluida = true;
                return Divisao(ConverteParaNumeros(calculadora.numero1), ConverteParaNumeros(calculadora.numero2));
            }
            if (operacao == Multiplicao)
            {
                OperaoConcluida = true;
                return Multiplicao(ConverteParaNumeros(calculadora.numero1), ConverteParaNumeros(calculadora.numero2));
            }
            if (operacao == Subtracao)
            {
                OperaoConcluida = true;
                return Subtracao(ConverteParaNumeros(calculadora.numero1), ConverteParaNumeros(calculadora.numero2));
            }
            return 0;
        }
        public void MostrarHistorico()
        {           
            telaHistorico.ShowDialog();
        }
        public void AlteraPosicaoDoNumeroPara1()
        {
            estagNoSegundoNumero = false;
        }
        public decimal Soma(decimal numero1, decimal numero2)
        {
            return numero1 + numero2;
        }
        public decimal Divisao(decimal numero1, decimal numero2)
        {
            return numero1 / numero2;
        }
        public decimal Multiplicao(decimal numero1, decimal numero2)
        {
            return numero1 * numero2;
        }
        public decimal Subtracao(decimal numero1, decimal numero2)
        {
            return numero1 - numero2;
        }
        public decimal ConverteParaNumeros(string numero)
        {
           return Convert.ToDecimal(numero);
        }
    }
}
