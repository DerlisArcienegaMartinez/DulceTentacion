using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DulceTentacion
{
    public partial class InicioSesion : Form
    {

        

      

        private int intentosFallidos = 0;
        private Timer timer;

        public InicioSesion()
        {
            InitializeComponent();

            //temporizador
            timer = new Timer();
            timer.Interval = 10000; //10 segundos
            timer.Tick += Timer_Tick;

            // Suscribir el evento CheckedChanged al checkbox
            btnMtContra.CheckedChanged += btnMtContra_CheckedChanged;
        }

        
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private string ObtenerNombreCompletoUsuario()
        {
            string nombreCompleto = "";

            // Aquí debes realizar la conexión a tu base de datos y ejecutar una consulta SQL
            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Nombre, ApellidoPaterno, ApellidoMaterno FROM Usuarios WHERE NombreUsuario = @NombreUsuario";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@NombreUsuario", txtUsuario.Text); // Puedes utilizar el nombre de usuario ingresado en el campo de texto

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        // Construir el nombre completo utilizando los datos obtenidos de la base de datos
                        nombreCompleto = $"{reader["Nombre"]} {reader["ApellidoPaterno"]} {reader["ApellidoMaterno"]}";
                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado en la base de datos.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el nombre completo del usuario: " + ex.Message);
                }
            }

            return nombreCompleto;
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario
            {
                NombreUsuario = txtUsuario.Text,
                Contraseña = txtContraseña.Text
            };
        
            if (usuario.NombreUsuario == "administrador" && usuario.Contraseña == "1234")
            {
                // Si las credenciales son del administrador, mostrar el PanelBienvenido con el nombre "Administrador"
                using (PanelBienvenido Bienvenido = new PanelBienvenido("Administrador"))
                {
                    this.Hide();
                    Bienvenido.ShowDialog();

                    // Puedes agregar aquí la lógica adicional para el menú principal si es necesario
                    using (MenuPrincipal menuPrincipal = new MenuPrincipal(Bienvenido.NombreCompletoUsuario))
                        menuPrincipal.ShowDialog();
                }
            }
            else
            {

                using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "SELECT COUNT(*) FROM Usuarios WHERE NombreUsuario = @NombreUsuario AND Contraseña = @Contraseña";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
                        cmd.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);

                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {

                            // Después de validar las credenciales del usuario y antes de mostrar el formulario PanelBienvenido
                            string nombreCompleto = ObtenerNombreCompletoUsuario(); // Aquí debes obtener el nombre completo del usuario, por ejemplo, desde la base de datos

                            using (PanelBienvenido Bienvenido = new PanelBienvenido(nombreCompleto))
                            {
                                this.Hide();
                                Bienvenido.ShowDialog();

                                using (MenuPrincipal menuPrincipal = new MenuPrincipal(Bienvenido.NombreCompletoUsuario))
                                    menuPrincipal.ShowDialog();
                            }
                        }

                        else
                        {
                            intentosFallidos++;
                            if (intentosFallidos == 1)
                            {
                                MessageBox.Show("Nombre de usuario o contraseña incorrectos. Le quedan 2 intentos.");
                            }
                            else if (intentosFallidos == 2)
                            {
                                MessageBox.Show("Nombre de usuario o contraseña incorrectos. Último intento.");
                            }
                            else if (intentosFallidos >= 3)
                            {
                                MessageBox.Show("Nombre de usuario o contraseña incorrectos. Espere 30 segundos.");
                                btnAcceder.Enabled = false;
                                timer.Start();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al intentar iniciar sesión: " + ex.Message);
                    }
                }
            }
        }




        private void Timer_Tick(object sender, EventArgs e)
        {
            btnAcceder.Enabled = true;
            intentosFallidos = 0;
            timer.Stop();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (Registro registro = new Registro())
                registro.ShowDialog(); //mantiene abierta la ventana menu
        }

        private void btnMtContra_CheckedChanged(object sender, EventArgs e)
        {
            // Verificar si el checkbox está marcado
            if (btnMtContra.Checked)
            {
                // Si está marcado, mostrar la contraseña
                txtContraseña.UseSystemPasswordChar = false; // Mostrar caracteres
            }
            else
            {
                // Si no está marcado, ocultar la contraseña
                txtContraseña.UseSystemPasswordChar = true; // Ocultar caracteres
            }
        }
    }
}
