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
using System.IO;



namespace DulceTentacion
{
    public partial class MenuPrincipal : Form
    {

        private Config _config;
      

        public static event Action DarkModeChanged;

        // Propiedad estática para verificar si el modo oscuro está activo
        private static bool _darkModeActive;
        public static bool DarkModeActive
        {
            get { return _darkModeActive; }
            set
            {
                if (_darkModeActive != value)
                {
                    _darkModeActive = value;
                    DarkModeChanged?.Invoke();
                }
            }
        }

        public MenuPrincipal(/*string nombreCompletoUsuario*/)
        {
            InitializeComponent();
            

           // lblUsuario.Text = nombreCompletoUsuario;
           
            LoadConfig(); // Cargar la configuración al iniciar la aplicación
            ApplyColors();//Aplicar los colores

           
            CustomizeDesign();

        }

        // Clase para manejar la configuración
        public class Config
        {
            public Color ContPrincipalColor { get; set; }
            public Color PanelMenusColor { get; set; }
         
            public Color BarraHorizontalColor { get; set; }

            public Color BarraHColor { get; set; }
            public Color ForeColorWhite { get; set; }
            public Color ForeColorBlack { get; set; }
            public bool IsDarkMode { get; set; } // Indica si el modo oscuro está activado
        }

        // Método para cargar la configuración
        private void LoadConfig()
        {
            // Si el archivo de configuración existe, cargarlo; de lo contrario, usar valores predeterminados
            if (File.Exists("config.txt"))
            {
                string[] lines = File.ReadAllLines("config.txt");
                _config = new Config
                {
                    ContPrincipalColor = ParseColor(lines[0]),
                    PanelMenusColor = ParseColor(lines[1]),
                    BarraHorizontalColor = ParseColor(lines[2]),
                    BarraHColor = ParseColor(lines[3]),
                    ForeColorWhite = ParseColor(lines[4]),
                    ForeColorBlack = ParseColor(lines[5]),
                    IsDarkMode = Convert.ToBoolean(lines[6])
                };
            }
            else
            {
                // Valores predeterminados si no hay archivo de configuración
                _config = new Config
                {
                    ContPrincipalColor = Color.FromArgb(255, 222, 231),
                    PanelMenusColor = Color.FromArgb(198, 0, 102),
                    BarraHorizontalColor = Color.FromArgb(255, 192, 255),
                    BarraHColor = Color.FromArgb(255,192,255),
                    ForeColorWhite = Color.White,
                    ForeColorBlack = Color.Black,
                    IsDarkMode = false
                };
            }

            // Actualizar la propiedad estática
            DarkModeActive = _config.IsDarkMode;
        }

        // Método para guardar la configuración
        private void SaveConfig()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{_config.ContPrincipalColor.R},{_config.ContPrincipalColor.G},{_config.ContPrincipalColor.B}");
            sb.AppendLine($"{_config.PanelMenusColor.R},{_config.PanelMenusColor.G},{_config.PanelMenusColor.B}");
            sb.AppendLine($"{_config.BarraHorizontalColor.R},{_config.BarraHorizontalColor.G},{_config.BarraHorizontalColor.B}");
            sb.AppendLine($"{_config.BarraHColor.R},{_config.BarraHColor.G},{_config.BarraHColor.B}");
            sb.AppendLine($"{_config.ForeColorWhite.R},{_config.ForeColorWhite.G},{_config.ForeColorWhite.B}");
            sb.AppendLine($"{_config.ForeColorBlack.R},{_config.ForeColorBlack.G},{_config.ForeColorBlack.B}");
            sb.AppendLine(_config.IsDarkMode.ToString());
            File.WriteAllText("config.txt", sb.ToString());
        }

        // Método para aplicar los colores
        private void ApplyColors()
        {
            this.BackColor = _config.ContPrincipalColor;
            PanelMenus.BackColor = _config.PanelMenusColor;
            BarraHorizontal.BackColor = _config.BarraHorizontalColor;
            BarraH.BackColor = _config.BarraHColor;
            ApplyForeColorToControls(this.Controls);
            ApplyButtonColors();
        }

        // Método para aplicar el color de la fuente
        private void ApplyForeColorToControls(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control.Tag != null && control.Tag.ToString() == "WhiteText")
                {
                    control.ForeColor = _config.ForeColorWhite;
                }
                else
                {
                    control.ForeColor = _config.ForeColorBlack;
                }

