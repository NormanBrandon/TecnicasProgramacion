using System;


namespace Práctica_4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Datos de diferentes alumnos\n");
     
            Promedio miPromedio = new Promedio();
            int promedio1 = miPromedio.Alumno1(6,6,7);
            Console.WriteLine("El promedio del alumno 1 es: " + promedio1);
            int promedio2 = miPromedio.Alumno1(8, 9, 8, 1);
            Console.WriteLine("El promedio del alumno 2 es: " + promedio2);
            int promedio3 = miPromedio.Alumno1(7, 4, 8, 7, 2);
            Console.WriteLine("El promedio del alumno 3 es: " + promedio3);

        }
    }
}
