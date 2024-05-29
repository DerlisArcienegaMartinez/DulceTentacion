using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace DulceTentacion
{
    public partial class Ubicacion : Form
    {

        private Color originalBackColor;
        private Color originalGBOpForeColor;
        


        private double LatInicial = -17.37621;
        private double LnInicial = -66.17477;

        private double LatSucursal1 = -23.81182357844367;
        private double LnSucursal1 = -64.79536913545184;   

        private double LatSucursal2 = -13.711367059644603;
        private double LnSucursal2 = -76.2037555350819;

        private double LatSucursal3 = -26.830584345877288;
        private double LnSucursal3 = -65.19987797972422;

        public Ubicacion()
        {
            InitializeComponent();
            ApplyColors(); // Aplicar los colores al abrir el formulario
            MenuPrincipal.DarkModeChanged += ApplyColors;
        }

        // Método para aplicar colores oscuros si el modo oscuro está activo
        private void ApplyDarkModeIfNeeded()
        {
            if (MenuPrincipal.DarkModeActive)
            {
                this.BackColor = Color.Black;
                BarraHorizontal.BackColor = Color.DimGray;
                btnPrincipal.BackColor = Color.DimGray;
                btnSucursal1.BackColor = Color.DimGray;
                btnSucursal2.BackColor = Color.DimGray;
                btnSucursal3.BackColor = Color.DimGray;
                btnEnviar.BackColor = Color.DimGray;
                GBOpinionGeneral.BackColor = Color.Black;

                btnPrincipal.ForeColor = Color.White; // Configurar color de texto del botón en modo oscuro
                btnSucursal1.ForeColor = Color.White; // Configurar color de texto del botón en modo oscuro
                btnSucursal2.ForeColor = Color.White; // Cambiar el color del texto de GroupBox en modo oscuro
                btnSucursal3.ForeColor = Color.White;
                btnEnviar.ForeColor = Color.White;
                GBOpinionGeneral.ForeColor = Color.White;
            }
           
        }

        // Método para aplicar los colores al abrir el formulario
        private void ApplyColors()
        {
            // Llamar al método para aplicar el modo oscuro si es necesario
            ApplyDarkModeIfNeeded();
        }

        // Método para actualizar el estado del modo oscuro desde MenuPrincipal
        public void UpdateDarkModeState(bool isDarkMode)
        {
            MenuPrincipal.DarkModeActive = isDarkMode;
            ApplyColors();
        }

    

    private void Ubicacion_Load(object sender, EventArgs e)
        {
            MapUbi.DragButton = MouseButtons.Left;
            MapUbi.CanDragMap = true;
            MapUbi.MapProvider = GMapProviders.GoogleMap; // Establece el proveedor de mapas a "Mapa Normal"
            MapUbi.Position = new PointLatLng(LatInicial, LnInicial);
            MapUbi.MinZoom = 0;
            MapUbi.MaxZoom = 24;
            MapUbi.Zoom = 9;
            MapUbi.AutoScroll = true;


            // Crea una superposición para los marcadores
            GMapOverlay markersOverlay = new GMapOverlay("Marcadores");

            // Agrega un marcador amarillo en las coordenadas iniciales
            GMarkerGoogle yellowMarker = new GMarkerGoogle(new PointLatLng(LatInicial, LnInicial), GMarkerGoogleType.yellow);
            markersOverlay.Markers.Add(yellowMarker);

            // Agrega un marcador rojo en las coordenadas iniciales
            GMarkerGoogle redMarker = new GMarkerGoogle(new PointLatLng(LatSucursal1, LnSucursal1), GMarkerGoogleType.red);
            markersOverlay.Markers.Add(redMarker);

            // Agrega un marcador verde en las coordenadas iniciales
            GMarkerGoogle greenMarker = new GMarkerGoogle(new PointLatLng(LatSucursal2, LnSucursal2), GMarkerGoogleType.green);
            markersOverlay.Markers.Add(greenMarker);

            // Agrega un marcador celeste en las coordenadas iniciales
            GMarkerGoogle celesteMarker = new GMarkerGoogle(new PointLatLng(LatSucursal3, LnSucursal3), GMarkerGoogleType.lightblue);
            markersOverlay.Markers.Add(celesteMarker);

            // Agrega la superposición al mapa
            MapUbi.Overlays.Add(markersOverlay);
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
            ContUbicacion.Controls.Add(childForm);
            ContUbicacion.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void lblReserva_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            abrirConPrincipal(new AtencionCliente());
        }

        private void btnSucursal1_Click_1(object sender, EventArgs e)
        {
            double latitudActual = LatSucursal1;
            double longitudActual = LnSucursal1;

            // Actualiza la posición del mapa a las coordenadas deseadas
            MapUbi.Position = new PointLatLng(LatSucursal1, LnSucursal1);
        }

        private void btnPrincipal_Click_1(object sender, EventArgs e)
        {
            double latitudActual = LatInicial;
            double longitudActual = LnInicial;

            // Actualiza la posición del mapa a las coordenadas deseadas
            MapUbi.Position = new PointLatLng(LatInicial, LnInicial);
        }

        private void btnSucursal2_Click_1(object sender, EventArgs e)
        {
            double latitudActual = LatSucursal2;
            double longitudActual = LnSucursal2;

            // Actualiza la posición del mapa a las coordenadas deseadas
            MapUbi.Position = new PointLatLng(LatSucursal2, LnSucursal2);
        }

        private void btnSucursal3_Click_1(object sender, EventArgs e)
        {
            double latitudActual = LatSucursal3;
            double longitudActual = LnSucursal3;

            // Actualiza la posición del mapa a las coordenadas deseadas
            MapUbi.Position = new PointLatLng(LatSucursal3, LnSucursal3);
        }

        private void txtOpinion_MouseEnter_1(object sender, EventArgs e)
        {
            if (txtOpinion.Text == "Describe tu experiencia (opcional)")
            {
                txtOpinion.Text = "";
                txtOpinion.ForeColor = Color.Black;
            }
        }

        private void txtOpinion_Leave_1(object sender, EventArgs e)
        {
            if (txtOpinion.Text == "")
            {
                txtOpinion.Text = "Describe tu experiencia (opcional)";
                txtOpinion.ForeColor = Color.Black;
            }
        }

        private void CBModo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (CBModo.SelectedItem.ToString() == "Mapa Normal")
            {
                MapUbi.MapProvider = GMapProviders.GoogleMap;
            }
            else if (CBModo.SelectedItem.ToString() == "Mapa Satélite")
            {
                MapUbi.MapProvider = GMapProviders.GoogleSatelliteMap;
            }

            // Actualiza el mapa (si es necesario)
            MapUbi.Refresh();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
   
}
