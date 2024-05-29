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
            ApplyColors(); // Aplicar los colores al abrir el formulario
            MenuPrincipal.DarkModeChanged += ApplyColors;
        }

        private void ApplyDarkModeIfNeeded()
        {
            if (MenuPrincipal.DarkModeActive)
            {
                this.BackColor = Color.Black;
                btnCarrito.BackColor = Color.DimGray;
                btnRegresar.BackColor = Color.DimGray;
                pnlPastel1.BackColor = Color.Black;
                btnReservar.BackColor = Color.DimGray;

            }

        }

        // Método para aplicar los colores al abrir el formulario
        private void ApplyColors()
        {
            // Llamar al método para aplicar el modo oscuro si es necesario
            ApplyDarkModeIfNeeded();
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
