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
        int grado = 0, orden = 0;
        int altura1 =0,altura2=0,altura3=0,altura4=0;
        int hoja1,hoja2,hoja3,hoja4,node,raiz;
        int start = 0;
        List<int> alturas = new List<int>();
        List<int> altura;


        public Form1()
        {
            InitializeComponent();
            ad = new ArbolDibuja(ptb);
            nodo A = new nodo();
            A = null;
            lborden.Text = "2";
            alturas.Add(0);
            alturas.Add(1);
            alturas.Add(0);
            alturas.Add(0);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                node = int.Parse(textBox1.Text);
                ad.inserta_nodo(ad.Raiz, A, node, 0);             
                textBox1.Text = "";
                if (start > 0)
                {
                    if (node > hoja1 && node< hoja4) {
                        hoja2 = node;
                        alturas[1] = altura[3] + 1;
                    }
                    if (node < hoja1)
                    {
                        hoja1 = node;
                        alturas[0] = alturas[0] + 1;

                    }
                    if (node > hoja4)
                    {
                        hoja4 = node;
                        alturas[3] = alturas[3] + 1;
                    }
                    
                    altura = alturas;
                    altura.Sort();
                    lbaltura.Text = altura[3]+"";
                   
                    
                    start++;
                    if (start == 2 || start==3) {
                        grado++;
                    }
                }
                else {
                    raiz = node;
                    hoja1 = node;
                    hoja2 = node;
                    hoja3 = node;
                    hoja4 = node;
                    start ++;
                }
                lbgrado.Text = grado + "";




            }
            else if (e.KeyChar == (char)Keys.R)
            {
                ad.preorden(ad.Raiz);

            }
            else if (e.KeyChar == (char)Keys.P)
            {
                ad.posorden(ad.Raiz);

            }
            else if (e.KeyChar == (char)Keys.I)
            {
                ad.inorden(ad.Raiz);

            }
            
        
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
