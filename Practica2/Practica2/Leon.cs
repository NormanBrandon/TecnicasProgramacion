using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    class Leon:Animal
    {
        private string comida;
        public string Comida
        {
            get
            {
                return comida;
            }
            set
            {
                comida = value;
            }
        }
        public Leon(float p, float a)
        {
            Color = "naranja";
            Peso = p;
            Altura = a;
            Patas = 4;
            Console.WriteLine("Leon Naciendo XD");
        }

    }
}
