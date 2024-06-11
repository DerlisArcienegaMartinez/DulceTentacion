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

            // Deshabilitar AutoScroll del contenedor antes de agregar el nuevo formulario
            pnlPastelesMenu.AutoScroll = false;


            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlPastelesMenu.Controls.Add(childForm);
            pnlPastelesMenu.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            // Suscribirse al evento FormClosed del formulario hijo
            childForm.FormClosed += ChildForm_FormClosed;
        }

        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Volver a habilitar el AutoScroll del contenedor después de cerrar el formulario hijo
            pnlPastelesMenu.AutoScroll = true;
        }




        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbPastel0_Click(object sender, EventArgs e)
        {
            abrirConPrincipal(new Pastel1());
        }

        private void lblPastel0_Click(object sender, EventArgs e)
        {
            abrirConPrincipal(new Pastel1());
        }
    }
}
