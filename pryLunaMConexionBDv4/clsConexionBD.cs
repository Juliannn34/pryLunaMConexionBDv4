
using System;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLunaMConexionBDv4
{
    internal class clsConexionBD
    {

        //cadena de conexion
        string cadenaConexion = "Server=localhost;Database=Comercio;Trusted_Connection=True;";

        //conector
        SqlConnection coneccionBaseDatos;

        //comando
        SqlCommand comandoBaseDatos;

        public string nombreBaseDeDatos;


        //Conectar a la base de datos
        public void ConectarBD()
        {
            try
            {
                coneccionBaseDatos = new SqlConnection(cadenaConexion);

                nombreBaseDeDatos = coneccionBaseDatos.Database;

                coneccionBaseDatos.Open();

                MessageBox.Show("Conectado a " + nombreBaseDeDatos);
            }
            catch (Exception error)
            {
                MessageBox.Show("Tiene un errorcito - " + error.Message);
            }

        }




        //obtener datos de la tabla productos
        public DataTable ObtenerProductos()
        {
            DataTable tablaProductos = new DataTable();

            try
            {
                using (coneccionBaseDatos = new SqlConnection(cadenaConexion))
                {
                    coneccionBaseDatos.Open();
                    string consulta = "SELECT * FROM Productos";
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, coneccionBaseDatos);
                    adaptador.Fill(tablaProductos);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al obtener productos: " + error.Message);
            }

            return tablaProductos;
        }


        //agregar datos a la tabla productos

        public void AgregarProducto(clsProductos Prodructo)
        {

            try
            {
                using (coneccionBaseDatos = new SqlConnection(cadenaConexion))
                {
                    coneccionBaseDatos.Open();
                    string consulta = "INSERT INTO Productos (Nombre, Descripcion, Precio, Stock, CategoriaId) " +
                                      "VALUES (@Nombre, @Descripcion, @Precio, @Stock, @CategoriaId)";

                    using (comandoBaseDatos = new SqlCommand(consulta, coneccionBaseDatos))
                    {
                        comandoBaseDatos.Parameters.AddWithValue("@Nombre", Prodructo.Nombre);
                        comandoBaseDatos.Parameters.AddWithValue("@Descripcion", Prodructo.Desc);
                        comandoBaseDatos.Parameters.AddWithValue("@Precio", Prodructo.Precio);
                        comandoBaseDatos.Parameters.AddWithValue("@Stock", Prodructo.Stock);
                        comandoBaseDatos.Parameters.AddWithValue("@CategoriaId", Prodructo.CategoriaID);

                        comandoBaseDatos.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Producto agregado correctamente.");
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al agregar producto: " + error.Message);
            }
        }

        //Modificar datos de la tabla productos

        public bool ModificarProducto(clsProductos producto)
        {
            string consulta = "UPDATE Productos SET Nombre = @Nombre, Descripcion = @Descripcion, Precio = @Precio, Stock = @Stock, CategoriaId = @CategoriaId WHERE Codigo = @Codigo";

            try
            {
                using (coneccionBaseDatos = new SqlConnection(cadenaConexion))
                {
                    coneccionBaseDatos.Open();
                    comandoBaseDatos = new SqlCommand(consulta, coneccionBaseDatos);

                    comandoBaseDatos.Parameters.AddWithValue("@Codigo", producto.Codigo);
                    comandoBaseDatos.Parameters.AddWithValue("@Nombre", producto.Nombre);
                    comandoBaseDatos.Parameters.AddWithValue("@Descripcion", producto.Desc);
                    comandoBaseDatos.Parameters.AddWithValue("@Precio", producto.Precio);
                    comandoBaseDatos.Parameters.AddWithValue("@Stock", producto.Stock);
                    comandoBaseDatos.Parameters.AddWithValue("@CategoriaId", producto.CategoriaID);

                    return comandoBaseDatos.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar producto: " + ex.Message);
                return false;
            }
        }



        //Eliminar datos de la tabla productos

        public void EliminarProducto(int codigo)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                string consulta = "DELETE FROM Productos WHERE Codigo = @Codigo";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Codigo", codigo);
                    comando.ExecuteNonQuery();
                }
            }
        }


        public DataTable ObtenerDatosDeTablaCategorias()
        {
            DataTable tablaCategorias = new DataTable();

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "SELECT Id, Nombre FROM Categorias";
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                    adaptador.Fill(tablaCategorias);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener categorías: " + ex.Message);
            }

            return tablaCategorias;
        }



        public void BuscarIDProducto(int ID, MaterialTextBox txtNombre, MaterialTextBox txtDescripcion, MaterialTextBox txtPrecio, MaterialTextBox txtStock, MaterialComboBox cmbCategoria)
        {
            try
            {
                using (coneccionBaseDatos = new SqlConnection(cadenaConexion))
                {
                    coneccionBaseDatos.Open();
                    string consulta = "SELECT * FROM Productos WHERE Codigo = @Codigo";
                    comandoBaseDatos = new SqlCommand(consulta, coneccionBaseDatos);
                    comandoBaseDatos.Parameters.AddWithValue("@Codigo", ID);

                    SqlDataReader Reader = comandoBaseDatos.ExecuteReader();
                    while (Reader.Read())
                    {
                        txtNombre.Text = Reader["Nombre"].ToString();
                        txtDescripcion.Text = Reader["Descripcion"].ToString();
                        txtPrecio.Text = Reader["Precio"].ToString();
                        txtStock.Text = Reader["Stock"].ToString();
                        cmbCategoria.SelectedValue = Convert.ToInt32(Reader["CategoriaId"]);
                    }

                    Reader.Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al obtener datos del producto: " + error.Message);
            }
        }


        //-------------------------------------------------------------------------------------------------

        // Conexion con tabla categorias 
        public DataTable ObtenerCategorias()
        {
            DataTable tablaCategorias = new DataTable();

            try
            {
                using (coneccionBaseDatos = new SqlConnection(cadenaConexion))
                {
                    coneccionBaseDatos.Open();
                    string consulta = "SELECT Nombre FROM Categorias";
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, coneccionBaseDatos);
                    adaptador.Fill(tablaCategorias);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al obtener categorías: " + error.Message);
            }

            return tablaCategorias;
        }


        //-------------------------------------------------------------------------------------------------


    }
}