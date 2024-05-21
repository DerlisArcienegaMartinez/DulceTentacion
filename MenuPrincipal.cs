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

        private bool isDarkMode = false;
        private Dictionary<Control, (Color BackColor, Color ForeColor)> originalColors;


        public MenuPrincipal()
        {
            InitializeComponent();   
            CustomizeDesign();
            originalColors = new Dictionary<Control, (Color, Color)>();

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
            abrirconprincipal(new RegistrarProducto());
            hideSubMenu();
        }

        private void btnVisualizarProd_Click(object sender, EventArgs e)
        {
            abrirconprincipal(new VisualizarProducto());
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
            abrirconprincipal(new RegistrarPersonal());
            hideSubMenu();
        }

        private void btnGenContratos_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnMenuVentas_Click(object sender, EventArgs e)
        {
            abrirconprincipal(new Ventas(isDarkMode));
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
            ApplyDarkMode(childform.Controls, isDarkMode);
        }

        // Método para aplicar el modo oscuro o claro a todos los controles
        private void ApplyDarkMode(Control.ControlCollection controls, bool darkMode)
        {
            foreach (Control control in controls)
            {
                if (darkMode)
                {
                    if (!originalColors.ContainsKey(control))
                    {
                        originalColors[control] = (control.BackColor, control.ForeColor);
                    }
                    control.BackColor = Color.Black;
                    control.ForeColor = Color.White;
                }
                else
                {
                    if (originalColors.ContainsKey(control))
                    {
                        control.BackColor = originalColors[control].BackColor;
                        control.ForeColor = originalColors[control].ForeColor;
                    }
                    //control.BackColor = SystemColors.Control;
                    //control.ForeColor = SystemColors.ControlText;
                }

                // Recursivamente aplicar a los controles hijos
                if (control.HasChildren)
                {
                    ApplyDarkMode(control.Controls, darkMode);
                }
            }
        }

        // Método público para alternar el modo oscuro
        public void SetDarkMode(bool darkMode)
        {
            isDarkMode = darkMode;
            ApplyDarkMode(this.Controls, isDarkMode);

            // Aplicar a todas las ventanas abiertas
            foreach (Form form in Application.OpenForms)
            {
                ApplyDarkMode(form.Controls, isDarkMode);
            }
        }


        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            //abrirconprincipal(new Configuracion());
            Configuracion configuracionForm = new Configuracion(this, isDarkMode);
            abrirconprincipal(configuracionForm);
        }

        private void btnAtCliente_Click(object sender, EventArgs e)
        {
            abrirconprincipal(new AtencionCliente());
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnImgUsuario_Click(object sender, EventArgs e)
        {
            abrirconprincipal(new CuentaUsuario());
        }
    }
}
