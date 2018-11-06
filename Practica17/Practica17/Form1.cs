using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica17
{
    public partial class Form1 : Form
    {
        Tienda tienda;
        public Form1()
        {
            InitializeComponent();

            
            tienda.Nombre = "Abarrotes Rogelio";
            tienda.galletas.Nombreg = "Emperador";
            tienda.galletas.Compañiag = "Gamesa";
            tienda.galletas.Tamañog = "Tubo";
            tienda.galletas.Preciog = 10.5f;

            tienda.refresco.Nombrer = "Squirt";
            tienda.refresco.Compañia = "Pepsi";
            tienda.refresco.Tamaño = "Grande";
            tienda.refresco.Precio = 27.5f;
            txtbNombreTienda.Text = tienda.Nombre;
        }

        struct Tienda
        {
            public string Nombre;
            public Galletas galletas;
            public Refresco refresco; 
        }


        struct Refresco
        {
            public string Nombrer;
            public string Compañia;
            public string Tamaño;
            public float Precio;
        }

        struct Galletas
        {
            public string Nombreg;
            public string Compañiag;
            public string Tamañog;
            public float Preciog;
        }


        struct Cliente
        {
            public int Numero;
            public int Edad;
            public string Sexo;
        }

        Cliente[] clientes = new Cliente[5];
        

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            try
            {

                if(txtbEdadCliente.Text == "" || txtbNumeroCliente.Text == "" || txtbSexoCliente.Text == "")
                {
                    throw new ApplicationException("No dejar ningún campo vacío");
                }

                clientes[1].Numero = int.Parse(txtbNumeroCliente.Text);
                clientes[1].Edad = int.Parse(txtbEdadCliente.Text);
                clientes[1].Sexo = txtbSexoCliente.Text;

                MessageBox.Show("Cliente reconocido =)");
                MessageBox.Show("Le informamos que los siguientes artículos se encuentran agotados");
                txtbNombreGalletas.Text = tienda.galletas.Nombreg;
                txtB1.Text = tienda.galletas.Compañiag;
                txtB2.Text =  tienda.galletas.Preciog.ToString();
                txtB3.Text = tienda.galletas.Tamañog;
                txtbNombreRefresco.Text = tienda.refresco.Nombrer;
                txtA1.Text = tienda.refresco.Compañia;
                txtA2.Text = tienda.refresco.Precio.ToString();
                txtA3.Text = tienda.refresco.Tamaño;

                errorProv.Clear();

             

            }
            catch (ApplicationException error)
            {
                errorProv.SetError(txtbEdadCliente, error.Message);
            }
            catch (FormatException)
            {
                MessageBox.Show("Datos inválidos");
            }

            
            
            
            

        }
    }
}
