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
    public partial class RegistrarPersonal : Form
    {
        public RegistrarPersonal()
        {
            InitializeComponent();
            ApplyColors(); // Aplicar los colores al abrir el formulario
            MenuPrincipal.DarkModeChanged += ApplyColors;
        }

        // Método para aplicar colores oscuros si el modo oscuro está activo
        private void ApplyDarkModeIfNeeded()
        {
            if (MenuPrincipal.DarkModeActive)
            {
                this.BackColor = Color.Black;
                BarraHorizontal.BackColor = Color.DimGray;
                btnAdministrador.BackColor = Color.DimGray;
                btnCancelar.BackColor = Color.DimGray;
                btnChef.BackColor = Color.DimGray;
                btnClientes.BackColor = Color.DimGray;
                btnGerente.BackColor = Color.DimGray;
                btnLimpieza.BackColor = Color.DimGray;
                btnMesero.BackColor = Color.DimGray;
                btnRegistrar.BackColor = Color.DimGray;
                btnRepartidor.BackColor = Color.DimGray;
                pnlContrato.BackColor = Color.Black;
                pnlDatos.BackColor = Color.Black;
                pnlOpcional.BackColor = Color.Black;

                pnlDatos.ForeColor = Color.White;
            }

        }

        // Método para aplicar los colores al abrir el formulario
        private void ApplyColors()
        {
            // Llamar al método para aplicar el modo oscuro si es necesario
            ApplyDarkModeIfNeeded();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
