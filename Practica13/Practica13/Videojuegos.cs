using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica13
{
    class Videojuegos
    {

        #region Atributos
        private string nombre;
        private string genero;
        private string desarrollador;
        private int año;
        #endregion

        #region Propiedades
        public string Nombre { get => nombre; set => nombre = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Desarrollador { get => desarrollador; set => desarrollador = value; }
        public int Año { get => año; set => año = value; }
        #endregion

        #region Constructor
        public Videojuegos(string nombre, string genero, string desarrollador, int año)
        {
            Nombre = nombre;
            Genero = genero;
            Desarrollador = desarrollador;
            Año = año;
        }
        #endregion
    }
}
