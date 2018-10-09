using System;
using System.Collections.Generic;
using System.Drawing;
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
                if(txtbProducto.Text == "")
                {
                    throw new ApplicationException("No dejar vacío :v");
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
            catch(FormatException error)
            {
                errorProv.SetError(txtbProducto, error.Message);
            }
            
                   
        }

        private void lstbProductos_DoubleClick(object sender, EventArgs e)
        {
            string tipo;
            tipo = (string)lstbProductos.SelectedItem;
            lstEmbutidos.RemoveAt(lstbProductos.SelectedIndex);
            DialogResult dialogResult = MessageBox.Show("Seguro que deseas eliminar " + tipo, "Confirmacion", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                lstbProductos.Items.Remove(lstbProductos.SelectedItem);
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
            
        }

        private void lstbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
