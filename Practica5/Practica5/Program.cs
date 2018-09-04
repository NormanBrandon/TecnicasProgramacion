using System;


namespace Practica5
{
    class Program
    {
        static void Main()
        {
            try
            {
                Rectangulo miRectangulo = new Rectangulo();
                miRectangulo.Areas();

            }

            catch (ApplicationException error)
            {
                Console.WriteLine(error.Message);
            }

            catch (FormatException)
            {
                Console.WriteLine("Tipo de dato inválido.");
            }

            catch
            {
                Console.WriteLine("Hubo un error.");
            }


            try
            {
                Hexagono miHexagono = new Hexagono();
                miHexagono.Areas();
            }

            catch (ApplicationException error)
            {
                Console.WriteLine(error.Message);
            }

            catch (FormatException)
            {
                Console.WriteLine("Tipo de dato inválido.");
            }

            catch
            {
                Console.WriteLine("Hubo un error.");
            }

            finally
            {
                Console.WriteLine("Programa ejecutado y terminado.");
            }

            Console.ReadKey();
            Console.ReadKey();
            }
         
        }
    }

