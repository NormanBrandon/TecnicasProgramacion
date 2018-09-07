using System;

using System.Windows.Forms;


namespace Practica5
{
    public partial class Form1 : Form
    {
        bool entrada = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void suma_Click(object sender, EventArgs e)
        {
            lboperando.Text = "+";
            try {
                lbres.Text = (float.Parse(lboper1.Text)+float.Parse(lboper2.Text)).ToString();
            }
            catch (Exception error) {
                MessageBox.Show(error.Message,"Error");
            }

        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            lboperando.Text = "-";
            try
            {
                lbres.Text = (float.Parse(lboper1.Text) - float.Parse(lboper2.Text)).ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error");

            }

        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            lboperando.Text = "x";
            try
            {
                lbres.Text = (float.Parse(lboper1.Text) * float.Parse(lboper2.Text)).ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error");

            }
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            lboperando.Text = "/";
            try
            {
                lbres.Text = (float.Parse(lboper1.Text) / float.Parse(lboper2.Text)).ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error");

            }
        }



        private void lipiarclick(object sender, EventArgs e)
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
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
