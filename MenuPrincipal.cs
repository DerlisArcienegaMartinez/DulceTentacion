using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DulceTentacion
{
    public partial class MenuPrincipal : Form
    {


        public MenuPrincipal()
        {
            InitializeComponent();

            CustomizeDesign();
        }

        //mover la ventana actual
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        //configurar el boton salir para cerrar la aplicacion
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //configurar el boton minimizar ventana
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //configurar el boton maximizar ventana
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        //configurar el boton restaurar ventana
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        //configurar el movimiento de la ventana
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void MenuPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void PanelContenedor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }



        //configurar el boton desplegable 
        private void btnMenuDesplegable_Click(object sender, EventArgs e)
        {
            if (PanelMenus.Width == 235)
            {
                PanelMenus.Width = 60;
            }
            else
                PanelMenus.Width = 235;

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
            ContPrincipal.Controls.Add(childForm);
            ContPrincipal.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        //configurar el boton de ventas
        private void btnVentas_Click(object sender, EventArgs e)
        {
            abrirConPrincipal(new Ventas());
        }

        //configurar la funcion del menu principal
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        //Funcion para deslizar el submenu de opciones de cada boton
        private void CustomizeDesign()
        {
            SubPanelInventario.Visible = false;
            SubPanelRegistro.Visible = false;
            SubPanelPersonal.Visible = false;
        }

        private void hideSubMenu()
        {

            if (SubPanelInventario.Visible)
                SubPanelInventario.Visible = false;
            if (SubPanelRegistro.Visible)
                SubPanelRegistro.Visible = false;
            if (SubPanelPersonal.Visible)
                SubPanelPersonal.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void btnInventario_Click(object sender, EventArgs e)
        {
            
            showSubMenu(SubPanelInventario);
        }

        private void btnRegistroVentas_Click(object sender, EventArgs e)
        {
           
            showSubMenu(SubPanelRegistro);
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
           
            showSubMenu(SubPanelPersonal);
        }

        private void btnIngresarInventario_Click(object sender, EventArgs e)
        {
            abrirConPrincipal(new RegistrarProducto());
            hideSubMenu();
        }

        private void btnVisualizarInventario_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnRegistrarCompra_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnRegistroPersonal_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnGenerarContrato_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void ContPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
