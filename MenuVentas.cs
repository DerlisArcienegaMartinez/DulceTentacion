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
    public partial class MenuVentas : Form
    {

        private Color originalBackColor;

        public MenuVentas()
        {
            InitializeComponent();
            ApplyColors(); // Aplicar los colores al abrir el formulario
            MenuPrincipal.DarkModeChanged += ApplyColors;
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
            contVentas.Controls.Add(childForm);
            contVentas.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

     

        // Método para aplicar colores oscuros si el modo oscuro está activo
        private void ApplyDarkModeIfNeeded()
        {
            if (MenuPrincipal.DarkModeActive)
            {
                this.BackColor = Color.Black;
                BarraHorizontal.BackColor = Color.DimGray;
                //.BackColor = Color.Black;
                btnCarrito.BackColor = Color.DimGray;
                btnCarrito.ForeColor = Color.White;



            }
            else
            {
                // Aplicar colores originales
                this.BackColor = Color.FromArgb(255, 222, 231);
                BarraHorizontal.BackColor = Color.FromArgb(255, 192, 255);
                contVentas.BackColor = Color.FromArgb(255, 222, 231);
                btnCarrito.BackColor = Color.White;
                btnCarrito.ForeColor = Color.Black;


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



            // originalContVentasColor = ContVentas.ForeColor; // Guardar el color original del texto de GroupBox

        }







        private void fndPasteles_Click(object sender, EventArgs e)
        {
            abrirConPrincipal(new Pasteles());
        }

        private void btnPasteles_Click(object sender, EventArgs e)
        {
            abrirConPrincipal(new Pasteles());
        }

        private void fndPorciones_Click(object sender, EventArgs e)
        {
            abrirConPrincipal(new Porciones());
        }

        private void btnPorciones_Click(object sender, EventArgs e)
        {
            abrirConPrincipal(new Porciones());
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
