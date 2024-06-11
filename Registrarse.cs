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
using System.IO;

namespace DulceTentacion
{

    public partial class Registro : Form
    {

        
        public Registro()
        {
            InitializeComponent();
            // Obtener y mostrar automáticamente el IDCliente al abrir el formulario
            ObtenerYMostrarIdCliente();
        }


        private void ObtenerYMostrarIdCliente()
        {
           

            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString))
            {
                try
                {
                    conn.Open();

                    // Obtener el máximo valor actual del IdCliente
                    string obtenerIdQuery = "SELECT MAX(IdCliente) FROM Usuarios";
                    SqlCommand obtenerIdCmd = new SqlCommand(obtenerIdQuery, conn);
                    object result = obtenerIdCmd.ExecuteScalar();
                    int idCliente = 0;
                    if (result != DBNull.Value && result != null)
                    {
                        idCliente = Convert.ToInt32(result);
                    }

                    // Reiniciar la identidad para que el próximo registro use el ID anterior
                    string reiniciarIdentidadQuery = $"DBCC CHECKIDENT ('Usuarios', RESEED, {idCliente})";
                    SqlCommand reiniciarIdentidadCmd = new SqlCommand(reiniciarIdentidadQuery, conn);
                    reiniciarIdentidadCmd.ExecuteNonQuery();

                    // Mostrar el último ID utilizado
                    lblIdCliente.Text = $"C-{idCliente}";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el ID del cliente: " + ex.Message);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellidoPaterno = txtApPaterno.Text;
            string apellidoMaterno = txtApMaterno.Text;
            string ci = txtCI.Text;
            string nombreUsuario = txtNomUsuario.Text;
            string contraseña = txtContraseña.Text;
            string perfilImagen = (ImgPerfil.Image != null) ? ImgPerfil.Tag.ToString() : null;




            if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Ingrese sus datos por favor");
                return;
            }

            string nombreCompleto = $"{nombre} {apellidoPaterno} {apellidoMaterno}";

      

            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString))
            {
                try
                {
                    conn.Open();
                    string verificarUsuarioQuery = "SELECT COUNT(*) FROM Usuarios WHERE CI = @CI OR NombreUsuario = @NombreUsuario";
                    SqlCommand verificarCmd = new SqlCommand(verificarUsuarioQuery, conn);
                    verificarCmd.Parameters.AddWithValue("@CI", ci);
                    verificarCmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                    int count = (int)verificarCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("CI o Nombre de Usuario ya existen.");
                        return;
                    }


                    // Instrucción INSERT
                    string insertQuery = @"INSERT INTO Usuarios 
                        (Nombre, ApellidoPaterno, ApellidoMaterno, CI, NombreUsuario, Contraseña, Perfil) 
                        VALUES 
                        (@Nombre, @ApellidoPaterno, @ApellidoMaterno, @CI, @NombreUsuario, @Contraseña, @Perfil)";

                    SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@Nombre", nombre);
                    insertCmd.Parameters.AddWithValue("@ApellidoPaterno", apellidoPaterno);
                    insertCmd.Parameters.AddWithValue("@ApellidoMaterno", apellidoMaterno);
                    insertCmd.Parameters.AddWithValue("@CI", ci);
                    insertCmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                    insertCmd.Parameters.AddWithValue("@Contraseña", contraseña);
                    insertCmd.Parameters.AddWithValue("@Perfil", perfilImagen);

                    insertCmd.ExecuteNonQuery();



                    // Obtener el ID del cliente insertado
                    string obtenerIdQuery = "SELECT SCOPE_IDENTITY()";
                    SqlCommand obtenerIdCmd = new SqlCommand(obtenerIdQuery, conn);
                    object result = obtenerIdCmd.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        int idCliente = Convert.ToInt32(result);
                        lblIdCliente.Text = $"ID Cliente: {idCliente}";
                    }
                  
                    MessageBox.Show("Usuario registrado exitosamente.");

                    // Después de insertar el usuario, mostrar el nombre completo en la ventana PanelBienvenido
                    using (InicioSesion inicio = new InicioSesion())
                    {
                        this.Hide();
                        //inicio.ShowDialog();
                    }



                    // Limpiar los campos después de registrar el producto
                    LimpiarCampos();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar usuario: " + ex.Message);
                }
            }

           
        }


        private void LimpiarCampos()
        {
            // Limpiar todos los campos de entrada
            txtNombre.Text = "";
            txtApPaterno.Text = "";
            txtApMaterno.Text = "";
            txtCI.Text = "";
            txtNomUsuario.Text = "";
            txtContraseña.Text = "";
            ImgPerfil.Image = null;
            ImgPerfil.Tag = null; // Limpiar el tag
        }
        private void GBCuenta_Enter(object sender, EventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelectFoto_Click(object sender, EventArgs e)
        {
            // Mostrar la ventana de selección de foto
            using (SeleccionFoto foto = new SeleccionFoto())
            {
                foto.ShowDialog();

                // Verificar si el usuario seleccionó una imagen y la asignó al PictureBox
                if (foto.ImagenSeleccionada != null)
                {
                    // Asignar la imagen seleccionada al PictureBox ImgPerfil
                    ImgPerfil.Image = foto.ImagenSeleccionada;
                    ImgPerfil.Tag = foto.ImagenSeleccionadaNombre; // Asignar el nombre de la imagen

                }
            }


        }
    }
    
}






