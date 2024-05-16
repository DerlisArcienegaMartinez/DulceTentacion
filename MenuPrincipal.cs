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


        //Configurar el boton Desplegable
        private void btnDesplegable_Click(object sender, EventArgs e)
        {
            if (PanelMenus.Width == 235)
            {
                PanelMenus.Width = 62;
            }
            else
                PanelMenus.Width = 235;
        }

//configurar el movimiento de la ventana
        private void PanelMenus_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ContPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void CustomizeDesign()
        {
            SubPanelInv.Visible = false;
            SubPanelEmp.Visible = false;
            SubPanelReg.Visible = false;
        }

        private void hideSubMenu()
        {
            if (SubPanelInv.Visible == true)
                SubPanelInv.Visible = false;
            if (SubPanelEmp.Visible == true)
                SubPanelEmp.Visible = false;
            if (SubPanelReg.Visible == true)
                SubPanelReg.Visible = false;
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
            showSubMenu(SubPanelInv);
        }

        private void btnRegistros_Click(object sender, EventArgs e)
        {
            showSubMenu(SubPanelReg);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            showSubMenu(SubPanelEmp);
        }



        private void btnIngresarProd_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnVisualizarProd_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnAlmacInf_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnAlmcFacturas_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnRegPersonal_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnGenContratos_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnMenuVentas_Click(object sender, EventArgs e)
        {
            abrirconprincipal(new Ventas());
        }


        //configurar la ventana en el panel contenedor
        private Form activeform = null;
        private void abrirconprincipal(Form childform)
        {
            if (activeform != null)
                activeform.Close();
            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            ContPrincipal.Controls.Add(childform);
            ContPrincipal.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }













    }
}
