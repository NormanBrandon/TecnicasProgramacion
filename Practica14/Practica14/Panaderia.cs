using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica14
{
    class Panaderia
    {
        private string nombre;
       


        public string Nombre { get => nombre; set => nombre = value; }
       
        public Panaderia(string nombre)
        {
            Nombre = nombre;
            
        }
    }
}
