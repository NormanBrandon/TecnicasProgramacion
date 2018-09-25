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
    public partial class InformacionNaturistas : Form
    {
        public InformacionNaturistas()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnCalcularTotal_Click(object sender, EventArgs e)
        {
            Naturistas misNaturistas = new Naturistas();
            int total = misNaturistas.Total(int.Parse(txtbPiezas.Text));
            int dosis = misNaturistas.Dosis(byte.Parse(txtbDosis.Text));
            txtbTotalUno.Text = "$" + total + " , " + dosis + " Dosis";
            string suministroNaturistas = "Oral y cutáneo";
            txtbSuministro.Text = suministroNaturistas;

            txtbEfecSec.Text = misNaturistas.EfectosSecundarios();
            int totalMayorista = misNaturistas.Ventalibre(int.Parse(txtbMayoreo.Text));
            txtbTotalDos.Text = "$" + totalMayorista;
        }
    }
}
