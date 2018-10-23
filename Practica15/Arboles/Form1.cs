using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arboles
{
    public partial class Form1 : Form
    {
        ArbolDibuja ad;
        nodo A;
        public Form1()
        {
            InitializeComponent();
            ad = new ArbolDibuja(ptb);
            nodo A = new nodo();
            A = null;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                
                ad.inserta_nodo(ad.Raiz, A, int.Parse(textBox1.Text), 0);
                textBox1.Text = "";
            }
            else if (e.KeyChar == (char)Keys.R)
            {
                ad.preorden(ad.Raiz);

            }
            else if (e.KeyChar == (char)Keys.P) {
                ad.posorden(ad.Raiz);
       
            }
            else if (e.KeyChar == (char)Keys.I)
            {
                ad.inorden(ad.Raiz);
             
            }
           
        }
    }
}
