
namespace BibliotecaPractica
{
    public class Clase1
    {
        public static string Nombre()
        {
            string sunombre = "Julio Pickles";
            return sunombre;
        }

        public static string NumeroCuenta()
        {
            string numcuenta = "314875687";
            return numcuenta;
        }

        public static int PromedioAlumno(int cal1, int cal2, int cal3, int puntoExtra)
        {
            return (cal1 + cal2 + cal3) / 3 + puntoExtra;
        }
    }
}
