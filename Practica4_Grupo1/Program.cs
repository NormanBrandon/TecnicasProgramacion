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
            Console.WriteLine("Presione Enter para continuar");
            Console.ReadLine();
            R3 v1 = new R3(1, 2, 3);
            R3 v2 = new R3(4, 5, 6);
            R3 v3 = v1 + v2;
            Console.WriteLine("La suma de "+v1+" y "+ v2+" es :"+ v3);
         
            Console.WriteLine("La norma de " + v3 +" es :"+ !v3);
            
            Console.WriteLine("El producto interno de  " + v1 + " y " + v2 + " es :"+ v1*v2);



            Console.WriteLine("Presione Enter para continuar");
            Console.ReadLine();
        }
    }
}
