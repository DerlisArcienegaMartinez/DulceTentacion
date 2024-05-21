﻿using System;
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
    public partial class Ventas : Form
    {

       
        private bool isDarkMode;
        private Dictionary<Control, (Color BackColor, Color ForeColor)> originalColors;


        public Ventas( bool darkMode)
        {
            InitializeComponent();
            isDarkMode = darkMode;
            originalColors = new Dictionary<Control, (Color, Color)>();
            ApplyDarkMode(this.Controls, isDarkMode);
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
            ContVentas.Controls.Add(childForm);
            ContVentas.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
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

        private void btnPasteles_Click(object sender, EventArgs e)
        {
            abrirConPrincipal(new Pasteles());
        }

        private void fndPasteles_Click(object sender, EventArgs e)
        {
            abrirConPrincipal(new Pasteles());
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
