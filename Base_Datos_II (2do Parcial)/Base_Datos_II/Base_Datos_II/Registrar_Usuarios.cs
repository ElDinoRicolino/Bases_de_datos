using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
//Para conexion
using Microsoft.Data.SqlClient;
using Microsoft.Data.SqlClient.Server;

namespace Base_Datos_II
{
    public partial class Registrar_Usuarios : Form
    {
        //Conectar a la base de datos, modificar unicamente el Server, y en dado caso el nombre de la base de datos
        private string cmd = "Server=DESKTOP-GTORLDP\\SQLEXPRESS;" +
                                   "Database=Biblioteca;" +
                                   "Trusted_Connection=True;" +
                                   "TrustServerCertificate=True;";

        //Registro para usuarios
        private void RegistrarUsuario(string Nombre, string ApellidoPaterno, string ApellidoMaterno, string Direccion, string Telefono, string Correo)
        {
            //Abre conexion con SQL
            using (SqlConnection connection = new SqlConnection(cmd))
            {
                try
                {
                    //Abre conexion con el Procedimiento almacenado
                    using (SqlCommand command = new SqlCommand("SP_RegistrarUsuario", connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", Nombre);
                        command.Parameters.AddWithValue("@Primerapellido", ApellidoPaterno);
                        command.Parameters.AddWithValue("@Segundoapellido", ApellidoMaterno);
                        command.Parameters.AddWithValue("@Direccion", Direccion);
                        command.Parameters.AddWithValue("@Telefono", Telefono);
                        command.Parameters.AddWithValue("@Correo_electronico", Correo);

                        command.CommandType = CommandType.StoredProcedure;
                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Usuario agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void RegistrarPersonal(string Nombre, string ApellidoPaterno, string ApellidoMaterno, string Direccion, string Telefono, string Correo)
        {
            //Abre conexion con SQL
            using (SqlConnection connection = new SqlConnection(cmd))
            {
                try
                {
                    //Abre conexion con el Procedimiento almacenado
                    using (SqlCommand command = new SqlCommand("SP_RegistrarPersonal", connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", Nombre);
                        command.Parameters.AddWithValue("@Primerapellido", ApellidoPaterno);
                        command.Parameters.AddWithValue("@Segundoapellido", ApellidoMaterno);
                        command.Parameters.AddWithValue("@Direccion", Direccion);
                        command.Parameters.AddWithValue("@Telefono", Telefono);
                        command.Parameters.AddWithValue("@Correo_electronico", Correo);

                        command.CommandType = CommandType.StoredProcedure;
                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Personal agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar el Personal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public Registrar_Usuarios()
        {
            InitializeComponent();
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Libros ventanalibros = new Libros();
            ventanalibros.ShowDialog();
        }

        private void prestamosYDevolucionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prestamos_y_devoluciones ventanaPYD = new Prestamos_y_devoluciones();
            ventanaPYD.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Almacena unicamente numeros y da la posibilidad de borrar
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            //Almacena los diferentes textos en variables
            string Nombre = txtNombre.Text;
            string ApellidoPaterno = txtAP.Text;
            string ApellidoMaterno = txtAM.Text;
            string Direccion = txtDireccion.Text;
            string Telefono = txtTelefono.Text;
            string Correo = txtCorreo.Text;

            //Verificar si todos los parametros estan llenos, por el contrario no dejara agregar usuarios
            if (string.IsNullOrWhiteSpace(Nombre) ||
                string.IsNullOrWhiteSpace(ApellidoPaterno) ||
                string.IsNullOrWhiteSpace(ApellidoMaterno) ||
                string.IsNullOrWhiteSpace(Direccion) ||
                string.IsNullOrWhiteSpace(Telefono) ||
                string.IsNullOrWhiteSpace(Correo))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }
            //Manda a llamar al metodo
            RegistrarUsuario(Nombre, ApellidoPaterno, ApellidoMaterno, Direccion, Telefono, Correo);
        }

        private void btnAgregarPersonal_Click(object sender, EventArgs e)
        {
            //Almacena los diferentes textos en variables
            string Nombre = txtNombre.Text;
            string ApellidoPaterno = txtAP.Text;
            string ApellidoMaterno = txtAM.Text;
            string Direccion = txtDireccion.Text;
            string Telefono = txtTelefono.Text;
            string Correo = txtCorreo.Text;

            //Verificar si todos los parametros estan llenos, por el contrario no dejara agregar usuarios
            if (string.IsNullOrWhiteSpace(Nombre) ||
                string.IsNullOrWhiteSpace(ApellidoPaterno) ||
                string.IsNullOrWhiteSpace(ApellidoMaterno) ||
                string.IsNullOrWhiteSpace(Direccion) ||
                string.IsNullOrWhiteSpace(Telefono) ||
                string.IsNullOrWhiteSpace(Correo))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }
            RegistrarPersonal(Nombre, ApellidoPaterno, ApellidoMaterno, Direccion, Telefono, Correo);
        }
    }
}
