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
            ApplyColors(); // Aplicar los colores al abrir el formulario
            MenuPrincipal.DarkModeChanged += ApplyColors;
        }



        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // Método para aplicar colores oscuros si el modo oscuro está activo
        private void ApplyDarkModeIfNeeded()
        {
            if (MenuPrincipal.DarkModeActive)
            {
                this.BackColor = Color.Black;
                BarraHorizontall.BackColor = Color.DimGray;
                pnlMenu.BackColor = Color.Gray;
                btnAtCliente.BackColor = Color.DimGray;
                btnRegVentas.BackColor = Color.DimGray;
                btnEditMenu.BackColor = Color.DimGray;
                btnGenFacturas.BackColor = Color.DimGray;
                btnAtReclamos.BackColor = Color.DimGray;

                btnAtCliente.ForeColor = Color.White; // Configurar color de texto del botón en modo oscuro
                btnRegVentas.ForeColor = Color.White; // Configurar color de texto del botón en modo oscuro
                btnEditMenu.ForeColor = Color.White; // Cambiar el color del texto de GroupBox en modo oscuro
                btnGenFacturas.ForeColor = Color.White;
                btnAtReclamos.ForeColor = Color.White;
            }
            else
            {
                // Aplicar colores originales
                this.BackColor = Color.FromArgb(255, 222, 231);
                BarraHorizontall.BackColor = Color.FromArgb(255, 192, 255);
                pnlMenu.BackColor = Color.Purple;
                btnAtCliente.BackColor = Color.White;
                btnRegVentas.BackColor = Color.White;
                btnEditMenu.BackColor = Color.White;
                btnGenFacturas.BackColor = Color.White;
                btnAtReclamos.BackColor = Color.White;

                btnEditMenu.ForeColor = Color.Black; // Revertir color de texto del botón
                btnAtReclamos.ForeColor = Color.Black; // Revertir color de texto del botón
                btnGenFacturas.ForeColor = Color.Black; // Restaurar el color original del texto de GroupBox
                btnAtCliente.ForeColor = Color.Black;
                btnRegVentas.ForeColor = Color.Black;
               
            }
        }

        // Método para aplicar los colores al abrir el formulario
        private void ApplyColors()
        {
            // Llamar al método para aplicar el modo oscuro si es necesario
            ApplyDarkModeIfNeeded();
        }

        // Método para actualizar el estado del modo oscuro desde MenuPrincipal
        public void UpdateDarkModeState(bool isDarkMode)
        {
            MenuPrincipal.DarkModeActive = isDarkMode;
            ApplyColors();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            // Desuscribirse del evento cuando el formulario se cierre
            MenuPrincipal.DarkModeChanged -= ApplyColors;
            base.OnFormClosed(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // Guardar los colores originales cuando se carga el formulario
            originalBackColor = this.BackColor;
            originalForeColor = btnAtCliente.ForeColor;
            originalForeColor = btnAtReclamos.ForeColor;
            originalForeColor = btnGenFacturas.ForeColor;
            originalForeColor = btnRegVentas.ForeColor;
            originalForeColor = btnEditMenu.ForeColor;


            originalpnlMenuColor = pnlMenu.ForeColor; // Guardar el color original del texto de GroupBox
            originalpnlAtenderColor = pnlAtender.ForeColor; // Guardar el color original del texto de GroupBox

        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
