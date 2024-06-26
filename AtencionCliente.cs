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
    public partial class AtencionCliente : Form
    {


        public AtencionCliente()
        {
            InitializeComponent();
            ApplyColors(); // Aplicar los colores al abrir el formulario
            MenuPrincipal.DarkModeChanged += ApplyColors;
        }

        //Configurar la ventana en el panel contenedor
        private Form activeForm = null;
        private void abrirConPrincipal(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            // Deshabilitar AutoScroll del contenedor antes de agregar el nuevo formulario
            contAtCliente.AutoScroll = false;


            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            contAtCliente.Controls.Add(childForm);
            contAtCliente.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            // Suscribirse al evento FormClosed del formulario hijo
            childForm.FormClosed += ChildForm_FormClosed;
        }

        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Volver a habilitar el AutoScroll del contenedor después de cerrar el formulario hijo
            contAtCliente.AutoScroll = true;
        }


   //MODO OSCURO            *************************
        // Método para aplicar colores oscuros si el modo oscuro está activo
        private void ApplyDarkModeIfNeeded()
        {
            if (MenuPrincipal.DarkModeActive)
            {
                this.BackColor = Color.Black;
                BarraHorizontal.BackColor = Color.DimGray;
                btnPasteles.BackColor = Color.DimGray;
                btnTPersonal.BackColor = Color.DimGray;
                btnBebidas.BackColor = Color.DimGray;
                btnPorciones.BackColor = Color.DimGray;
                btnCancelar.BackColor = Color.DimGray;
                btnEnviar.BackColor = Color.DimGray;
                btnMesas.BackColor = Color.DimGray;
                pnlAtender.BackColor = Color.Black;
                pnlPersonalizar.BackColor = Color.Black;
                pnlProdSelect.BackColor = Color.Black;

                btnPasteles.ForeColor = Color.White;
                btnTPersonal.ForeColor = Color.White;
                btnBebidas.ForeColor = Color.White;
                btnPorciones.ForeColor = Color. White;
                btnCancelar.ForeColor = Color.  White;
                btnEnviar.ForeColor = Color.White;
                btnMesas.ForeColor = Color.White;
                pnlPersonalizar.ForeColor = Color.White;
                PR1.BackColor = Color.LightCyan;
                PR2.BackColor = Color.LightCyan;
                PR3.BackColor = Color.LightCyan;
                PR4.BackColor = Color.LightCyan;
            }
            
        }

        // Método para aplicar los colores al abrir el formulario
        private void ApplyColors()
        {
            // Llamar al método para aplicar el modo oscuro si es necesario
            ApplyDarkModeIfNeeded();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPasteles_Click(object sender, EventArgs e)
        {   
            abrirConPrincipal(new Pasteles());  
        }

        private void btnPorciones_Click(object sender, EventArgs e)
        {
            abrirConPrincipal(new Porciones());
        }

        private void btnTPersonal_Click(object sender, EventArgs e)
        {
            abrirConPrincipal(new PastelPersonalizado());
        }

        private void btnBebidas_Click(object sender, EventArgs e)
        {
            abrirConPrincipal(new Bebidas());
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Su reservación fue registrado exitosamente.");
        }
    }
}
