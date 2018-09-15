using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    class Matriz
    {

        private float[,] m = new float[3,3];

        public Matriz(float[,] m) {
            this.m = m;
        }

        public static Matriz operator +(Matriz A, Matriz B) {
            float[,] C = new float[3,3];
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    C[i, j] = A.m[i, j] + B.m[i,j];

                }
            }
            Matriz D = new Matriz(C);
            return D;
        }
        public static Matriz operator -(Matriz A, Matriz B)
        {
            float[,] C = new float[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    C[i, j] = A.m[i, j] - B.m[i, j];

                }
            }
            Matriz D = new Matriz(C);
            return D;
        }
        public override string ToString()
        {
            string s="";
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    s += m[i, j] + " ";
                }
                s += "\n";
            }

            return s;
        }

    }
}

    

