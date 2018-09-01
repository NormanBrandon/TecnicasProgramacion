using System;


namespace Práctica_4
{
    class Promedio
    {
        public int Alumno1(int cal1, int cal2, int cal3)
        {
            return (cal1 + cal2 + cal3)/3; 
        }

        public int Alumno1(int cal1, int cal2, int cal3, int puntoExtra)
        {
            return (cal1 + cal2 + cal3) / 3 + puntoExtra;
        }
    }
}
