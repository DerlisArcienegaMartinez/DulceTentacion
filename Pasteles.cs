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

        private Color originalBackColor;
        private Color originalForeColor;
        private Color originalBox1Color;
        private Color originalBox2Color;
        private Color originalBox3Color;
        private Color originalBox4Color;
        private Color originalBox5Color;

        public Pasteles()
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
                btnRegresar.BackColor = Color.DimGray;
                btnRegresar.ForeColor = Color.White; // Configurar color de texto del botón en modo oscuro
                Box1.ForeColor = Color.White;
                Box2.ForeColor = Color.White;
                Box3.ForeColor = Color.White;
                Box4.ForeColor = Color.White;
                Box5.ForeColor = Color.White;
            }
            else
            {
                // Aplicar colores originales
                this.BackColor = Color.FromArgb(255, 222, 231);
                btnRegresar.BackColor = Color.White;
                btnRegresar.ForeColor = Color.Black; // Revertir color de texto del botón
                Box1.ForeColor = Color.Black;
                Box2.ForeColor = Color.Black;
                Box3.ForeColor = Color.Black;
                Box4.ForeColor = Color.Black;
                Box5.ForeColor = Color.Black;
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
            originalForeColor = btnRegresar.ForeColor;
           


            originalBox1Color = Box1.ForeColor; // Guardar el color original del texto de GroupBox
            originalBox2Color = Box2.ForeColor; // Guardar el color original del texto de GroupBox
            originalBox3Color = Box3.ForeColor; // Guardar el color original del texto de GroupBox
            originalBox4Color = Box4.ForeColor; // Guardar el color original del texto de GroupBox
            originalBox5Color = Box5.ForeColor; // Guardar el color original del texto de GroupBox

        }

    }
}
