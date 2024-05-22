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
    public partial class Configuracion : Form
    {

        


        public Configuracion()
        {
            InitializeComponent();

            
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
            pnlConfig.Controls.Add(childForm);
            pnlConfig.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

       

      

        

        private void btnModOscuro_Click(object sender, EventArgs e)
        {
          
        }

        private void btnModClaro_Click(object sender, EventArgs e)
        {
            


        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void lnkCuenta_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            abrirConPrincipal(new CuentaUsuario());
        }

        
    }
}
