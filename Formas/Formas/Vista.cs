using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formas
{
    partial class Vista : Form
    {
        private Label nombre;
        private TextBox txtNombre;
        private Button btnAceptar;


        public Vista() {
            nombre = new Label();
            nombre.Text = "Ingrese Su pendejo Nombre";
            nombre.Location = new System.Drawing.Point(10,20);
            nombre.Size = new System.Drawing.Size(180, 35);
            nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            nombre.Font = new System.Drawing.Font("Times New Roman", 12);
            txtNombre = new TextBox();
            txtNombre.Location = new System.Drawing.Point(10, 20);
            txtNombre.Size = new System.Drawing.Size(180, 35);
            txtNombre.TextAlign = HorizontalAlignment.Right;
            txtNombre.Font = new System.Drawing.Font("Times New Roman", 12);
            txtNombre.Show();
            
            btnAceptar = new Button();
            btnAceptar.Location = new System.Drawing.Point(60, 100);
            btnAceptar.Size = new System.Drawing.Size(60, 100);
            btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;



            btnAceptar.Text = "Presiona Aqui";
            this.Controls.Add(txtNombre);
            this.Controls.Add(nombre);
            this.Controls.Add(btnAceptar);


        }

        private void IniciarComponentes() {
            this.Text = "Formulario Mamon";
            this.Size = new System.Drawing.Size(120,200);
            this.Location = new System.Drawing.Point(400,100);
            

        }

     


    }
}
