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
    public partial class RegistrarProducto : Form
    {
        // Cadena de conexión a tu base de datos
        private string connectionString = "Data Source=DESKTOP-0NULSP6;Initial Catalog=CompraProductos;Integrated Security=True";
        private Color originalBackColor;
        private Color originalForeColor;
        private Color originalGBRegistroForeColor;
        private Color originalGBDescripcionForeColor;
        private Color originalGBAccionForeColor;
        private Color originaldgvProductosForeColor;

        public RegistrarProducto()
        {
            InitializeComponent();
            ApplyColors(); // Aplicar los colores al abrir el formulario
            MenuPrincipal.DarkModeChanged += ApplyColors;

            CargarDatos();
            dgvProductos.CellEndEdit += dgvProductos_CellEndEdit;
            dgvProductos.CellFormatting += dgvProductos_CellFormatting;
        }

        // Método para aplicar colores oscuros si el modo oscuro está activo
        private void ApplyDarkModeIfNeeded()
        {
            if (MenuPrincipal.DarkModeActive)
            {
                this.BackColor = Color.Black;
                pnlHorizontal.BackColor = Color.DimGray;
                btnRegistro.BackColor = Color.DimGray;
                btnAlmacenTabla.BackColor = Color.DimGray;
                // GBAccion.BackColor = Color.DimGray;
                //GBDescripcion.BackColor = Color.DimGray;
                //GBRegistro.BackColor = Color.DimGray;
                //dgvProductos.BackColor = Color.DimGray;

                btnRegistro.ForeColor = Color.White; // Configurar color de texto del botón en modo oscuro
                btnAlmacenTabla.ForeColor = Color.White; // Configurar color de texto del botón en modo oscuro
                GBAccion.ForeColor = Color.White; // Cambiar el color del texto de GroupBox en modo oscuro
                GBDescripcion.ForeColor = Color.White;
                GBRegistro.ForeColor = Color.White;
                dgvProductos.ForeColor = Color.Black;
            }
            else
            {
                // Aplicar colores originales
                this.BackColor = Color.FromArgb(255, 222, 231);
                pnlHorizontal.BackColor = Color.FromArgb(255, 192, 255);
                btnRegistro.BackColor = Color.White;
                btnAlmacenTabla.BackColor = Color.White;
                //GBAccion.BackColor = Color.White;

                btnRegistro.ForeColor = Color.Black; // Revertir color de texto del botón
                btnAlmacenTabla.ForeColor = Color.Black; // Revertir color de texto del botón
                GBAccion.ForeColor = Color.Black; // Restaurar el color original del texto de GroupBox
                GBDescripcion.ForeColor = Color.Black;
                GBRegistro.ForeColor = Color.Black;
                dgvProductos.ForeColor = Color.Black;
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

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            // Desuscribirse del evento cuando el formulario se cierre
            MenuPrincipal.DarkModeChanged -= ApplyColors;
            base.OnFormClosed(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // Guardar los colores originales cuando se carga el formulario
            originalBackColor = this.BackColor;
            originalForeColor = btnRegistro.ForeColor;
            originalForeColor = btnAlmacenTabla.ForeColor;
            originalGBAccionForeColor = GBAccion.ForeColor; // Guardar el color original del texto de GroupBox
            originalGBDescripcionForeColor = GBDescripcion.ForeColor; // Guardar el color original del texto de GroupBox
            originalGBRegistroForeColor = GBRegistro.ForeColor;
            originaldgvProductosForeColor = dgvProductos.ForeColor;
        }
    

    private void CargarDatos()
        {
            // Crear una conexión a la base de datos
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Definir la consulta SQL para obtener los datos de la tabla Productos
                string query = "SELECT Codigo, Nombre, Cantidad, UxMasa, UxLitro, Precio, Descripcion FROM Productos";

                // Crear un adaptador de datos para ejecutar la consulta y llenar un DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();

                try
                {
                    // Abrir la conexión y llenar el DataTable con los datos de la tabla Productos
                    connection.Open();
                    adapter.Fill(table);

                    //ajustar automáticamente al contenido de la tabla dgvProductos
                    dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }
        }

        private void RegistrarProducto_Load(object sender, EventArgs e)
        {
            // Llamar al método para mostrar la tabla de productos cuando se carga el formulario
            MostrarTablaProductos();
        }

       

   

       
        private void btnRegistro_Click(object sender, EventArgs e)
        {
            //// Verificar si los campos están llenos
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) || string.IsNullOrWhiteSpace(txtNombre.Text) ||
            /*    string.IsNullOrWhiteSpace(txtCantidad.Text) ||*/ string.IsNullOrWhiteSpace(txtPrecio.Text) ||
               string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Por favor, llene todos los campos.");
                return;
            }

            // Convertir los valores de cantidad, masa, litro y precio a tipos numéricos
            float? uxMasa = null, uxLitro = null;
            int? cantidad = null;
            if (!string.IsNullOrWhiteSpace(txtUxMasa.Text))
            {
                if (float.TryParse(txtUxMasa.Text, out float result))
                {
                    uxMasa = result;
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un valor válido para UxMasa.");
                    return;
                }
            }
            if (!string.IsNullOrWhiteSpace(txtUxLitro.Text))
            {
                if (float.TryParse(txtUxLitro.Text, out float result))
                {
                    uxLitro = result;
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un valor válido para UxLitro.");
                    return;
                }
            }
            if (!string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                if (int.TryParse(txtCantidad.Text, out int result))
                {
                    cantidad = result;
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un valor válido para Cantidad.");
                    return;
                }
            }

            // Convertir los valores de cantidad y precio a tipos numéricos
            if ( !float.TryParse(txtPrecio.Text, out float precio))
            {
                MessageBox.Show("Por favor, ingrese valores válidos para precio.");
                return;
            }

           

            // Insertar el producto en la base de datos
            string query = "INSERT INTO Productos (Codigo, Nombre, UxMasa, UxLitro, Cantidad, Precio, Descripcion) " +
                           "VALUES (@Codigo, @Nombre, @UxMasa, @UxLitro, @Cantidad, @Precio, @Descripcion)";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Asignar valores a los parámetros de la consulta
                        command.Parameters.AddWithValue("@Codigo", txtCodigo.Text);
                        command.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                        command.Parameters.AddWithValue("@UxMasa", (object)uxMasa ?? DBNull.Value);
                        command.Parameters.AddWithValue("@UxLitro", (object)uxLitro ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Cantidad", (object)cantidad ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Precio", precio);
                        command.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);

                        // Ejecutar la consulta
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Producto registrado correctamente.");
                            // Limpiar los campos después de registrar el producto
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("Error al registrar el producto.");
                        }
                    }
                }
                // Después de registrar el producto, actualizar el DataGridView con los datos más recientes
                ActualizarTablaProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el producto: " + ex.Message);
            }

            
        }

        private void ActualizarTablaProductos()
        {
            // Define una nueva conexión a la base de datos
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Productos"; // Consulta para seleccionar todos los productos
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Asigna el DataTable como origen de datos del DataGridView
                    dgvProductos.DataSource = dataTable;




               


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el DataGridView: " + ex.Message);
                }
            }
        }


        private void LimpiarCampos()
        {
            // Limpiar todos los campos de entrada
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtCantidad.Text = "";
            txtUxMasa.Text = "";
            txtUxLitro.Text = "";
            txtPrecio.Text = "";
            txtDescripcion.Text = "";
        }

        private void dgvProductos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvProductos.Columns["Precio"].Index)
            {
                // Agregar el sufijo 'Bs' al valor ingresado en la columna Precio
                dgvProductos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = dgvProductos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value + " Bs.";
            }
            else if (e.ColumnIndex == dgvProductos.Columns["UxMasa"].Index)
            {
                // Agregar el sufijo 'g' al valor ingresado en la columna UxMasa
                dgvProductos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = dgvProductos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value + " Kg.";
            }
            else if (e.ColumnIndex == dgvProductos.Columns["UxLitro"].Index)
            {
                // Agregar el sufijo 'l' al valor ingresado en la columna UxLitro
                dgvProductos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = dgvProductos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value + " l.";
            }
            else if (e.ColumnIndex == dgvProductos.Columns["Cantidad"].Index)
            {
                // Agregar el sufijo 'u' al valor ingresado en la columna Cantidad
                dgvProductos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = dgvProductos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value + " u.";
            }

            
        }

        private void dgvProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verificar si la celda actual es de la columna Precio
            if (dgvProductos.Columns[e.ColumnIndex].Name == "Precio")
            {
                // Verificar si el valor de la celda no es nulo y no está vacío
                if (e.Value != null && !string.IsNullOrEmpty(e.Value.ToString()))
                {
                    // Agregar el sufijo 'Bs' al valor de la celda en la columna Precio
                    e.Value = e.Value + " Bs.";
                    e.FormattingApplied = true; // Indicar que se ha aplicado el formato a la celda
                }
            }
            // Verificar si la celda actual es de la columna UxMasa
            else if (dgvProductos.Columns[e.ColumnIndex].Name == "UxMasa")
            {
                // Verificar si el valor de la celda no es nulo y no está vacío
                if (e.Value != null && !string.IsNullOrEmpty(e.Value.ToString()))
                {
                    // Agregar el sufijo 'g' al valor de la celda en la columna UxMasa
                    e.Value = e.Value + " Kg.";
                    e.FormattingApplied = true; // Indicar que se ha aplicado el formato a la celda
                }
            }
            // Verificar si la celda actual es de la columna UxLitro
            else if (dgvProductos.Columns[e.ColumnIndex].Name == "UxLitro")
            {
                // Verificar si el valor de la celda no es nulo y no está vacío
                if (e.Value != null && !string.IsNullOrEmpty(e.Value.ToString()))
                {
                    // Agregar el sufijo 'l' al valor de la celda en la columna UxLitro
                    e.Value = e.Value + " l.";
                    e.FormattingApplied = true; // Indicar que se ha aplicado el formato a la celda
                }
            }
            // Verificar si la celda actual es de la columna Cantidad
            else if (dgvProductos.Columns[e.ColumnIndex].Name == "Cantidad")
            {
                // Verificar si el valor de la celda no es nulo y no está vacío
                if (e.Value != null && !string.IsNullOrEmpty(e.Value.ToString()))
                {
                    // Agregar el sufijo 'l' al valor de la celda en la columna UxLitro
                    e.Value = e.Value + " u.";
                    e.FormattingApplied = true; // Indicar que se ha aplicado el formato a la celda
                }
            }
        }


        private void MostrarTablaProductos()
        {
            try
            {
                string query = "SELECT Codigo, Nombre, Cantidad, UxMasa, UxLitro, Precio, Descripcion FROM Productos";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Asignar los datos al DataGridView
                        dgvProductos.DataSource = dataTable;



                     



                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar la tabla de productos: " + ex.Message);
            }
        }

        private void btnGuardarTabla_Click(object sender, EventArgs e)
        {
            try
            {
                // Terminar cualquier edición en curso
                dgvProductos.EndEdit();

                // Obtener los cambios realizados en el DataTable subyacente
                DataTable cambios = ((DataTable)dgvProductos.DataSource).GetChanges();

                // Verificar si hay cambios pendientes
                if (cambios != null)
                {
                    // Establecer la conexión a la base de datos
                    using (SqlConnection conexion = new SqlConnection(connectionString))
                    {
                        conexion.Open();
                        // Utilizar un adaptador para actualizar los datos en la base de datos
                        using (SqlDataAdapter adaptador = new SqlDataAdapter("SELECT * FROM Productos", conexion))
                        {
                            SqlCommandBuilder constructorComandos = new SqlCommandBuilder(adaptador);
                            adaptador.UpdateCommand = constructorComandos.GetUpdateCommand();
                            adaptador.Update(cambios);
                        }
                    }
                    // Informar al usuario sobre el éxito de la operación
                    MessageBox.Show("Cambios guardados correctamente.");
                }
                else
                {
                    MessageBox.Show("No hay cambios pendientes para guardar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los cambios: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una celda
            if (dgvProductos.SelectedCells.Count > 0)
            {
                // Obtener la celda seleccionada
                DataGridViewCell cell = dgvProductos.SelectedCells[0];

                // Verificar si el valor de la celda es numérico antes de limpiarlo
                if (cell.Value != null && double.TryParse(cell.Value.ToString(), out _))
                {
                    cell.Value = DBNull.Value; // Limpiar el valor de la celda
                }
                else
                {
                    MessageBox.Show("No se puede limpiar esta celda.");
                }
            }
        }

        private object valorOriginal = null;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Verificar si hay un valor original guardado
            if (valorOriginal != null)
            {
                // Obtener la celda actualmente en edición
                DataGridViewCell cell = dgvProductos.CurrentCell;
                // Restaurar el valor original de la celda
                cell.Value = valorOriginal;
                // Salir de la edición de la celda
                dgvProductos.EndEdit();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Confirmar con el usuario antes de eliminar la fila seleccionada
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar la fila seleccionada?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                // Si el usuario confirma, proceder con la eliminación
                if (resultado == DialogResult.Yes)
                {
                    // Verificar si hay al menos una fila seleccionada en el DataGridView
                    if (dgvProductos.SelectedRows.Count > 0)
                    {
                        // Obtener la fila seleccionada
                        DataGridViewRow filaSeleccionada = dgvProductos.SelectedRows[0];

                        // Obtener el valor de la celda de la columna "Codigo" en la fila seleccionada
                        string codigoProducto = filaSeleccionada.Cells["Codigo"].Value.ToString();

                        // Establecer la conexión a la base de datos
                        using (SqlConnection conexion = new SqlConnection(connectionString))
                        {
                            conexion.Open();
                            // Ejecutar un comando SQL para eliminar el producto con el código especificado
                            string consulta = "DELETE FROM Productos WHERE Codigo = @Codigo";
                            using (SqlCommand comando = new SqlCommand(consulta, conexion))
                            {
                                comando.Parameters.AddWithValue("@Codigo", codigoProducto);
                                comando.ExecuteNonQuery();
                            }
                        }

                        // Actualizar el DataGridView para reflejar los cambios
                        ActualizarTablaProductos();
                        // Informar al usuario sobre el éxito de la operación
                        MessageBox.Show("Producto eliminado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("Por favor, seleccione una fila para eliminar.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el producto: " + ex.Message);
            }
        }

        private void btnAlmacenTabla_Click(object sender, EventArgs e)
        {
           
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
