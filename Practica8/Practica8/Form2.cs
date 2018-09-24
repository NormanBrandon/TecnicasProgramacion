using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace Practica8
{
    public partial class Form2 : Form
    {
        float total = 0;
        Producto p1;
        Producto p2;
        public Form2(ArrayList ticket)
        {
            InitializeComponent();
            for (int i = 0; i < 6;  i=i+2)
            {
                p1 = (Producto)ticket[i];
                p2 = (Producto)ticket[i + 1];
                total += p1 + p2;

            }
            lbtotal.Text = "$" + total;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblista_Click(object sender, EventArgs e)
        {
            
        }
    }
}
