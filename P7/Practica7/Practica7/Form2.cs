using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica7
{
    public partial class Form2 : Form
    {
        private float[,] m1 = new float[2, 2];
        private Matriz2x2[] Almacenamiento = new Matriz2x2[2];
     
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private Matriz2x2 leer() {
            m1[0, 0] = float.Parse(a11.Text);
            m1[0, 1] = float.Parse(a12.Text);
            m1[1, 0] = float.Parse(a21.Text);
            m1[1, 1] = float.Parse(a22.Text);
            return new Matriz2x2(m1);

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            Almacenamiento[1] = leer();
            Matriz2x2 C;
            C = Almacenamiento[1] + Almacenamiento[0];
            lbres.Text = C.ToString();
        }

        private void next_Click(object sender, EventArgs e)
        {

            Almacenamiento[0] = leer();
            a11.Text = "";
            a12.Text = "";
            a21.Text = "";
            a22.Text = "";
            lbal.Text = Almacenamiento[0].ToString();
        }
    }
}
