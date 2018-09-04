using System;


namespace Practica5
{
    class Rectangulo
    {
        private float Base;
        private float Altura;
        private float area;


        public virtual void Areas()
        {

            
                Console.WriteLine("Área de un rectángulo\nIngresa la longitud de la base: ");
                Base = float.Parse(Console.ReadLine());

                Console.WriteLine("\nIngresa la longitud de la altura: ");
                Altura = float.Parse(Console.ReadLine());

                area = Base * Altura;
                Console.WriteLine("\nEl area del rectángulo es: {0} [u^2]", area);
         
                if (area < 0 || Base < 0 || Altura < 0)
                {
                    string error = "Tanto el área, como la base y la altura no pueden ser valores negativos, introduce números positivos.";
                    throw new ApplicationException(error);
                }
             
            
        }
    }
}
