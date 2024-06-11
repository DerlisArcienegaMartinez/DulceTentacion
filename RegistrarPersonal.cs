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
    public partial class RegistrarPersonal : Form
    {
        public RegistrarPersonal()
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
                btnAdministrador.BackColor = Color.DimGray;
                btnCancelar.BackColor = Color.DimGray;
                btnChef.BackColor = Color.DimGray;
                btnClientes.BackColor = Color.DimGray;
                btnGerente.BackColor = Color.DimGray;
                btnLimpieza.BackColor = Color.DimGray;
                btnMesero.BackColor = Color.DimGray;
                btnRegistrar.BackColor = Color.DimGray;
                btnRepartidor.BackColor = Color.DimGray;
                pnlContrato.BackColor = Color.Black;
                pnlDatos.BackColor = Color.Black;
                pnlOpcional.BackColor = Color.Black;

                pnlDatos.ForeColor = Color.White;
            }

        }

        // Método para aplicar los colores al abrir el formulario
        private void ApplyColors()
        {
            // Llamar al método para aplicar el modo oscuro si es necesario
            ApplyDarkModeIfNeeded();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string ci = txtCI.Text;
            string nombre = txtNombre.Text;
            string apellidoPaterno = txtApPaterno.Text;
            string apellidoMaterno = txtApMaterno.Text;
            string nombreUsuario = txtNomUsuario.Text;
            string contraseña = txtContraseña.Text;
            string celular = txtCelular.Text;
            string direccion = txtDireccion.Text;
            string correo = txtCorreo.Text;
            string correoC = CBCorreos.Text;
            string genero = txtGenero.Text;
            string puesto = txtPuesto.Text;
            string horaIn = txtHoraIn.Text;
            string horaEx = txtHoraS.Text;
            string fechain = txtInicio.Text;
            string fechaEx = txtFin.Text;
            string salario = txtSalario.Text;
            string movilidad = txtMovilidad.Text;
            string licencia = txtLicencia.Text;
            string numLicencia = txtNLicencia.Text;
            string numMatricula = txtNMatricula.Text;
            string descripcion = txtDescripcion.Text;

            if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Ingrese sus datos por favor");
                return;
            }

            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MiRegistro"].ConnectionString))
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
                (CI, Nombres, ApellidoPaterno, ApellidoMaterno, Celular, CBGenero, Direccion, CorreoElectronico, CBCorreo, CBPuesto, HoraEntrada,
                   HoraSalida, InicioContrato, FinContrato, Salario, NombreUsuario, Contraseña, CBMovilidad, CBLicencia, NLicencia, NMatricula, Descripcion) 
                        VALUES 
                  (@CI, @Nombres, @ApellidoPaterno, @ApellidoMaterno, @Celular, @CBGenero, @Direccion, @CorreoElectronico, @CBCorreo, @CBPuesto, @HoraEntrada,
                      @HoraSalida, @InicioContrato, @FinContrato, @Salario, @NombreUsuario, @Contraseña, @CBMovilidad, @CBLicencia, @NLicencia, @NMatricula, @Descripcion)";

                    SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@Nombre", nombre);
                    insertCmd.Parameters.AddWithValue("@ApellidoPaterno", apellidoPaterno);
                    insertCmd.Parameters.AddWithValue("@ApellidoMaterno", apellidoMaterno);
                    insertCmd.Parameters.AddWithValue("@CI", ci);
                    insertCmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                    insertCmd.Parameters.AddWithValue("@Contraseña", contraseña);
                    insertCmd.Parameters.AddWithValue("@Celular", celular);
                    insertCmd.Parameters.AddWithValue("@CBGenero", genero);
                    insertCmd.Parameters.AddWithValue("@Direccion", direccion);
                    insertCmd.Parameters.AddWithValue("@CorreoElectronico", correo);
                    insertCmd.Parameters.AddWithValue("@CBCorreo", correoC);
                    insertCmd.Parameters.AddWithValue("@CBPuesto", puesto);
                    insertCmd.Parameters.AddWithValue("@HoraEntrada", horaIn);
                    insertCmd.Parameters.AddWithValue("@HoraSalida", horaEx);
                    insertCmd.Parameters.AddWithValue("@InicioContrato", fechain);
                    insertCmd.Parameters.AddWithValue("@FinContrato", fechaEx);
                    insertCmd.Parameters.AddWithValue("@Salario", salario);
                    insertCmd.Parameters.AddWithValue("@CBMovilidad", movilidad);
                    insertCmd.Parameters.AddWithValue("@CBLicencia", licencia);
                    insertCmd.Parameters.AddWithValue("@NLicencia", numLicencia);
                    insertCmd.Parameters.AddWithValue("@NMatricula", numMatricula);
                    insertCmd.Parameters.AddWithValue("@Descripcion", descripcion);

                    insertCmd.ExecuteNonQuery();

                    MessageBox.Show("Usuario registrado exitosamente.");

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

            txtCelular.Text = "";
            txtDireccion.Text = "";
            txtCorreo.Text = "";
            CBCorreos.Text = "";
            txtGenero.Text = "";
            txtPuesto.Text = "";
            txtHoraIn.Text = "";
            txtHoraS.Text = "";
            txtInicio.Text = "";
            txtFin.Text = "";
            txtSalario.Text = "";
            txtMovilidad.Text = "";
            txtLicencia.Text = "";
            txtNLicencia.Text = "";
            txtNMatricula.Text = "";
            txtDescripcion.Text = "";
        }

    }

}