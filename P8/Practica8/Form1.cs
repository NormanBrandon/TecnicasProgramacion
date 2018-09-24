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
    public partial class Form1 : Form
    {
        float total;
        ArrayList ticket = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
              
                ticket.Add(new Producto((float)11.5,"Coca Cola", (int)cocacola.Value));
                ticket.Add(new Producto((float)10.5, "PesiCola", (int)pepsicola.Value));
                ticket.Add(new Producto((float)7.5, "Agua", (int)agua.Value));
                ticket.Add(new Producto((float)12, "Pinguinos", (int)pinguinos.Value));
                ticket.Add(new Producto((float)8, "Gansito", (int)gansito.Value));
                ticket.Add(new Producto((float)27, "Queso", (int)queso.Value));

            Form2 f2 = new Form2(ticket);
            f2.Show();
            this.Hide();






        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ticket.Clear();
            cocacola.Value = 0;
            pepsicola.Value = 0;
            agua.Value = 0;
            pinguinos.Value = 0;
            gansito.Value = 0;
            queso.Value = 0;
        }
    }
}
