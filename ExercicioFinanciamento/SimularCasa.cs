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
    public partial class SimularCasa : Form
    {
        Fiador _fiador;
        FinanciamentoDeCasa Casa;
        List<Fiador> InformacaoFiador;
        double spread = 1.5;
        public SimularCasa()
        {
            InitializeComponent();
            InformacaoFiador = new List<Fiador>();

        }

        private void btn_calculacasa_Click(object sender, EventArgs e)
        {
            double valorMes =0, totalpagar, taxaanual, valorfinanciado, taxaMensal, juros;
            double mensalSemjuros, valorspread;
            int prazo;
                        
            valorfinanciado = Convert.ToInt32(txt_valorfinanciado.Text);
            prazo = int.Parse(txt_prazo.Text);
            taxaanual=double.Parse(txt_taxaAnual.Text);

            taxaMensal = taxaanual / 12;
            
            juros = (valorfinanciado *taxaMensal) / 100;
            valorspread= (valorfinanciado * spread) / 100;
            mensalSemjuros= valorfinanciado / prazo;
            valorMes = Math.Round(mensalSemjuros + juros + valorspread);
            totalpagar = Math.Round(valorMes * prazo);
            txt_valorMensal.Text = Convert.ToString(valorMes);
            txt_totalapagar.Text = Convert.ToString(totalpagar);
        }

        private void btn_registarFiador_Click(object sender, EventArgs e)
        {
            Fiador fiador;
            if(ValidaInformação())
            {
                fiador = new Fiador
                {
                    NomeFiador = txt_nomefiador.Text,
                    Morada = txt_morada.Text,
                    NIF = Convert.ToInt32(txt_nif.Text),
                    Telefone = Convert.ToInt32(txt_telefone.Text),
                    RendimentoAnual = Convert.ToDouble(txt_rendimento.Text)

                };
                InformacaoFiador.Add(fiador);
                Initlista();                      
             }
            else
            {
                MessageBox.Show("É necessário preencher todos os dados corretamente!", "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }

        }

        public bool ValidaInformação ()
        {
            bool output= true;
            if(string.IsNullOrEmpty(txt_nomefiador.Text))
            {
                MessageBox.Show("Insira corretamente o Nome!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            if (string.IsNullOrEmpty(txt_rendimento.Text))
            {
                MessageBox.Show("Insira corretamente o valor do rendimento!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            if (string.IsNullOrEmpty(txt_nif.Text))
            {
                MessageBox.Show("Insira corretamente o Nif!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            if (string.IsNullOrEmpty(txt_morada.Text))
            {
                MessageBox.Show("Insira corretamente a Morada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            if (string.IsNullOrEmpty(txt_telefone.Text))
            {
                MessageBox.Show("Insira corretamente o Telefone!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            return output;
        }

        public void Initlista()
        {
            list_fiador.DataSource= null;
            list_fiador.DataSource = InformacaoFiador;
            list_fiador.DisplayMember = "DadosFiador";
        }

        private void btn_fecar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SimularCasa_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
