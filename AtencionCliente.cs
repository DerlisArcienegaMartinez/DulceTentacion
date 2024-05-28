using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DulceTentacion
{
    public partial class AtencionCliente : Form
    {

        private Color originalBackColor;
        private Color originalForeColor;
        private Color originalpnlAtenderColor;
        private Color originalpnlMenuColor;

        public AtencionCliente()
        {
            InitializeComponent();
            //ApplyColors(); // Aplicar los colores al abrir el formulario
            //MenuPrincipal.DarkModeChanged += ApplyColors;
        }



        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


       

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnGenFacturas_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
