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
    public partial class Carrito : Form
    {
        
        public Carrito()
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
                BarraHorizontal.BackColor = Color.DimGray;
                pnlDPersonal.BackColor = Color.Black;
                pnlDRecojo.BackColor = Color.Black;
                pnlFPago.BackColor = Color.Black;
                btnCancelar.BackColor = Color.DimGray;
                btnMas.BackColor = Color.DimGray;
                btnEnviar.BackColor = Color.DimGray;
                btnQR.BackColor = Color.DimGray;
                btnEfectivo.BackColor = Color.DimGray;
                btnTarjeta.BackColor = Color.DimGray;
                pnlCesta.BackColor = Color.DimGray;

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

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se enviaron correctamente su pedido, se le mandara un mensaje cuando este listo para su entrega ");
            this.Close();
        }

        private void btnEfectivo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancele en caja por favor");

        }

        private void btnQR_Click(object sender, EventArgs e)
        {
            using (QR qr = new QR())
                qr.ShowDialog();
        }

        private void btnTarjeta_Click(object sender, EventArgs e)
        {
            using (Tarjeta tarjeta = new Tarjeta())
                tarjeta.ShowDialog();
        }
    }
}
