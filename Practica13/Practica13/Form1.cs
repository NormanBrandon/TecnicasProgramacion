using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica13
{
    public partial class Form1 : Form
    {
        Stack<Videojuegos> pilavideojuegos;
        public Form1()
        {
            InitializeComponent();
            pilavideojuegos = new Stack<Videojuegos>();
            Videojuegos cajon = new Videojuegos("Call of Duty", "Disparos", "Sledge Gamer", 2014);
            dgvVideojuegos.Rows.Add(cajon.Nombre, cajon.Genero, cajon.Desarrollador, cajon.Año);
            pilavideojuegos.Push(cajon);
            Videojuegos cajon2 = new Videojuegos("Fifa 17", "Deportes", "EA Sports", 2016);
            dgvVideojuegos.Rows.Add(cajon2.Nombre, cajon2.Genero, cajon2.Desarrollador, cajon2.Año);
            pilavideojuegos.Push(cajon2);
            Videojuegos cajon3 = new Videojuegos("Need for Speed", "Carreras", "EA Sports", 2016);
            dgvVideojuegos.Rows.Add(cajon3.Nombre, cajon3.Genero, cajon3.Desarrollador, cajon3.Año);
            pilavideojuegos.Push(cajon3);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbNombre.Text == "" || txtbGenero.Text == "" || txtbDesarrollador.Text == "")
                {
                    throw new ApplicationException("Campos sin información");
                }
                Videojuegos aux = new Videojuegos(txtbNombre.Text, txtbGenero.Text, txtbDesarrollador.Text, int.Parse(txtbAño.Text));
                dgvVideojuegos.Rows.Add(aux.Nombre, aux.Genero, aux.Desarrollador, aux.Año);
                pilavideojuegos.Push(aux);
                errorProv.Clear();
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message);
            }
            catch(ApplicationException error)
            {
                errorProv.SetError(dgvVideojuegos, error.Message);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (pilavideojuegos.Count == 0)
                {
                    throw new ApplicationException("Base de datos vacía");
                }
                else
                {
                    dgvVideojuegos.Rows.RemoveAt(pilavideojuegos.Count - 1);
                    pilavideojuegos.Pop();
                    errorProv.Clear();
                }
            }
            catch(ApplicationException error)
            {
                errorProv.SetError(dgvVideojuegos, error.Message);
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tu registro fue enviado exitosamente.\n\nGracias por participar.");
        }
    }
}
