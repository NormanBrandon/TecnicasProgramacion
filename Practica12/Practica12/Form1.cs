using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica11
{
    public partial class Form1 : Form
    {
        Salchichoneria embutidos;
        List<Salchichoneria> lstEmbutidos;

        public Form1()
        {
            InitializeComponent();
            lstEmbutidos = new List<Salchichoneria>();

            lstEmbutidos.Add(new Salchichoneria("Salchichas"));
            lstEmbutidos.Add(new Salchichoneria("Jamón"));
            lstEmbutidos.Add(new Salchichoneria("Chorizo"));

            for (int i=0; i<lstEmbutidos.Count; i++)
            {
                lstbProductos.Items.Add(lstEmbutidos[i].Tipo);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Gracias por tu compra!\n\nTu carrito se guardó con éxito");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbProducto.Text == "")
                {
                   
                    throw new ApplicationException("No dejar vacío");
                }
                else
                {
                    lstEmbutidos.Add(new Salchichoneria(txtbProducto.Text));
                    lstbProductos.Items.Add(lstEmbutidos[lstEmbutidos.Count - 1].Tipo);
                    errorProv.Clear();
                }
            }
            catch(ApplicationException error)
            {
                errorProv.SetError(txtbProducto, error.Message);
            }
                  
        }
    }
}
