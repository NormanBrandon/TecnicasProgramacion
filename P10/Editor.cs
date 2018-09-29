using System;

namespace Practica10
{
    class Editor
    {
        public delegate string MiManejadorEvento();
        public event MiManejadorEvento DisparaEvento1;

        public delegate int MiManejadorEvento2();
        public event MiManejadorEvento2 DisparaEvento2;

        public string DisparaMetodo()
        {
        return DisparaEvento1();
        }

        public int DisparaEdad()
        {
         return DisparaEvento2();
        }
        

    }
}
