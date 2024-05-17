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
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
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
            ContVentas.Controls.Add(childForm);
            ContVentas.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnPasteles_Click(object sender, EventArgs e)
        {
            abrirConPrincipal(new Pasteles());
        }

        private void ContVentas_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
