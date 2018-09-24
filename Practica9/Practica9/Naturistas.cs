using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica9
{
    class Naturistas : Medicamentos, IMetodosIncompatibles
    {
        public override int Dosis(byte dias)
        {
            int dosis = dias * 15;
            return dosis;
        }
        

        public override string Suministro(string sumin)
        {
            string suministro = sumin;
            return suministro;
        }

        public override int Total(int piezas)
        {
            int precio = 82;
            int total = piezas * precio;
            return total ;
        }

        public string EfectosSecundarios()
        {
            string efesec = "Sin efectos secundarios por ser producto naturista";
            return efesec;
        }

        public int Ventalibre(int numero)
        {
            int precio = 71;
            int total = numero * precio;
            return total;
        }
    }
}
