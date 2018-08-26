using System;


namespace Practica3
{
    class Rectangulo
    {
        private float Base;
        private float Altura;
        private float area; 
        
        public virtual void Areas()
        {
            Console.WriteLine("Area de un rectángulo\nIngresa la longitud de la base: ");
            Base = float.Parse(Console.ReadLine());
            Console.WriteLine("\nIngresa la longitud de la altura: ");
            Altura = float.Parse(Console.ReadLine());
            area = Base * Altura;
            Console.WriteLine("\nEl area del rectangulo es: {0} [u^2]", area);
        }
    }
}
