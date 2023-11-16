using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace ExercicioFinanciamento
{
    public class FinanciamentoDeCasa : Financiamento
    {
       

        private int _prazo;
        private double _valormensal;
        private double _valortotal;
        private double _valorfinanciado;
        private double _rendimento;

        public FinanciamentoDeCasa( double valortotal,int prazo, double valormensal, double valorfinanciado, double rendimento)
            : base (valortotal,prazo,valormensal, valorfinanciado)
        {
            _valortotal = valortotal;
            _prazo = prazo;
           _valormensal = valormensal;
           _valorfinanciado = valorfinanciado;
            _rendimento = rendimento;   
        }

        public override double ValorMensal()
        {
            return _valorfinanciado / _prazo;

        }
    }
}
