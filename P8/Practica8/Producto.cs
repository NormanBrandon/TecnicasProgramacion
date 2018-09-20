using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica8
{
    class Producto
    {
        private string nombre;
        private float precio;
        private int cantidad;

        public Producto(float precio,string nombre,int cantidad) {
            this.Precio = precio;
            this.Nombre = nombre;
            this.Cantidad = cantidad;
        }

        public int Cantidad { get => cantidad; set => cantidad = value; }
        public float Precio { get => precio; set => precio = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public static float operator +(Producto p1 , Producto p2) {
            float suma;
            suma = (p1.Cantidad)*(p1.Precio)+ (p2.Cantidad)*(p2.Precio);

            return suma;
        }
    }
}
