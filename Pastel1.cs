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
    public partial class Pastel1 : Form
    {
        public Pastel1()
        {
            InitializeComponent();
        }


        //Configurar la ventana en el panel contenedor
        private Form activeForm = null;
        private void abrirConPrincipal(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlPastel1.Controls.Add(childForm);
            pnlPastel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntReservar_Click(object sender, EventArgs e)
        {
            abrirConPrincipal(new AtencionCliente());
        }

        private void btnCarrito_Click(object sender, EventArgs e)
        {
            abrirConPrincipal(new Carrito());
        }
    }
}
