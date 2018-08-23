using System;


namespace Practica2
{
    class Program
    {
        static void Main(string[] args)
        {
            Jirafa jira = new Jirafa(130,(float)4.5);
            jira.caminar();
            jira.comer();
            jira.mostrarpapeles();
            Leon alex = new Leon(120, (float)1.5);
            alex.mostrarpapeles();
            alex.caminar();
            alex.comer();

            jira.Comida = "hojas";
            alex.Comida = "carne";
            Console.WriteLine("La jirafa come: " + jira.Comida);
            Console.WriteLine("El leon come: " + alex.Comida);

        }
    }
}
