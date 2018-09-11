using System;


namespace Practica6
{
    class Unidimensional
    {
        private int[] vector = new int[3];
        private int[] vector2 = new int[3];
        private int[] vector3 = new int[3] { 4, 8, 9 };

        public void arreglo1 ()
        {
            //1,2,3
            Console.WriteLine("Ingresa 3 números positivos cualesquiera dando un enter por cada número");
            
            for (int i=0; i<3; i++)
            {
                vector [i] = int.Parse(Console.ReadLine());
                if (vector[0] < 0|| vector[1]<0|| vector [2]<0)
                {
                    string error = "Ingrese datos positivos";
                    throw new ApplicationException(error);
                }
            }

            
                Console.WriteLine("Los valores que ingresaste fueron: {0}, {1}, {2}", vector[0],vector[1],vector[2]);
            
        }

        public void arreglo2()
        {
            Console.WriteLine("Ingresa otros 3 números cualesquiera dando un enter por cada número");

            for (int j = 0; j < 3; j++)
            {
                vector2[j] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Los segundos valores que ingresaste fueron: {0}, {1}, {2}", vector2[0], vector2[1], vector2[2]);
        }

        public void arreglo3()
        {
            Console.WriteLine("Los valores por default del sistema son: {0}, {1}, {2}", vector3[0], vector3[1], vector3[2]);
        }

        public void suma1()
        {
            int suma = vector[0] + vector2[0] + vector3[0];
            Console.WriteLine("La suma de los primeros elementos de cada arreglo es: {0}", suma);
        }

        public void promedio()
        {
            float promedio1 =(float)(vector[2] + vector2[2] + vector3[2])/3;
            Console.WriteLine("El promedio de los terceros elementos de cada arreglo es: {0}", promedio1);
        }
             
        
                
        
    }
}
