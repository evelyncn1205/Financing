using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFinanciamento
{
    public class FinanciamentoDeCarro : Financiamento
    {
        
        int prazo;
        public int Prazo 
        {
            get 
            {
                return prazo; 
            }
            set
            {
                if (value > 60) prazo = 60;
                else prazo = value;
            }
        }

        private double _comissãoAbertura;
        private double _residual;
        private double _valorTotal;
        private int _prazo;

        public FinanciamentoDeCarro(double valorTotal, int prazo, double valormensal, double valorfinanciado, double comissão,double residual) 
            : base(valorTotal, prazo, valormensal, valorfinanciado )
        {
            _comissãoAbertura = 0.01;
            _residual = 1;
            _valorTotal = valorTotal;
            _prazo = prazo;
        }


        public override double ValorMensal()
        {
            return  _valorTotal / Prazo;
        }
    }
}
