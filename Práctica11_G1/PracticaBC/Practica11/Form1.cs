using System;
using System.Drawing;
using System.Windows.Forms;
using BibliotecaPractica;

namespace Practica11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                string nuevonombre = BibliotecaPractica.Clase1.Nombre();
                txtbNombre.Text = nuevonombre;

                string cuenta = Clase1.NumeroCuenta();
                txtbNumCuenta.Text = cuenta;

                float promediofinal = Clase1.PromedioAlumno(int.Parse(txtbCal1.Text), int.Parse(txtbCal2.Text), int.Parse(txtbCal3.Text), 1);
                txtbPromedio.Text = promediofinal.ToString();

                int sumafinal = Clase2.Suma(int.Parse(txtbCal1.Text), int.Parse(txtbCal2.Text), int.Parse(txtbCal3.Text));
                txtbSuma.Text = sumafinal.ToString();

                string situacion = Clase2.AlumnoRegular();
                txtbSitAcademica.Text = situacion;
            }

            catch
            {
                MessageBox.Show("Ingresa todas las calificaciones");
            }

            

        }
    }
}
