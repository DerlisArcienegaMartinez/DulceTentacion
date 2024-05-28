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
    public partial class Pasteles : Form
    {
        public Pasteles()
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
                btnCrearPastel.BackColor = Color.DimGray;
                
                btnCrearPastel.ForeColor = Color.White; // Configurar color de texto del botón en modo oscuro
                
            }
           
        }

        // Método para aplicar los colores al abrir el formulario
        private void ApplyColors()
        {
            // Llamar al método para aplicar el modo oscuro si es necesario
            ApplyDarkModeIfNeeded();
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbPastel0_Click(object sender, EventArgs e)
        {
            using (Pastel1 pastel1 = new Pastel1())
                pastel1.ShowDialog();
        }
    }
}
