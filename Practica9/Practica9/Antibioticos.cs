using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica9
{
    class Antibioticos:Medicamentos
    {
        public override int Dosis(byte dias)
        {
            int dosis = dias*7;
            return dosis;
        }

        public override string Suministro(string sumin)
        {
            string suministro = sumin;
            return suministro;
        }

        public override int Total(int piezas)
        {
            int precio = 65;
            int total = piezas * precio;
            return total;
        }
    }
}
