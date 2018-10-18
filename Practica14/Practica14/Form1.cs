using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica14
{
    public partial class Form1 : Form
    {
        //Panaderia miPanaderia;
        Queue<Panaderia> colaPanaderia;

        public Form1()
        {
            InitializeComponent();

            colaPanaderia = new Queue<Panaderia>();
            Panaderia pan1 = new Panaderia("Conchas");
            colaPanaderia.Enqueue(pan1);
            listbPanes.Items.Add(pan1.Nombre);

            Panaderia pan2 = new Panaderia("Roles de canela");
            colaPanaderia.Enqueue(pan2);
            listbPanes.Items.Add(pan2.Nombre);

            Panaderia pan3 = new Panaderia("Cuernitos");
            colaPanaderia.Enqueue(pan3);
            listbPanes.Items.Add(pan3.Nombre);

            Panaderia pan4 = new Panaderia("Mantecadas");
            colaPanaderia.Enqueue(pan4);
            listbPanes.Items.Add(pan4.Nombre);

            /*colaPanaderia = new Queue<Panaderia>();
            miPanaderia = new Panaderia("Roles de canela");
            listbPanes.Items.Add(miPanaderia.Nombre);*/
        }

       

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbNombre.Text == "")
                {
                    throw new ApplicationException("Campo vacío");
                }
                Panaderia nuevopan = new Panaderia(txtbNombre.Text);
                colaPanaderia.Enqueue(nuevopan);
                listbPanes.Items.Add(nuevopan.Nombre);
                errorProv.Clear();
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message);
            }
            catch(ApplicationException error)
            {
                errorProv.SetError(txtbNombre, error.Message);
            }
           
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tu opinión es muy importante para nosotros.\n\nAhora sabremos que productos debemos mejorar. =)");
        }
    }
}
