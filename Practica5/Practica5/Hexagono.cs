using System;


namespace Practica5
{
    class Hexagono:Rectangulo
    {
        private float perimetro;
        private float apotema;
        private float area2;

        public override void Areas()
        {

            Console.WriteLine("\nArea de un hexagono\nIngresa el perímetro");
            perimetro = float.Parse(Console.ReadLine());
            Console.WriteLine("\nIngresa el apotema");
            apotema = float.Parse(Console.ReadLine());
            area2 = (perimetro * apotema) / 2;
            Console.WriteLine("\nEl area del hexágono es: {0} [u^2]", area2);

            if (perimetro < 0 || apotema < 0)
            {
                string error = "Tanto el área, como el perímetro y el apotema no pueden ser valores negativos, introduce números positivos.";
                throw new ApplicationException(error);
            }
        }
    }
}
