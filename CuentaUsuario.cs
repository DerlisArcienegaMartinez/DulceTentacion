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
    public partial class CuentaUsuario : Form
    {

        private Color originalBackColor;
        private Color originalForeColor;
        private Color originalGroupBoxForeColor;
        private Color originalGroupBox1ForeColor;

        public CuentaUsuario()
        {
            InitializeComponent();
            ApplyColors(); // Aplicar los colores al abrir el formulario
            MenuPrincipal.DarkModeChanged += ApplyColors;

        }




        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditarInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {

        }

        // Método para aplicar colores oscuros si el modo oscuro está activo
        private void ApplyDarkModeIfNeeded()
        {
            if (MenuPrincipal.DarkModeActive)
            {
                this.BackColor = Color.Black;
                BarraHorizontall.BackColor = Color.DimGray;
                btnEditarInfo.BackColor = Color.DimGray; 
                btnSaveInfo.BackColor = Color.DimGray;
                btnEditarInfo.ForeColor = Color.White; // Configurar color de texto del botón en modo oscuro
                btnSaveInfo.ForeColor = Color.White; // Configurar color de texto del botón en modo oscuro
                DatoPersonal.ForeColor = Color.White; // Cambiar el color del texto de GroupBox en modo oscuro
                DatoLaboral.ForeColor = Color.White;
            }
            else
            {
                // Aplicar colores originales
                this.BackColor = Color.FromArgb(255, 222, 231);
                BarraHorizontall.BackColor = Color.FromArgb(255,192,255);
                btnEditarInfo.BackColor = Color.White;
                btnSaveInfo.BackColor = Color.White;
                btnEditarInfo.ForeColor = Color.Black; // Revertir color de texto del botón
                btnSaveInfo.ForeColor = Color.Black; // Revertir color de texto del botón
                DatoPersonal.ForeColor = Color.Black; // Restaurar el color original del texto de GroupBox
                DatoLaboral.ForeColor = Color.Black;
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
            originalForeColor = btnEditarInfo.ForeColor; 
            originalGroupBoxForeColor = DatoPersonal.ForeColor; // Guardar el color original del texto de GroupBox
            originalGroupBox1ForeColor = DatoLaboral.ForeColor; // Guardar el color original del texto de GroupBox

        }
    }
}
