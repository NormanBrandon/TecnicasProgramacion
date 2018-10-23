using System;
using System.Drawing;
using System.Windows.Forms;
using Arboles;

namespace ArbolBinario
{
    public partial class Form1 : Form
    {
        Arbol arbolbinario;
        public Form1()
        {
            InitializeComponent();
            arbolbinario = new Arbol(ptbArbol);
        }

        private void txtbDato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                arbolbinario.inserta_nodo(arbolbinario.Raiz, null, int.Parse(txtbDato.Text), 0);
                txtbDato.Clear();
            }
            else if (e.KeyChar == (char)Keys.P)
            {
                arbolbinario.preorden(arbolbinario.Raiz);
            }
            else if (e.KeyChar == (char)Keys.I)
            {
                arbolbinario.inorden(arbolbinario.Raiz);
            }
            else if (e.KeyChar == (char)Keys.O)
            {
                arbolbinario.posorden(arbolbinario.Raiz);
            }

        }

        private void btnCaracterísticas_Click(object sender, EventArgs e)
        {

        }
    }

}
