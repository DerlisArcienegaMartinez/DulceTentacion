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
    public partial class VisualizarProducto : Form
    {

        public VisualizarProducto()
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
                btnAddProd.BackColor = Color.DimGray;
                btnAllProd.BackColor = Color.DimGray;
                btnDelProd.BackColor = Color.DimGray;
                btnEditProd.BackColor = Color.DimGray;
                btnProdAgo.BackColor = Color.DimGray;

                btnAddProd.ForeColor = Color.White;
                btnAllProd.ForeColor = Color.White;
                btnDelProd.ForeColor = Color.White;
                btnEditProd.ForeColor = Color.White;
                btnProdAgo.ForeColor = Color.White;
            }
            //else
            //{
            //    //// Aplicar colores originales
            //    //this.BackColor = Color.FromArgb(255, 222, 231);
            //    //BarraHorizontal.BackColor = Color.FromArgb(255, 192, 255);
            //    //btnEditarInfo.BackColor = Color.White;
            //    //btnSaveInfo.BackColor = Color.White;
            //    //btnEditarInfo.ForeColor = Color.Black; // Revertir color de texto del botón
            //    //btnSaveInfo.ForeColor = Color.Black; // Revertir color de texto del botón
            //    //DatoPersonal.ForeColor = Color.Black; // Restaurar el color original del texto de GroupBox
            //    //DatoLaboral.ForeColor = Color.Black;
            //}
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

        private void VisualizarProducto_Load(object sender, EventArgs e)
        {
           
        }
    }
}
