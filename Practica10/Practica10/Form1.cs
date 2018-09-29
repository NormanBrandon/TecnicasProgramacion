using System;
using System.Windows.Forms;
using System.Collections;

namespace Practica10
{
    public partial class Form1 : Form
    {

        short contador = 0;
        int contado2 = 0;
        ArrayList labels = new ArrayList();
        Label lb;
        public delegate void Manejador();
        public delegate void Manejador2();
        public delegate void Manejador3();
        public event Manejador DisparaEvento1;
        public event Manejador DisparaEvento2;
        public event Manejador2 DisparaEvento3;
        public event Manejador2 DisparaEvento4;
        public event Manejador3 DisparaEvento5;
        public event Manejador3 DisparaEvento6;



        public bool[,] numeros = {
        { true, true, true, true, true, true, false},
        { true, true, false, false, false, false, false },
        { true, false, true, true, false, true, true},
        { true, true, true, false, false, true, true},
        { true, true, false, false, true, false, true},
        { false, true, true, false, true, true, true},
        { false, true, true, true, true, true, true},
        { true, true, false, false, false, true, false},
        { true, true, true, true, true, true, true},
        { true, true, true, false, true, true, true},
        };
        public Form1()
        {
            InitializeComponent();
        }
        #region Metodos de Eventos
        private void validarContador() {
            if (contador >= 9)
            {
                contador = 0;
            }
            else
            {
                contador++;
            }

        }
        private void validarTmax()
        {
            if (timer1.Interval > 2000)
            {
                timer1.Interval = 1950;
                MessageBox.Show("El limite de tiempo maximo es de 2 s", "Error");
            }
        }

        private void validarTmin()
        {
            if (timer1.Interval < 100)
            {
                timer1.Interval = 100;
                MessageBox.Show("El limite de tiempo minimo es de 100 ms", "Error");
            }
        }
        private void versionPro()
        {
            contado2++;
            if (contado2 % 5==0)
            {
                MessageBox.Show("Cambie a la version pro por solo $9.99 al mes", "Gracias por usar nuestra app");
            }
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisparaEvento1();
            setNumber();

        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            contador = 0;
            setNumber();
            DisparaEvento4();
        }
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            DisparaEvento6();
            tiempo.Text = "" + timer1.Interval;
        }
        private void btnParar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            DisparaEvento5();
        }
        private void btnDisminuir_Click(object sender, EventArgs e)
        {
            timer1.Interval += 50;
            
            DisparaEvento3();
            tiempo.Text = "" + timer1.Interval;
            DisparaEvento6();
        }

        private void btnAumentar_Click(object sender, EventArgs e)
        {
            timer1.Interval -= 50;            
            DisparaEvento2();
            tiempo.Text = "" + timer1.Interval;
            DisparaEvento6();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {

                contador = short.Parse(textBox1.Text);
            }
            setNumber();
        }
  


        private void setNumber() {
            for (int j = 0; j < 7; j++)
            {
                lb = (Label)labels[j];
                lb.Visible = numeros[contador, j];
            }
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            labels.Add(label1);
            labels.Add(label2);
            labels.Add(label3);
            labels.Add(label4);
            labels.Add(label5);
            labels.Add(label6);
            labels.Add(label7);
            DisparaEvento1 += this.validarContador;
            DisparaEvento2 += this.validarTmin;
            DisparaEvento3 += this.validarTmax;
            DisparaEvento4 += this.versionPro;
            DisparaEvento5 += this.versionPro;
            DisparaEvento6 += this.versionPro;

        }


    }
}
