
using Calculadora.WinApp.ModuloCalculadora;
using System.Timers;
using static Calculadora.WinApp.ModuloCalculadora.ClasseCalculadora;
using static System.Net.Mime.MediaTypeNames;

namespace Calculadora.WinApp
{
    public partial class TelaCalculadora : Form
    {
        private CalculadoraRepository calculadoraRepository = new CalculadoraRepository();
        private event Operacao operacao = null;
        public TelaCalculadora()
        {
            InitializeComponent();
        }

        private void btnNumero0_Click(object sender, EventArgs e)
        {
            if (calculadoraRepository.OperaoConcluida == true)
                ResetaInformacoesDoLabel();
            adicionaNumeroNosBotoes("0");
            ColocaInformacoesNoLabel("0");
        }
        private void btnNumero1_Click(object sender, EventArgs e)
        {
            if (calculadoraRepository.OperaoConcluida == true)
                ResetaInformacoesDoLabel();
            adicionaNumeroNosBotoes("1");
            ColocaInformacoesNoLabel("1");
        }
        private void btnNumero2_Click(object sender, EventArgs e)
        {
            if (calculadoraRepository.OperaoConcluida == true)
                ResetaInformacoesDoLabel();
            adicionaNumeroNosBotoes("2");
            ColocaInformacoesNoLabel("2");
        }
        private void btnNumero3_Click(object sender, EventArgs e)
        {
            if (calculadoraRepository.OperaoConcluida == true)
                ResetaInformacoesDoLabel();
            adicionaNumeroNosBotoes("3");
            ColocaInformacoesNoLabel("3");
        }
        private void brnNumero4_Click(object sender, EventArgs e)
        {
            if (calculadoraRepository.OperaoConcluida == true)
                ResetaInformacoesDoLabel();
            adicionaNumeroNosBotoes("4");
            ColocaInformacoesNoLabel("4");
        }

        private void btnNumero5_Click(object sender, EventArgs e)
        {
            if (calculadoraRepository.OperaoConcluida == true)
                ResetaInformacoesDoLabel();
            adicionaNumeroNosBotoes("5");
            ColocaInformacoesNoLabel("5");
        }

        private void btnNumero6_Click(object sender, EventArgs e)
        {
            if (calculadoraRepository.OperaoConcluida == true)
                ResetaInformacoesDoLabel();
            adicionaNumeroNosBotoes("6");
            ColocaInformacoesNoLabel("6");
        }

        private void btnNumero7_Click(object sender, EventArgs e)
        {
            if (calculadoraRepository.OperaoConcluida == true)
                ResetaInformacoesDoLabel();
            adicionaNumeroNosBotoes("7");
            ColocaInformacoesNoLabel("7");
        }

        private void btnNumero8_Click(object sender, EventArgs e)
        {
            if (calculadoraRepository.OperaoConcluida == true)
                ResetaInformacoesDoLabel();
            adicionaNumeroNosBotoes("8");
            ColocaInformacoesNoLabel("8");
        }

        private void btnNumero9_Click(object sender, EventArgs e)
        {
            if (calculadoraRepository.OperaoConcluida == true)
                ResetaInformacoesDoLabel();
            adicionaNumeroNosBotoes("9");
            ColocaInformacoesNoLabel("9");
        }
        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (calculadoraRepository.OperaoConcluida == true)
                ResetaInformacoesDoLabel();
            adicionaNumeroNosBotoes(",");
            ColocaInformacoesNoLabel(",");
        }
        private void btnSomar_Click(object sender, EventArgs e)
        {
            calculadoraRepository.estagNoSegundoNumero = true;
            operacao = calculadoraRepository.Soma;
            ColocaInformacoesNoLabel("+");
        }
        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            calculadoraRepository.estagNoSegundoNumero = true;
            operacao = calculadoraRepository.Subtracao;
            ColocaInformacoesNoLabel("-");
        }
        private void btnDividir_Click(object sender, EventArgs e)
        {
            calculadoraRepository.estagNoSegundoNumero = true;
            operacao = calculadoraRepository.Divisao;
            ColocaInformacoesNoLabel("÷");
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            calculadoraRepository.estagNoSegundoNumero = true;
            operacao = calculadoraRepository.Multiplicao;
            ColocaInformacoesNoLabel("x");
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            ColocaInformacoesNoLabel("=");
            RecebeResultadoDoCalculo();
            ColocaInformacoesNoLabel(calculadoraRepository.calculadora.resultado.ToString());
            AdicionaNoHistorico();
            calculadoraRepository.AlteraPosicaoDoNumeroPara1();
            ResetaNumeros();


        }

        private void AdicionaNoHistorico()
        {
            calculadoraRepository.calculadora.historico.Add(lblResultado.Text);
            calculadoraRepository.telaHistorico.hisotricoListBox.Items.Add(lblResultado.Text);
        }

        private void ColocaInformacoesNoLabel(string text)
        {
            lblResultado.Text += text;
        }
        private void ResetaInformacoesDoLabel()
        {
            lblResultado.Text = "";
            calculadoraRepository.OperaoConcluida = false;
        }

        public void adicionaNumeroNosBotoes(string numero)
        {
            if (calculadoraRepository.estagNoSegundoNumero == true)
                calculadoraRepository.calculadora.numero2 += numero;
            else
                calculadoraRepository.calculadora.numero1 += numero;
        }
        public void ResetaNumeros()
        {
            calculadoraRepository.calculadora.resultado = 0;
            calculadoraRepository.calculadora.numero1 = "0";
            calculadoraRepository.calculadora.numero2 = "0";
        }
        public void RecebeResultadoDoCalculo()
        {
            calculadoraRepository.calculadora.resultado = calculadoraRepository.Calcula(operacao);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetaInformacoesDoLabel();
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            calculadoraRepository.MostrarHistorico();
        }
    }
}