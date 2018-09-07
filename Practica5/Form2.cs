using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica5
{
    public partial class Form2 : Form
    {
        private bool entrada;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            lboperando.Text = "+";
            try
            {
                lbres.Text = (float.Parse(lboper1.Text) + float.Parse(lboper2.Text)).ToString();
            }
            catch (OverflowException error)
            {
                MessageBox.Show("Operacion demasiado grande", "Error");
                lboper1.Text = "";
                lboper2.Text = "";
                lboperando.Text = "";
                lbres.Text = "";
                entrada = false;

            }
            catch (FormatException error)
            {
                MessageBox.Show("No ha ingresado numeros", "Error");
                lboper1.Text = "";
                lboper2.Text = "";
                lboperando.Text = "";
                lbres.Text = "";
                entrada = false;

            }

        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            lboperando.Text = "-";
            try
            {
                lbres.Text = (float.Parse(lboper1.Text) - float.Parse(lboper2.Text)).ToString();
            }
            catch (OverflowException error)
            {
                MessageBox.Show("Operacion demasiado grande", "Error");
                lboper1.Text = "";
                lboper2.Text = "";
                lboperando.Text = "";
                lbres.Text = "";
                entrada = false;

            }
            catch (FormatException error)
            {
                MessageBox.Show("No ha ingresado numeros", "Error");
                lboper1.Text = "";
                lboper2.Text = "";
                lboperando.Text = "";
                lbres.Text = "";
                entrada = false;

            }

        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            lboperando.Text = "x";
            try
            {
                lbres.Text = (float.Parse(lboper1.Text) * float.Parse(lboper2.Text)).ToString();
            }
            catch (FormatException error)
            {
                MessageBox.Show("No ha ingresado numeros", "Error");
                lboper1.Text = "";
                lboper2.Text = "";
                lboperando.Text = "";
                lbres.Text = "";
                entrada = false;

            }
            catch (OverflowException error)
            {
                MessageBox.Show("Operacion demasiado grande", "Error");
                lboper1.Text = "";
                lboper2.Text = "";
                lboperando.Text = "";
                lbres.Text = "";
                entrada = false;

            }
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            lboperando.Text = "/";
            try
            {
                if (float.Parse(lboper2.Text) == 0)
                {
                    throw new ApplicationException();
                }
                lbres.Text = (float.Parse(lboper1.Text) / float.Parse(lboper2.Text)).ToString();
                

            }
            catch (ApplicationException error)
            {
                MessageBox.Show("No puedes dividir por 0", "Error");

            }
            catch (FormatException error)
            {
                MessageBox.Show("No ha ingresado numeros", "Error");
                lboper1.Text = "";
                lboper2.Text = "";
                lboperando.Text = "";
                lbres.Text = "";
                entrada = false;

            }
            catch (OverflowException error) {
                MessageBox.Show("Operacion demasiado grande", "Error");
                lboper1.Text = "";
                lboper2.Text = "";
                lboperando.Text = "";
                lbres.Text = "";
                entrada = false;

            }
        }



        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            lboper1.Text = "";
            lboper2.Text = "";
            lboperando.Text = "";
            lbres.Text = "";
            entrada = false;
        }

        private void txtentrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (!entrada)
                {
                    entrada = true;
                    lboper2.Text = txtentrada.Text;
                    txtentrada.Text = "";
                }
                else
                {
                    lboper1.Text = txtentrada.Text;
                    txtentrada.Text = "";
                }
            }
        }

        private void pro_Click(object sender, EventArgs e)
        {

            this.Hide();

        }
    }
}
