using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica16
{
    public partial class Form1 : Form
    {
        int []V;
        List<int> Vector = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    int numeros = int.Parse(txtEntrada.Text);
                    Vector.Add(numeros);
                    lbNum.Text = lbNum.Text + " " +numeros;
                    txtEntrada.Text = "";
                }
                catch (FormatException error) {
                    txtEntrada.Text = "";
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            V = new int[Vector.Count];
            for (int i = 0; i < Vector.Count; i++) {
                V[i] = Vector[i];
            }
            quicksort(V,0,V.Length -1);
            for (int i = 0; i < V.Length; i++) {
                lbOrdenado.Text = lbOrdenado.Text + V[i] + " ";
            }
        }

        public void quicksort(int[] vector, int primero, int ultimo)
        {
            int i, j, central;
            double pivote;
            int aux;
            central = (primero + ultimo) / 2;
            pivote = vector[central];
            i = primero;
            j = ultimo;
            do
            {
                while (vector[i] < pivote) i++;
                while (vector[j] > pivote) j--;
                if (i <= j)
                {
                    aux = vector[i];
                    vector[i] = vector[j];
                    vector[j] = aux;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (primero < j)
            {
                quicksort(vector, primero, j);
            }
            if (i < ultimo)
            {
                quicksort(vector, i, ultimo);
            }
        }
    }
}
