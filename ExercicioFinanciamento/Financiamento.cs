using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFinanciamento
{
    public abstract class Financiamento
    {
        public double ValorTotal { get; set; }

        public int Prazo { get; set; }

        public double ValorMes { get; set; }

        public double ValorFinanciado { get; set; }




        public Financiamento(double valorTotal, int prazo, double valormensal, double valorfinanciado)
        {
            ValorTotal = valorTotal;
            Prazo = prazo;
            ValorMes = valormensal;
            ValorFinanciado = valorfinanciado;
        }



        public abstract double ValorMensal();


    }
}
