using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            //finaliza la aplicación
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formularioatb = new InformacionAntibioticos();
            formularioatb.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formularioatg = new InformacionAntigripales();
            formularioatg.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formularionat = new InformacionNaturistas();
            formularionat.Show();
        }
    }
}
