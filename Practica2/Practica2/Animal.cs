using System;

namespace Practica2
{
    abstract class Animal
    {
        private string color;
        private float altura;
        private float peso;
        private ushort patas;

        public ushort Patas { get => patas; set => patas = value; }
        public float Peso { get => peso; set => peso = value; }
        public float Altura { get => altura; set => altura = value; }
        public string Color { get => color; set => color = value; }

        public void comer() {
            Console.WriteLine("Comiendo ....");
        }
        public void caminar() {

            Console.WriteLine("Caminando...");
        }
    }
}
