using System;


namespace Practica6
{
    class Program
    {
        static void Main()
        {
            Unidimensional miUnidimensional = new Unidimensional();

            try
            {
            miUnidimensional.arreglo1();
            }
            catch (FormatException)
            {
                Console.WriteLine("Tipo de dato inválido");
            }

            catch (ApplicationException error)
            {
                Console.WriteLine(error.Message);
            }

            try
            {
                miUnidimensional.arreglo2();
            }
            catch (FormatException)
            {
                Console.WriteLine("Tipo de dato inválido");
            }
           
            miUnidimensional.arreglo3();
            miUnidimensional.suma1();
            miUnidimensional.promedio();
        }
    }
}
