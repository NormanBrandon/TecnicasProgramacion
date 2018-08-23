using System;

namespace Practica2
{
    class Jirafa : Animal
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
        public Jirafa(float p,float a){
            Color = "naranja y cafe";
            Peso = p;
            Altura = a;
            Patas = 4;
            Console.WriteLine("Jirafa Naciendo XD");
        }


    }
}
