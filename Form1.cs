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
    public partial class Form1 : Form
    {

        public class Usuario
        {
            public string NombreUsuario { get; set; }
            public string Contraseña { get; set; }
        }

        private int intentosFallidos = 0;
        private Timer timer;

        public Form1()
        {
            InitializeComponent();

            //temporizador
            timer = new Timer();
            timer.Interval = 10000; //10 segundos
            timer.Tick += Timer_Tick;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.NombreUsuario = txtUsuario.Text;
            usuario.Contraseña = txtContraseña.Text;

            string nombreusuario1 = "usuario1";
            string contraseñausuario1 = "1234";

            string nombreusuario2 = "usuario2";
            string contraseñausuario2 = "12356";



            if ((usuario.NombreUsuario == nombreusuario1 && usuario.Contraseña == contraseñausuario1) ||
                (usuario.NombreUsuario == nombreusuario2 && usuario.Contraseña == contraseñausuario2))
            {
                MessageBox.Show("Inicio de Sesión Exitoso! Bienvenido.");

                //Al clickear btnIngresar abre la pestaña de Menu
                using (PanelBienvenido bienvenido = new PanelBienvenido())
                    bienvenido.ShowDialog(); //mantiene abierta la ventana menu

            }
            else
            {
                MessageBox.Show("Nombre de Usuario o Contraseña Incorrectos. Por Favor, Intentalo de Nuevo.");
                intentosFallidos++;


                if (intentosFallidos == 1)
                {
                    MessageBox.Show("Le Quedan 2 Intentos para ingresar correctamente sus datos");
                }
                else if (intentosFallidos == 2)
                {
                    MessageBox.Show("Último Intento para ingresar correctamente sus datos");
                }
                else if (intentosFallidos >= 3)
                {
                    MessageBox.Show("Espere 30 segundos para Intentarlo Nuevamente");
                    btnAcceder.Enabled = false;

                    timer.Start();

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
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
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
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }
    }
}
