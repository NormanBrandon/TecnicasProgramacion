using System;

namespace Práctica_4
{
    class R3
    {
        private float x, y, z;

        public R3(float x, float y, float z){
            this.x = x;
            this.y = y;
            this.z = z;
        }


        public static R3 operator +(R3 A,R3 B)
        {
            R3 C = new R3(A.x +B.x,A.y + B.y,A.z +B.z);
            return C;
        }
        public static float operator *(R3 A, R3 B)
        {
            float interno = ((A.x * B.x) + (A.y * B.y)+ (A.z * B.z));
            return interno;
        }
        public static float operator !(R3 A)
        {
           float norma = (float)Math.Sqrt((A.x *A.x)+ (A.y*A.y)+ (A.z*A.z));
            return norma;
        }
        public override string ToString()
        {
            return String.Format("("+x+","+y+","+z+")");
        }

    }

}
