using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFinanciamento
{
    public class OutrosFinanciamentos : Financiamento
    {

        
        private double _comissaoabertura;
        private double _amotizacao;
        private double _valortotal;
        private double _prazo;

        public OutrosFinanciamentos(double valortotal, int prazo, double valormensal, double valorfinanciado, double comissaoAbertura, double amortizacao)
            : base(valortotal, prazo, valormensal, valorfinanciado)
        {
            _comissaoabertura = 1;
            _amotizacao = 0.05;
            _valortotal= valortotal;
            _prazo = prazo;
        }

        

        public override double ValorMensal()
        {
            return _valortotal / Prazo;
        }
    }
}
