using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace DulceTentacion
{
    public partial class CuentaUsuario : Form
    {

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

        private void CuentaUsuario_Load(object sender, EventArgs e)
        {

        }

    }
}
