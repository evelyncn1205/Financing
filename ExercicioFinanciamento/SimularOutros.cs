using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioFinanciamento
{
    public partial class SimularOutros : Form
    {
        double comissaoAbertura = 1;
        double amortização = 0.05;
        public SimularOutros()
        {
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_calcularoutros_Click(object sender, EventArgs e)
        {
            double valorTotal, valorMensal,valorFinanciado, valorcomissao,valoramortizacao, jurosmensal, jurosAnual=0,calculoJuros;
            int prazo;
            valorFinanciado = Convert.ToDouble(txt_valoroutros.Text);
            prazo = Convert.ToInt32(txt_prazooutros.Text);
            jurosAnual = Convert.ToDouble(txt_jurosOutros.Text);

            jurosmensal = jurosAnual / 12;
            calculoJuros = (valorFinanciado * jurosmensal) / 100;
            valorcomissao = (valorFinanciado * comissaoAbertura) / 100;
            valoramortizacao = (valorFinanciado * amortização);
            valorMensal = Math.Round((valorFinanciado - valorcomissao - valoramortizacao + calculoJuros) / prazo,2);
            valorTotal = Math.Round(valorMensal * prazo);

            txt_mensaloutros.Text= Convert.ToString(valorMensal);
            txt_totalPagarOutros.Text= Convert.ToString(valorTotal);
            txt_aberturaoutros.Text = Convert.ToString(valorcomissao);
            txt_amortizacao.Text = Convert.ToString(valoramortizacao);
        }
    }
}
