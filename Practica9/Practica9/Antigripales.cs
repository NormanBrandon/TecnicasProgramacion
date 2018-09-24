using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica9
{
    class Antigripales:Medicamentos
    {
        public override int Dosis(byte dias)
        {
            int dosis = dias*5;
            return dosis;
        }

        public override string Suministro(string sumin)//oral, intravenoso, untado
        {
            string suministro = sumin;
            return suministro;
        }

        public override int Total(int piezas)//total de la compra
        {
            int precio = 48;
            int total = piezas * precio; 
            return total;
        }
    }
}
