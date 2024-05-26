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
    public partial class SeleccionFoto : Form
    {

        Bitmap[] imagenes = { Properties.Resources.Avatar_Niño, Properties.Resources.Avatar_Joven, Properties.Resources.Avatar_Niño_2, Properties.Resources.Avatar_adulto, Properties.Resources.Avatar_Señor_1, Properties.Resources.Avatar_Señor,
        Properties.Resources.Avatar_Viejo___1_, Properties.Resources.Avatar_Viejito_feliz__1_, Properties.Resources.Avatar_Viejito2,
        Properties.Resources.Avatar_Niña,Properties.Resources.Avatar_niña_1, Properties.Resources.Avatar_mujer_1, Properties.Resources.Avatar_mujer3, Properties.Resources.Avatar_Mujer, Properties.Resources.Avatar_Señora,
        Properties.Resources.Avatar_Viejita, Properties.Resources.Avatar_Viejita1, Properties.Resources.Avatar_Viejita_1__1_};
        int indiceCentral = 0;
        int indiceIzquierda;
        int indiceDerecha;

        public SeleccionFoto()
        {
            InitializeComponent();

            // Configuramos los índices iniciales
            indiceCentral = 0;
            indiceIzquierda = imagenes.Length - 1;
            indiceDerecha = 1;

            // Mostramos las imágenes iniciales
            MostrarImagenes();
        }

        // Método para mostrar las imágenes
        void MostrarImagenes()
        {
            pictureBoxIzquierda.Image = imagenes[indiceIzquierda];
            pictureBoxCentral.Image = imagenes[indiceCentral];
            pictureBoxDerecha.Image = imagenes[indiceDerecha];

        }

        // Método para avanzar en el carrusel
        void Avanzar()
        {
            indiceIzquierda = indiceCentral;
            indiceCentral = indiceDerecha;
            indiceDerecha++;

            // Si llegamos al final del arreglo, volvemos al principio
            if (indiceDerecha >= imagenes.Length)
                indiceDerecha = 0;

            MostrarImagenes();
        }

        // Método para retroceder en el carrusel
        void Retroceder()
        {
            indiceDerecha = indiceCentral;
            indiceCentral = indiceIzquierda;

            // Restar 1 al índiceIzquierda y ajustar si se sale del límite inferior
            indiceIzquierda--;

            // Si el índiceIzquierda se vuelve negativo, ajustarlo al índice más alto
            if (indiceIzquierda < 0)
                indiceIzquierda = imagenes.Length - 1;

            MostrarImagenes();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Avanzar();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            Retroceder();
        }

       

        
    }
}
