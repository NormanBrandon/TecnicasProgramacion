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
    public partial class InformacionAntigripales : Form
    {
        public InformacionAntigripales()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnCalcularTotal_Click(object sender, EventArgs e)
        {
            Antigripales misAntigripales = new Antigripales();
            int total = misAntigripales.Total(int.Parse(txtbPiezas.Text));
            int dosis = misAntigripales.Dosis(byte.Parse(txtbDosis.Text));
            txtbTotalDosis.Text = "$" + total + " , " + dosis + " Dosis";
            string suministroAntigripales = "Oral";
            txtbSuministro.Text = suministroAntigripales;
        }
    }
}
