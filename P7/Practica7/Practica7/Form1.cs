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
    public partial class Form1 : Form
    {
        private float[,] m1 = new float[3, 3];
        private float[,] m2 = new float[3, 3];
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            leer();
            Matriz A = new Matriz(m1);
            Matriz B = new Matriz(m2);
            Matriz C = A + B;
            lbres.Text = C.ToString();

        }
        private void btnRestar_Click(object sender, EventArgs e)
        {
            leer();
            Matriz A = new Matriz(m1);
            Matriz B = new Matriz(m2);
            Matriz C = A - B;
            lbres.Text = C.ToString();

        }
        private void leer() {
            m1[0, 0] = float.Parse(a11.Text);
            m1[0, 1] = float.Parse(a12.Text);
            m1[0, 2] = float.Parse(a13.Text);
            m1[1, 0] = float.Parse(a21.Text);
            m1[1, 1] = float.Parse(a22.Text);
            m1[1, 2] = float.Parse(a23.Text);
            m1[2, 0] = float.Parse(a31.Text);
            m1[2, 1] = float.Parse(a32.Text);
            m1[2, 2] = float.Parse(a33.Text);
            m2[0, 0] = float.Parse(b11.Text);
            m2[0, 1] = float.Parse(b12.Text);
            m2[0, 2] = float.Parse(b13.Text);
            m2[1, 0] = float.Parse(b21.Text);
            m2[1, 1] = float.Parse(b22.Text);
            m2[1, 2] = float.Parse(b23.Text);
            m2[2, 0] = float.Parse(b31.Text);
            m2[2, 1] = float.Parse(b32.Text);
            m2[2, 2] = float.Parse(b33.Text);
        }

        private void next_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();

        }
    }
}
