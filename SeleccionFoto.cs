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



    public partial class SeleccionFoto : Form
    {
        // Declarar una propiedad para almacenar la imagen seleccionada
        public Bitmap ImagenSeleccionada { get; private set; }
        public string ImagenSeleccionadaNombre { get; private set; }

        //Bitmap[] imagenes = { Properties.Resources.Avatar_Niño, Properties.Resources.Avatar_Joven, Properties.Resources.Avatar_Niño_2, Properties.Resources.Avatar_adulto, Properties.Resources.Avatar_Señor_1, Properties.Resources.Avatar_Señor,
        //Properties.Resources.Avatar_Viejo___1_, Properties.Resources.Avatar_Viejito_feliz__1_, Properties.Resources.Avatar_Viejito2,
        //Properties.Resources.Avatar_Niña,Properties.Resources.Avatar_niña_1, Properties.Resources.Avatar_mujer_1, Properties.Resources.Avatar_mujer3, Properties.Resources.Avatar_Mujer, Properties.Resources.Avatar_Señora,
        //Properties.Resources.Avatar_Viejita, Properties.Resources.Avatar_Viejita1, Properties.Resources.Avatar_Viejita_1__1_};
        //int indiceCentral = 0;
        //int indiceIzquierda;
        //int indiceDerecha;

        private readonly Bitmap[] imagenes =
        {
            Properties.Resources.Avatar_Niño, Properties.Resources.Avatar_Joven, Properties.Resources.Avatar_Niño_2,
            Properties.Resources.Avatar_adulto, Properties.Resources.Avatar_Señor_1, Properties.Resources.Avatar_Señor,
            Properties.Resources.Avatar_Viejo___1_, Properties.Resources.Avatar_Viejito_feliz__1_, Properties.Resources.Avatar_Viejito2,
            Properties.Resources.Avatar_Niña, Properties.Resources.Avatar_niña_1, Properties.Resources.Avatar_mujer_1,
            Properties.Resources.Avatar_mujer3, Properties.Resources.Avatar_Mujer, Properties.Resources.Avatar_Señora,
            Properties.Resources.Avatar_Viejita, Properties.Resources.Avatar_Viejita1, Properties.Resources.Avatar_Viejita_1__1_
        };

        private readonly string[] nombres =
        {
            "Avatar_Niño.png", "Avatar_Joven.png", "Avatar_Niño_2.png",
            "Avatar_adulto.png", "Avatar_Señor_1.png", "Avatar_Señor.png",
            "Avatar_Viejo_1.png", "Avatar_Viejito_feliz_1.png", "Avatar_Viejito2.png",
            "Avatar_Niña.png", "Avatar_niña_1.png", "Avatar_mujer_1.png",
            "Avatar_mujer3.png", "Avatar_Mujer.png", "Avatar_Señora.png",
            "Avatar_Viejita.png", "Avatar_Viejita1.png", "Avatar_Viejita_1_1.png"
        };

        private int indiceCentral;
        private int indiceIzquierda;
        private int indiceDerecha;

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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Obtener la imagen del PictureBox central
            ImagenSeleccionada = imagenes[indiceCentral];
            ImagenSeleccionadaNombre = nombres[indiceCentral];

            // Cerrar la ventana de selección de foto
            this.Close();
        }
    }
}
