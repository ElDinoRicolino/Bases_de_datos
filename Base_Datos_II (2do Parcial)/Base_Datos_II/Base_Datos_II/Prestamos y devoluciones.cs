using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Data.SqlClient;
using Microsoft.Data.SqlClient.Server;

namespace Base_Datos_II
{

    public partial class Prestamos_y_devoluciones : Form
    {
        private string cmd = "Server=DESKTOP-8IGFD7V\\SQLEXPRESS;" +
                                   "Database=Biblioteca;" +
                                   "Trusted_Connection=True;" +
                                   "TrustServerCertificate=True;";

        // Función para prestar libro
        // Cambiar la firma del método para que no requiera apellido2
        public void PrestarLibro(string nombre, string apellido1, int isbn, int idPersonal)
        {
            using (SqlConnection connection = new SqlConnection(cmd))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_PrestarLibro", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Nombre", nombre);
                        command.Parameters.AddWithValue("@Lastname1", apellido1);
                        command.Parameters.AddWithValue("@ISBN", isbn);
                        command.Parameters.AddWithValue("@IDpersonal", idPersonal);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Préstamo realizado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al prestar el libro: " + ex.Message);
                }
            }
        }


        // Función para devolver libro
        public void Devolver_Libro(int idPrestamo, int idPersonal)
        {
            using (SqlConnection connection = new SqlConnection(cmd))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_DevolverLibro", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@IDprestamo", idPrestamo);
                        command.Parameters.AddWithValue("@IDpersonal", idPersonal);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Libro devuelto con éxito.");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el préstamo o ya fue devuelto.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al devolver el libro: " + ex.Message);
                }
            }
        }
        public Prestamos_y_devoluciones()
        {
            InitializeComponent();
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Libros ventanalibros = new Libros();
            ventanalibros.ShowDialog();
        }
        private void registroDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registrar_Usuarios ventanaRU = new Registrar_Usuarios();
            ventanaRU.ShowDialog();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_PrestarLibro_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            string apellido1 = textBoxAP.Text;
            int isbn = int.Parse(textBoxISBN.Text);
            int idPersonal = int.Parse(textBoxID.Text);

            PrestarLibro(nombre, apellido1, isbn, idPersonal);
        }
        private void btn_DevolverLibro_Click(object sender, EventArgs e)
        {
            try
            {
                int idPrestamo = int.Parse(textBoxISBN.Text);
                int idPersonal = int.Parse(textBoxID.Text);

                Devolver_Libro(idPrestamo, idPersonal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al devolver el libro: " + ex.Message);
            }
        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBoxIDD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
