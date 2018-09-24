using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica9
{
    class Medicamentos
    {
        

        #region Métodos

        public virtual int Dosis(byte dias)
        {
            int dosis = dias*3;
            return dosis;
        }

        public virtual string Suministro(string sumin) //oral, intravenoso, untado
        {
            string suministro = sumin;
            return suministro ;
        }

        public virtual int Total(int piezas)
        {
            int precio = 0;
            int total = piezas * precio;
            return total;
        }


        #endregion
    }
}
