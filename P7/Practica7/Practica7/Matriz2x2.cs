using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    class Matriz2x2
    {
        public float[,] m = new float[2, 2];
        public Matriz2x2(float[,] m)
        {
            this.m = m;
        }
        public static Matriz2x2 operator +(Matriz2x2 A, Matriz2x2 B)
        {
            float[,] C = new float[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    C[i, j] = A.m[i, j] + B.m[i, j];

                }
            }
            Matriz2x2 D = new Matriz2x2(C);
            return D;
        }
        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    s += m[i, j] + " ";
                }
                s += "\n";
            }

            return s;
        }

    }
}
