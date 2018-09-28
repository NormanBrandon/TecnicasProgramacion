using System;

namespace Practica10
{
    class Program
    {
        private string cadena;
        private int edad;

        public void PideCadena()
        {
            Console.WriteLine("Ingresa tu nombre");
            cadena = Console.ReadLine();
        }

        public string MandaCadena()
        {
            return cadena;
        }

        public void PideEdad()
        {
            Console.WriteLine("Ingresa tu edad");
            edad =int.Parse( Console.ReadLine() );
        }

        public int Edad()
        {
            return edad;
        }


        static void Main()
        {
            Program miProgram = new Program();
            Editor miEditor = new Editor();

            miProgram.PideCadena();
            miEditor.DisparaEvento1 += miProgram.MandaCadena;
            string cadenaFinal = miEditor.DisparaMetodo();
            Console.WriteLine("Tu nombre es: " + cadenaFinal);

            miProgram.PideEdad();
            miEditor.DisparaEvento2 += miProgram.Edad;
            int edadFinal = miEditor.DisparaEdad();
            Console.WriteLine("Tu edad es: " + edadFinal);

        }
    }
}
