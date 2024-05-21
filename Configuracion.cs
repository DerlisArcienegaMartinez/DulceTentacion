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

        private MenuPrincipal menuPrincipal;
        protected bool isDarkMode;
        private Dictionary<Control, (Color BackColor, Color ForeColor)> originalColors;


        public Configuracion(MenuPrincipal menuPrincipal, bool isDarkMode)
        {
            InitializeComponent();

            this.menuPrincipal = menuPrincipal;
            this.isDarkMode = isDarkMode;
            originalColors = new Dictionary<Control, (Color, Color)>();
            ApplyDarkMode(this.Controls, isDarkMode);
            UpdateAppearance(); // Agregamos la llamada a esta función para actualizar la apariencia inicial
            UpdateButtonStates();
        }

        private void UpdateAppearance()
        {
            ApplyDarkMode(this.Controls, isDarkMode); // Aplicamos el modo oscuro a los controles de esta ventana
        }

        private void UpdateButtonStates()
        {
            btnModOscuro.Enabled = !isDarkMode;
            btnModClaro.Enabled = isDarkMode;
        }

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
                }

                if (control.HasChildren)
                {
                    ApplyDarkMode(control.Controls, darkMode);
                }
            }
        }

        private void btnModOscuro_Click(object sender, EventArgs e)
        {
            isDarkMode = true;
            menuPrincipal.SetDarkMode(isDarkMode);
            ApplyDarkMode(this.Controls, isDarkMode);
            UpdateAppearance(); // Actualizamos la apariencia después de cambiar a modo oscuro
            UpdateButtonStates();
        }

        private void btnModClaro_Click(object sender, EventArgs e)
        {
            isDarkMode = false;
            menuPrincipal.SetDarkMode(isDarkMode);
            ApplyDarkMode(this.Controls, isDarkMode);
            UpdateAppearance(); // Actualizamos la apariencia después de cambiar a modo claro
            UpdateButtonStates();


        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
