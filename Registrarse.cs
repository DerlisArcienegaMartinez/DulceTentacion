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
            //using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString))
            //{
            //    try
            //    {
            //        conn.Open();

            //        string obtenerIdQuery = "SELECT IDENT_CURRENT('Usuarios')";
            //        SqlCommand obtenerIdCmd = new SqlCommand(obtenerIdQuery, conn);
            //        object result = obtenerIdCmd.ExecuteScalar();
            //        if (result != DBNull.Value && result != null)
            //        {
            //            int idCliente = Convert.ToInt32(result) + 1;
            //            lblIdCliente.Text = $"C-{idCliente}";
            //        }

            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Error al obtener el ID del cliente: " + ex.Message);
            //    }
            //}

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
            string cu = txtCU.Text;
            string FechaNacimiento = txtFecNacimiento.Text;
            string Edad = txtEdad.Text;
            string genero = CBGenero.SelectedItem.ToString();
            string telefono = txtTelefono.Text;
            string celular = txtCelular.Text;
            string direccionDomicilio = txtDomicilio.Text;
            string correoElectronico = txtCorreo.Text + CBCorreos.SelectedItem.ToString();
            string nombreUsuario = txtNomUsuario.Text;
            string contraseña = txtContraseña.Text;

            if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrecta");
                return;
            }

            string nombreCompleto = $"{nombre} {apellidoPaterno} {apellidoMaterno}";

            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString))
            {
                try
                {
                    conn.Open();
                    string verificarUsuarioQuery = "SELECT COUNT(*) FROM Usuarios WHERE CU = @CU OR NombreUsuario = @NombreUsuario";
                    SqlCommand verificarCmd = new SqlCommand(verificarUsuarioQuery, conn);
                    verificarCmd.Parameters.AddWithValue("@CU", cu);
                    verificarCmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                    int count = (int)verificarCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("CU o Nombre de Usuario ya existen.");
                        return;
                    }

                    string query = "INSERT INTO Usuarios (Nombre, ApellidoPaterno, ApellidoMaterno, CU, FecNacimiento, Edad, Genero, Telefono, Celular, DireccionDomicilio, CorreoElectronico, NombreUsuario, Contraseña) " +
                                   "VALUES (@Nombre, @ApellidoPaterno, @ApellidoMaterno, @CU, @FechaNacimiento, @Edad, @Genero, @Telefono, @Celular, @DireccionDomicilio, @CorreoElectronico, @NombreUsuario, @Contraseña)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@ApellidoPaterno", apellidoPaterno);
                    cmd.Parameters.AddWithValue("@ApellidoMaterno", apellidoMaterno);
                    cmd.Parameters.AddWithValue("@CU", cu);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento);
                    cmd.Parameters.AddWithValue("@Edad", Edad);
                    cmd.Parameters.AddWithValue("@Genero", genero);
                    cmd.Parameters.AddWithValue("@Telefono", telefono);
                    cmd.Parameters.AddWithValue("@Celular", celular);
                    cmd.Parameters.AddWithValue("@DireccionDomicilio", direccionDomicilio);
                    cmd.Parameters.AddWithValue("@CorreoElectronico", correoElectronico);
                    cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                    cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                    cmd.ExecuteNonQuery();



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
                        inicio.ShowDialog();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar usuario: " + ex.Message);
                }
            }
        }

        private void GBCuenta_Enter(object sender, EventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {
            CBGenero.Items.Add("Masculino");
            CBGenero.Items.Add("Femenino");

            CBCorreos.Items.Add("@gmail.com");
            CBCorreos.Items.Add("@hotmail.com");
            CBCorreos.Items.Add("@yahoo.com");
            CBCorreos.Items.Add("@outlook.com");
            CBCorreos.Items.Add("@usfx.bo");
            CBCorreos.Items.Add("@¡cloud.com");
        }
    }
    
}
