using MaterialSkin;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace pryLunaMConexionBDv4
{
    public partial class frmLogin : MaterialForm
    {
        public frmLogin()
        {
            InitializeComponent();
            InterfazPersonalizada();
        }


        private int intentosFallidos = 0;

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }



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





        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=Comercio;Trusted_Connection=True;";
            string username = txtUsuario.Text;
            string password = txtContraseña.Text;

            string query = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @usuario AND Clave = @clave";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@usuario", username);
                    cmd.Parameters.AddWithValue("@clave", password);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Inicio de sesión exitoso.");
                        Form productos = new Form();
                        productos.Show();
                        this.Hide();
                    }
                    else
                    {
                        intentosFallidos++; // Aumentar el contador
                        MessageBox.Show("Usuario o contraseña incorrectos. Intento " + intentosFallidos + " de 3.");

                        if (intentosFallidos >= 3)
                        {
                            MessageBox.Show("Demasiados intentos fallidos. El formulario se cerrará.");
                            this.Close(); // Cierra el formulario actual
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                }
            }
        }
    }
}
