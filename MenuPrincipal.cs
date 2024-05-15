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
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

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

        private void btnMenuDesplegable_Click(object sender, EventArgs e)
        {
            if (PanelMenus.Width == 245)
            {
                PanelMenus.Width = 65;
            }
            else
                PanelMenus.Width = 245;

        }

        private void PanelContenedor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

      

        private void btnVentas_Click(object sender, EventArgs e)
        {
            showSubMenu(SubPanelVentas); 
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }


        private void customizeDesing()
        {
            SubPanelVentas.Visible = false;
            SubPanelInventario.Visible = false;
            SubPanelRegistro.Visible = false;
            SubPanelPersonal.Visible = false;
        }

        private void hideSubMenu()
        {
            if (SubPanelVentas.Visible == true)
                SubPanelVentas.Visible = false;
            if (SubPanelInventario.Visible == true)
                SubPanelInventario.Visible = false;
            if (SubPanelRegistro.Visible == true)
                SubPanelRegistro.Visible = false;
            if (SubPanelPersonal.Visible == true)
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

        private void btnIngresarProducto_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnVisualizarProducto_Click(object sender, EventArgs e)
        {
            hideSubMenu();
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
    }
}
