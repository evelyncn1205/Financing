namespace ExercicioFinanciamento
{
    public partial class Form1 : Form
    {
        FinanciamentoDeCasa _financiamentoCasa;
        FinanciamentoDeCarro _financiamentoCarro;
        OutrosFinanciamentos _outrosFinanciamentos;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_casa_Click(object sender, EventArgs e)
        {
            SimularCasa simularCasa = new SimularCasa();
            simularCasa.Show();

        }

        private void btn_carro_Click(object sender, EventArgs e)
        {
            SimularCarro simularCarro = new SimularCarro();
            simularCarro.Show();
        }

        private void btn_outros_Click(object sender, EventArgs e)
        {
            SimularOutros simularOutros = new SimularOutros(); 
            simularOutros.Show();
        }

        private void bto_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}