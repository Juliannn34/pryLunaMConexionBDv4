using System;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLunaMConexionBDv4
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            InterfazPersonalizada();
        }

        private string cadenaConexion = "Server=localhost;Database=Comercio;Trusted_Connection=True;";

        private void Form1_Load(object sender, EventArgs e)
        {
            clsConexionBD objConexion = new clsConexionBD();


            //Llenar el combo de categorias
            cmbCategoriaAgregar.DataSource = objConexion.ObtenerDatosDeTablaCategorias();
            cmbCategoriaAgregar.DisplayMember = "Nombre";
            cmbCategoriaAgregar.ValueMember = "Id";

            cmbCategoriaModificar.DataSource = objConexion.ObtenerDatosDeTablaCategorias();
            cmbCategoriaModificar.DisplayMember = "Nombre";
            cmbCategoriaModificar.ValueMember = "Id";

            cmbCategoriaEliminar.DataSource = objConexion.ObtenerDatosDeTablaCategorias();
            cmbCategoriaEliminar.DisplayMember = "Nombre";
            cmbCategoriaEliminar.ValueMember = "Id";

            //Llenar la grilla de productos
            dgvAgregar.DataSource = objConexion.ObtenerProductos();
            EstiloGrillaOscura(dgvAgregar);
            dgvModificar.DataSource = objConexion.ObtenerProductos();
            EstiloGrillaOscura(dgvModificar);
            dgvEliminar.DataSource = objConexion.ObtenerProductos();
            EstiloGrillaOscura(dgvEliminar);


            DesactivarCamposModificar();
            Controlador();
        }


        //-------------------------------------------------------------------------------------------------------------

        //Personalizar interfaz//


        //Personalizar colores
        public void InterfazPersonalizada()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.DeepOrange900,
                Primary.DeepOrange900,
                Primary.Green900,
                Accent.Red700,
                TextShade.WHITE
            );


        }

        //Personalizar colores de la grilla
        private void EstiloGrillaOscura(DataGridView dgv)
        {
            Color fondoGris = Color.FromArgb(60, 63, 65); // Gris intermedio
            Color fondoCelda = Color.FromArgb(80, 83, 85); // Un poco más claro para contraste

            dgv.BackgroundColor = fondoGris;
            dgv.DefaultCellStyle.BackColor = fondoCelda;
            dgv.DefaultCellStyle.ForeColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 87, 34); // Naranja
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = fondoGris;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.EnableHeadersVisualStyles = false;
            dgv.GridColor = Color.DimGray;
            dgv.BorderStyle = BorderStyle.None;

            dgv.RowHeadersDefaultCellStyle.BackColor = fondoGris;
            dgv.RowHeadersDefaultCellStyle.ForeColor = Color.White;

        }

        //-------------------------------------------------------------------------------------------------------------

        //Metodos Adicionales//

        //Recargar grilla
        public void RecargarGrilla()
        {
            clsConexionBD objConexion = new clsConexionBD();
            dgvAgregar.DataSource = objConexion.ObtenerProductos();
            dgvModificar.DataSource = objConexion.ObtenerProductos();
            dgvEliminar.DataSource = objConexion.ObtenerProductos();

        }

        //Eliminar producto
        private void EliminarProducto()
        {
            if (!int.TryParse(txtIdEliminar.Text, out int id))
            {
                MessageBox.Show("ID inválido.");
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Estás seguro que quieres eliminar este registro?",
                                                     "Eliminar contacto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                clsConexionBD conexion = new clsConexionBD();
                conexion.EliminarProducto(id);
                RecargarGrilla();          // Método para refrescar la grilla

            }
        }

        //Validar campos agregar producto
        private bool ValidarCamposAgregarProducto()
        {
            // Validar nombre: no debe ser un número
            if (string.IsNullOrWhiteSpace(txtNombreAgregar.Text))
            {
                MessageBox.Show("Por favor, ingresa el nombre del producto.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombreAgregar.Focus();
                return false;
            }

            if (decimal.TryParse(txtNombreAgregar.Text, out _))
            {
                MessageBox.Show("El nombre del producto no puede ser un número. Por favor, ingresa un texto válido.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombreAgregar.Focus();
                return false;
            }

            // Validar descripción: no debe estar vacía
            if (string.IsNullOrWhiteSpace(txtDescripcionAgregar.Text))
            {
                MessageBox.Show("Por favor, ingresa una descripción del producto.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescripcionAgregar.Focus();
                return false;
            }

            if (decimal.TryParse(txtDescripcionAgregar.Text, out _))
            {
                MessageBox.Show("La descripcion del producto no puede ser un número. Por favor, ingresa un texto válido.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescripcionAgregar.Focus();
                return false;
            }

            // Validar precio: debe ser un número
            if (string.IsNullOrWhiteSpace(txtPrecioAgregar.Text))
            {
                MessageBox.Show("Por favor, ingresa el precio del producto.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecioAgregar.Focus();
                return false;
            }

            decimal precioProducto;
            if (!decimal.TryParse(txtPrecioAgregar.Text, out precioProducto))
            {
                MessageBox.Show("Por favor, ingresa un precio válido.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecioAgregar.Focus();
                return false;
            }

            // Validar stock: debe ser un número entero
            if (string.IsNullOrWhiteSpace(txtStockAgregar.Text))
            {
                MessageBox.Show("Por favor, ingresa el stock del producto.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStockAgregar.Focus();
                return false;
            }

            int stockProducto;
            if (!int.TryParse(txtStockAgregar.Text, out stockProducto))
            {
                MessageBox.Show("Por favor, ingresa un stock válido.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStockAgregar.Focus();
                return false;
            }

            // Validar categoría: debe seleccionarse una
            if (cmbCategoriaAgregar.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecciona una categoría.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCategoriaAgregar.Focus();
                return false;
            }

            return true; // Si todo es válido, regresamos true
        }

        private bool ValidarCamposModificarProducto()
        {
            // Validar nombre: no debe ser un número
            if (string.IsNullOrWhiteSpace(txtNombreModificar.Text))
            {
                MessageBox.Show("Por favor, ingresa el nombre del producto.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombreModificar.Focus();
                return false;
            }

            if (decimal.TryParse(txtNombreModificar.Text, out _))
            {
                MessageBox.Show("El nombre del producto no puede ser un número. Por favor, ingresa un texto válido.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombreModificar.Focus();
                return false;
            }

            // Validar descripción: no debe estar vacía
            if (string.IsNullOrWhiteSpace(txtDescripcionModificar.Text))
            {
                MessageBox.Show("Por favor, ingresa una descripción del producto.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescripcionModificar.Focus();
                return false;
            }

            // Validar precio: debe ser un número
            if (string.IsNullOrWhiteSpace(txtPrecioModificar.Text))
            {
                MessageBox.Show("Por favor, ingresa el precio del producto.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecioModificar.Focus();
                return false;
            }

            decimal precioProducto;
            if (!decimal.TryParse(txtPrecioModificar.Text, out precioProducto))
            {
                MessageBox.Show("Por favor, ingresa un precio válido.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecioModificar.Focus();
                return false;
            }

            // Validar stock: debe ser un número entero
            if (string.IsNullOrWhiteSpace(txtStockModificar.Text))
            {
                MessageBox.Show("Por favor, ingresa el stock del producto.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStockModificar.Focus();
                return false;
            }

            int stockProducto;
            if (!int.TryParse(txtStockModificar.Text, out stockProducto))
            {
                MessageBox.Show("Por favor, ingresa un stock válido.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStockModificar.Focus();
                return false;
            }

            // Validar categoría: debe seleccionarse una
            if (cmbCategoriaModificar.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecciona una categoría.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCategoriaModificar.Focus();
                return false;
            }

            return true; // Si todo es válido, regresamos true
        }

        private void DesactivarCamposModificar()
        {
            txtNombreModificar.Enabled = false;
            txtDescripcionModificar.Enabled = false;
            txtPrecioModificar.Enabled = false;
            txtStockModificar.Enabled = false;
            cmbCategoriaModificar.Enabled = false;
            btnModificarProducto.Enabled = false; // Opcional: también desactivar el botón de modificar
        }


        private void ActivarCamposModificar()
        {
            txtNombreModificar.Enabled = true;
            txtDescripcionModificar.Enabled = true;
            txtPrecioModificar.Enabled = true;
            txtStockModificar.Enabled = true;
            cmbCategoriaModificar.Enabled = true;
            btnModificarProducto.Enabled = true;
        }

        private void Controlador()
        {
            if (txtNombreModificar.Text != string.Empty &&
                txtDescripcionModificar.Text != string.Empty &&
                txtPrecioModificar.Text != string.Empty &&
                txtStockModificar.Text != string.Empty &&
                cmbCategoriaModificar.Text != string.Empty)
            {
                btnModificarProducto.Enabled = true;
                txtNombreModificar.Enabled = true;
                txtDescripcionModificar.Enabled = true;
                txtPrecioModificar.Enabled = true;
                txtStockModificar.Enabled = true;
                cmbCategoriaModificar.Enabled = true;
            }
            else
            {
                btnModificarProducto.Enabled = false;
                txtNombreModificar.Enabled = false;
                txtDescripcionModificar.Enabled = false;
                txtPrecioModificar.Enabled = false;
                txtStockModificar.Enabled = false;
                cmbCategoriaModificar.Enabled = false;
            }
        }



        //-------------------------------------------------------------------------------------------------------------

        //Botones de la tabla contactos//



        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposAgregarProducto())
            {
                return; // Si falta algo, no sigue el proceso
            }


            clsConexionBD objConexion = new clsConexionBD();

            try
            {
                int categoriaId = Convert.ToInt32(cmbCategoriaAgregar.SelectedValue);

                // Create an instance of clsProductos to pass as an argument
                clsProductos nuevoProducto = new clsProductos
                {
                    Nombre = txtNombreAgregar.Text,
                    Desc = txtDescripcionAgregar.Text,
                    Precio = Convert.ToDecimal(txtPrecioAgregar.Text),
                    Stock = Convert.ToInt32(txtStockAgregar.Text),
                    CategoriaID = categoriaId
                };

                // Pass the clsProductos object to the AgregarProducto method
                objConexion.AgregarProducto(nuevoProducto);

                // Refrescar grilla después de agregar
                RecargarGrilla();

                // Limpiar campos
                txtNombreAgregar.Clear();
                txtDescripcionAgregar.Clear();
                txtPrecioAgregar.Clear();
                txtStockAgregar.Clear();
                cmbCategoriaAgregar.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar producto: " + ex.Message);
            }
        }




        //Buscar producto por ID
        private void btnBuscarIdModificar_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt16(txtIdModificar.Text);


            clsConexionBD conectarBD = new clsConexionBD();

            conectarBD.BuscarIDProducto(Id, txtNombreModificar, txtDescripcionModificar, txtPrecioModificar,
                txtStockModificar, cmbCategoriaModificar);



            if (int.TryParse(txtIdModificar.Text, out Id))
            {


                conectarBD.BuscarIDProducto(Id, txtNombreModificar, txtDescripcionModificar, txtPrecioModificar, txtStockModificar, cmbCategoriaModificar);

                // Llamamos al controlador después de que los campos se llenen
                Controlador();

                // Si no se encuentra el producto
                if (string.IsNullOrWhiteSpace(txtNombreModificar.Text))
                {
                    MessageBox.Show("No se encontró un producto con ese ID.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        //Modificar producto
        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            if (ValidarCamposModificarProducto())
            {
                return; // Si falta algo, no sigue el proceso
            }


            if (!int.TryParse(txtIdModificar.Text, out int idProducto))
            {
                MessageBox.Show("Por favor, ingresa un ID válido.");
                return;
            }

            clsProductos producto = new clsProductos
            {
                Codigo = idProducto,
                Nombre = txtNombreModificar.Text.Trim(),
                Desc = txtDescripcionModificar.Text.Trim(),
                Precio = Convert.ToDecimal(txtPrecioModificar.Text.Trim()),
                Stock = Convert.ToInt32(txtStockModificar.Text.Trim()),
                CategoriaID = Convert.ToInt32(cmbCategoriaModificar.SelectedValue)
            };

            clsConexionBD conexion = new clsConexionBD();
            bool exito = conexion.ModificarProducto(producto);

            if (exito)
            {
                MessageBox.Show("Producto modificado correctamente.");
                dgvModificar.DataSource = conexion.ObtenerProductos(); // si querés refrescar la grilla
            }
            else
            {
                MessageBox.Show("No se pudo modificar el producto.");
            }

            RecargarGrilla();
        }


        //Eliminar producto
        private void btnEliminarProductoPorID_Click(object sender, EventArgs e)
        {
            EliminarProducto();
        }




        //-------------------------------------------------------------------------------------------------------------

        //Botones de recarga de grilla//



        private void btnRecargarAgregar_Click(object sender, EventArgs e)
        {
            RecargarGrilla();
            MessageBox.Show("Grilla actualizada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRecargarModificar_Click(object sender, EventArgs e)
        {
            RecargarGrilla();
            MessageBox.Show("Grilla actualizada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRecargarEliminar_Click(object sender, EventArgs e)
        {
            RecargarGrilla();
            MessageBox.Show("Grilla actualizada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvModificar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int filasTotales = dgvModificar.Rows.Count;

            if (e.RowIndex >= 0 && e.RowIndex <= filasTotales)
            {
                int codigoSeleccionado = Convert.ToInt32(dgvModificar.Rows[e.RowIndex].Cells[0].Value);

                txtIdModificar.Text = codigoSeleccionado.ToString();
                txtNombreModificar.Text = dgvModificar.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDescripcionModificar.Text = dgvModificar.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPrecioModificar.Text = dgvModificar.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtStockModificar.Text = dgvModificar.Rows[e.RowIndex].Cells[4].Value.ToString();
                cmbCategoriaModificar.Text = dgvModificar.Rows[e.RowIndex].Cells[5].Value.ToString();

            }
            ActivarCamposModificar();
        }

        private void dgvEliminar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int filasTotales = dgvEliminar.Rows.Count;

            if (e.RowIndex >= 0 && e.RowIndex <= filasTotales)
            {
                int codigoSeleccionado = Convert.ToInt32(dgvEliminar.Rows[e.RowIndex].Cells[0].Value);

                txtIdEliminar.Text = codigoSeleccionado.ToString();
                txtNombreEliminar.Text = dgvEliminar.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDescripcionEliminar.Text = dgvEliminar.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPrecioEliminar.Text = dgvEliminar.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtStockEliminar.Text = dgvEliminar.Rows[e.RowIndex].Cells[4].Value.ToString();
                cmbCategoriaEliminar.Text = dgvEliminar.Rows[e.RowIndex].Cells[5].Value.ToString();

            }
        }

        private void txtIdEliminar_TextChanged(object sender, EventArgs e)
        {
            if (txtIdEliminar.Text != "")
            {
                btnEliminarProductoPorID.Enabled = true;
                txtNombreEliminar.Enabled = false;
                txtDescripcionEliminar.Enabled = false;
                txtPrecioEliminar.Enabled = false;
                txtStockEliminar.Enabled = false;
                cmbCategoriaEliminar.Enabled = false;

            }
            else
            {
                btnEliminarProductoPorID.Enabled = false;
                txtNombreEliminar.Enabled = false;
                txtDescripcionEliminar.Enabled = false;
                txtPrecioEliminar.Enabled = false;
                txtStockEliminar.Enabled = false;
                cmbCategoriaEliminar.Enabled = false;

            }
        }
    }
}
