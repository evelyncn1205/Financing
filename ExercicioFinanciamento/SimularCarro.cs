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
    public partial class SimularCarro : Form
    {
        FinanciamentoDeCarro _carro;

        double residual = 1;
        double abertura = 0.01;
        public SimularCarro()
        {
            InitializeComponent();
            txt_residual.Text = residual.ToString();
            txt_abertura.Text= abertura.ToString();
        }

        private void btn_fecharcarro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_calcularCarro_Click(object sender, EventArgs e)
        {
            FinanciamentoDeCarro carro;

            
            int prazo;
            double totalPagamento, valorFinanciado, mensalidade =0,valorresidual,comissaoabertura, calculoresidual,jurosMensal,valorjuros, jurosAnual;
            valorFinanciado = double.Parse(txt_valorFinanciado.Text);
            prazo = int.Parse(txt_prazocarro.Text);
            jurosAnual = double.Parse(txt_jurosAnualcarro.Text);

            jurosMensal = jurosAnual / 12;
            valorjuros = (valorFinanciado * jurosMensal) / 100;
            calculoresidual = (valorFinanciado * residual) / 100;
            comissaoabertura=valorFinanciado*abertura;
            mensalidade = Math.Round((valorFinanciado / prazo)+ valorjuros,2);
            valorresidual = Math.Round(calculoresidual + mensalidade);
            totalPagamento = Math.Round(mensalidade * prazo);

            txt_totalpagamento.Text = Convert.ToString(totalPagamento);
            txt_valorMensal.Text = Convert.ToString(mensalidade);
            txt_abertura.Text = Convert.ToString(comissaoabertura);
            txt_residual.Text = Convert.ToString(valorresidual);

        }
    }
}
