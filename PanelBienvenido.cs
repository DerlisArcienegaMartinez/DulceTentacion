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
    public partial class PanelBienvenido : Form
    {
        public string NombreCompletoUsuario { get; private set; }

        public PanelBienvenido(string nombreCompletoUsuario)
        {
            InitializeComponent();
            lblUsuario.Text = nombreCompletoUsuario;
            NombreCompletoUsuario = nombreCompletoUsuario;
        }



        private void PanelBienvenido_Load(object sender, EventArgs e)
        {
            

            this.Opacity = 0.0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            BarraProgreso.Value += 1;
            if (BarraProgreso.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;

            if (this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();

                // Mostrar MenuPrincipal después de cerrar PanelBienvenido
                using (MenuPrincipal menuPrincipal = new MenuPrincipal(NombreCompletoUsuario))
                    menuPrincipal.ShowDialog();
            }
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
