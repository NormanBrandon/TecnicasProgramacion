using System;

namespace Practica2
{
    class Animal
    {
        private string vertebrados;
        private string glandmamarias;
        private string placenta;
        private ushort patas;

        public void Vertebrados()
        {
            vertebrados = "Todos los mamiferos son vertebrados";

            Console.WriteLine("Caracteristica uno de los mamiferos: \n\n{0}", vertebrados);
        }
        public void glandMamarias()
        {
            glandmamarias = "Todos los mamiferos tienen glandulas mamarias para alimentar a sus crias";
            Console.WriteLine("Caracteristica dos: {0}", glandmamarias);
        }
        public void Placenta()
        {
            placenta = "Han desarrollado placenta, lo que les ha permitido sobrevivir en el medio terrestre";
            Console.WriteLine("Caracteristica tres: {0}", placenta);
        }
    }
}