                if (control.HasChildren)
                {
                    ApplyForeColorToControls(control.Controls);
                }
            }
        }

        // Método para parsear un color desde una cadena
        private Color ParseColor(string colorString)
        {
            string[] rgb = colorString.Split(',');
            int r = Convert.ToInt32(rgb[0]);
            int g = Convert.ToInt32(rgb[1]);
            int b = Convert.ToInt32(rgb[2]);

            return Color.FromArgb(r, g, b );
        }



        // Método para aplicar el modo oscuro
        private void ApplyDarkMode()
        {
            this.BackColor = Color.Black;
            PanelMenus.BackColor = Color.DarkSlateGray;
            BarraHorizontal.BackColor = Color.DimGray; 
            BarraH.BackColor = Color.DimGray;
            
            ApplyDarkForeColorToControls(this.Controls); // Aplicar color de fuente en modo oscuro
            ApplyButtonColor(); // Aplicar color de botones en modo oscuro
            ApplyDarkButtonColors(); // Aplicar color de botones en modo oscuro
            // Aplicar modo oscuro a los submenús
            ApplySubMenuDarkMode(SubPanelInv);
            ApplySubMenuDarkMode(SubPanelEmp);
            ApplySubMenuDarkMode(SubPanelReg);

            DarkModeActive = true;
            _config.IsDarkMode = true;
            SaveConfig(); // Guardar la configuración actualizada
        }

        // Método para aplicar el color de la fuente en modo oscuro
        private void ApplyDarkForeColorToControls(Control.ControlCollection controls)
        {

            foreach (Control control in controls)
            {
                control.ForeColor = Color.White; // Configurar la fuente en blanco

                if (control.HasChildren)
                {
                    ApplyDarkForeColorToControls(control.Controls);
                }

            }
            
        }

        // Método para aplicar el color de los botones en modo oscuro
        private void ApplyButtonColor()
        {

            

            if (PanelMenus.BackColor == Color.DarkSlateGray)
            {
                foreach (Control control in PanelMenus.Controls)
                {
                    if (control is Button)
                    {
                        control.BackColor = Color.DarkSlateGray;
                    }
                }
            }
        }

        // Método para aplicar los colores a los botones en los paneles específicos
        private void ApplyButtonColors()
        {
            // Botones en BarraHorizontal
            btnUbicacion.BackColor = _config.BarraHorizontalColor;
            lblUsuario.BackColor = _config.BarraHorizontalColor;
            lblUbicacion.BackColor = _config.BarraHorizontalColor;
            lblDulce.BackColor = _config.BarraHorizontalColor;
            pictureBox4.BackColor = _config.BarraHorizontalColor;

            // Botones en BarraH
            btnCerrarSesion.BackColor = _config.BarraHColor;
            btnDarkMode.BackColor = _config.BarraHColor;
        }
        // Método para revertir los colores de los botones al color predeterminado de PanelMenus
        private void RevertButtonColor()
        {
            foreach (Control control in PanelMenus.Controls)
            {
                if (control is Button)
                {
                    control.BackColor = _config.PanelMenusColor;
                }
            }
            // Revertir colores de botones específicos
            ApplyButtonColors();
        }

        // Método para aplicar el modo oscuro a los submenús
        private void ApplySubMenuDarkMode(Panel subMenu)
        {
            subMenu.BackColor = Color.DarkSlateGray;
            ApplySubMenuButtonColor(subMenu);
        }

        // Método para aplicar el color de los botones en los submenús
        private void ApplySubMenuButtonColor(Panel subMenu)
        {
            foreach (Control control in subMenu.Controls)
            {
                if (control is Button)
                {
                    control.BackColor = Color.DarkSlateGray;
                }
            }
        }

        // Método para revertir el modo oscuro de los submenús
        private void RevertSubMenuColors(Panel subMenu)
        {
            subMenu.BackColor = _config.PanelMenusColor;
            RevertSubMenuButtonColor(subMenu);
        }

        // Método para revertir el color de los botones en los submenús
        private void RevertSubMenuButtonColor(Panel subMenu)
        {
            foreach (Control control in subMenu.Controls)
            {
                if (control is Button)
                {
                    control.BackColor = _config.PanelMenusColor;
                }
            }
        }
        // Método para aplicar los colores de los botones en modo oscuro
        private void ApplyDarkButtonColors()
        {
            // Botones en BarraHorizontal
            btnUbicacion.BackColor = Color.DimGray;
            lblUsuario.BackColor = Color.DimGray;
            lblUbicacion.BackColor = Color.DimGray;
            lblDulce.BackColor = Color.DimGray;
            pictureBox4.BackColor = Color.DimGray;

            // Botones en BarraH
            btnCerrarSesion.BackColor = Color.DimGray;
            btnDarkMode.BackColor = Color.DimGray;
        }



        // Método para revertir al modo original
        private void RevertColors()
        {
            LoadConfig(); // Recargar la configuración original
            ApplyColors(); // Aplicar colores originales
            RevertButtonColor(); // Revertir colores de los botones
            DarkModeActive = false;
            _config.IsDarkMode = false; // Desactivar el modo oscuro

            // Revertir el modo oscuro de los submenús
            RevertSubMenuColors(SubPanelInv);
            RevertSubMenuColors(SubPanelEmp);
            RevertSubMenuColors(SubPanelReg);

            SaveConfig(); // Guardar la configuración actualizada
        }

        private void btnDarkMode_Click(object sender, EventArgs e)
        {
            // Cambiar entre modo oscuro y modo normal
            _config.IsDarkMode = !_config.IsDarkMode;
            if (_config.IsDarkMode)
            {
                ApplyDarkMode(); // Aplicar modo oscuro
            }
            else
            {
                RevertColors(); // Revertir al modo normal
            }
            SaveConfig(); // Guardar la configuración actualizada
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

       

        private void FondoImg_MouseDown(object sender, MouseEventArgs e)
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
            abrirconprincipal(new MenuVentas());
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

       


      

        private void btnAtCliente_Click(object sender, EventArgs e)
        {
            abrirconprincipal(new AtencionCliente());
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }


        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            // Mostrar un mensaje de confirmación al usuario
            DialogResult result = MessageBox.Show("¿Está seguro de que desea cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (result == DialogResult.Yes)
            {
                // Cerrar el formulario actual (MenuPrincipal)
                this.Close();

                // Mostrar la ventana de inicio de sesión (InicioSesion)
                InicioSesion inicioSesionForm = new InicioSesion();
                inicioSesionForm.Show();
            }
        }

        private void btnUbicacion_Click(object sender, EventArgs e)
        {
            abrirconprincipal(new Ubicacion());
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {

        }
    }
}
