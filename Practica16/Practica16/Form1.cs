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
                catch (FormatException error)
                {
                    txtEntrada.Text = "";
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(lbNum.Text == null)
                {
                    throw new ApplicationException("Ingresa por lo menos un número");
                }
                else
                {
                    V = new int[Vector.Count];
                    for (int i = 0; i < Vector.Count; i++)
                    {
                        V[i] = Vector[i];
                    }
                    quicksort(V, 0, V.Length - 1);
                    for (int i = 0; i < V.Length; i++)
                    {
                        lbOrdenado.Text = lbOrdenado.Text + V[i] + " ";
                    }
                    errorProv.Clear();
                }
               
            }
            catch (ApplicationException error)
            {
                errorProv.SetError(txtEntrada, error.Message);
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

        public void quicksort2 (int[] vector, int primero, int ultimo)
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
                while (vector[i] > pivote) i++;
                while (vector[j] < pivote) j--;
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
                quicksort2(vector, primero, j);
            }
            if (i < ultimo)
            {
                quicksort2(vector, i, ultimo);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if(lbNum.Text == null)
                {
                    throw new ApplicationException("Ingresa por lo menos un número");
                }
                else
                {
                    V = new int[Vector.Count];
                    for (int i = 0; i < Vector.Count; i++)
                    {
                        V[i] = Vector[i];
                    }
                    quicksort2(V, 0, V.Length - 1);
                    for (int i = 0; i < V.Length; i++)
                    {
                        lbOrdenado.Text = lbOrdenado.Text + V[i] + " ";
                    }
                }
            }
            catch(ApplicationException error)
            {
                errorProv.SetError(txtEntrada, error.Message);
            }
          
                    
            
        }

        static int binario(int[] V, int X)
        {
            int izq = 0;
            int der = V.Length - 1;
            int centro = (izq + der) / 2;
            bool encontrado = false;

          

            while (izq < der && !encontrado)
            {
                if (V[centro] == X)
                {
                    encontrado = true;
                }
               
                else
                {
                    if (X > V[centro])
                    {
                        izq = centro + 1;
                    }
                    else
                    {
                        der = centro - 1;
                    }
                }
                centro = (izq + der) / 2;
                
                if (V[izq] == X)
                {
                    encontrado = true;
                }
                
            }

            if (encontrado)
            {
                return centro;
            }
            
            else
            {
                return -1;
            }
            
        }

        private void btnBuscar1_Click(object sender, EventArgs e)
        {
        
                    int valor = int.Parse(txtbBuscar.Text);
                    int indice = binario(V, valor);
                    if (indice != -1)
                    {
                        MessageBox.Show("Valor encontrado en la posición: " + indice);
                    }

                    else
                    {
                        MessageBox.Show("Valor no encontrado");
                    }
        }

        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            int elemento = int.Parse(txtbBuscar.Text);
            int indice = binario(V, elemento);
            for (int k=0; k<V.Length; k++)
            {
                if (V[k] == elemento)
                {
                    MessageBox.Show("Valor encontrado");

                } 
            }
           
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para llevar a cabo una busqueda es necesario hacer un ordenamiento ascendente previo a la búsqueda.");
        }
    }
}
