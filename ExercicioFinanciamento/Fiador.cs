using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFinanciamento
{
    public class Fiador 
    {
        public string NomeFiador { get; set; }
        public string Morada { get; set; }
        public int Telefone { get; set; }
        public int NIF { get; set; }
        public double RendimentoAnual { get; set; }

        private double _rendimento;

        
        public  string DadosFiador
        {
            get
            {
                return $"{NomeFiador}; {Morada}; {Telefone}; {NIF}, {RendimentoAnual}";
            }
           
        }

    }
}
