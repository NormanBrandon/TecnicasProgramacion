using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica9
{
    public partial class InformacionAntibioticos : Form
    {
        
        public InformacionAntibioticos()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCalculaTotal_Click(object sender, EventArgs e)
        {
            Antibioticos anti = new Antibioticos();
            int total = anti.Total(int.Parse(txtbPiezas.Text)) ;
            int dosis = anti.Dosis(byte.Parse(txtbDosis.Text));
            txtbTotal.Text = "$" + total + " , " + dosis + " Dosis";
            string suministroAntibioticos = "Intravenoso";
            txtbSuministro.Text = suministroAntibioticos;

        }
    }
}
