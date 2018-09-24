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
        string lista =" Nombre del Producto    Precio     Cantidad \n";
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
                if(p1.Cantidad != 0)
                lista += p1.Nombre + "    " + p1.Precio + "     " + p1.Cantidad + "\n";
                if (p2.Cantidad != 0)
                    lista += p2.Nombre + "    " + p2.Precio + "     " + p2.Cantidad + "\n";
               
            }
            lblista.Text = lista;
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
