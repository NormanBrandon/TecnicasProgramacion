using System;


namespace Practica3
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
            Console.WriteLine("\nEl area del hexagono es: {0} [u^2]", area2);
        }
    }
}
