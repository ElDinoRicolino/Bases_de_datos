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
    public partial class Libros : Form
    {
        //Conectar a la base de datos, modificar unicamente el Server, y en dado caso el nombre de la base de datos
        private string cmd = "Server=DESKTOP-GTORLDP\\SQLEXPRESS;" +
                                   "Database=Biblioteca;" +
                                   "Trusted_Connection=True;" +
                                   "TrustServerCertificate=True;";
        public Libros()
        {
            InitializeComponent();
        }
        //Cargar libros 
        public void CargarLibros()
        {
            using (SqlConnection connection = new SqlConnection(cmd))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT ISBN, Titulo, Autor, Editorial, Publicacion, Num_Copias FROM Libros";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    DGWLibros.DataSource = null;
                    DGWLibros.Columns.Clear();

                    DGWLibros.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el libro: " + ex.Message);
                }
            }
        }
        private void Libros_Load(object sender, EventArgs e)
        {
            CargarLibros();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DGWLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = DGWLibros.Rows[e.RowIndex];
                txtISBN.Text = fila.Cells[0].Value.ToString();
                txtTitulo.Text = fila.Cells[1].Value.ToString();
                txtAutor.Text = fila.Cells[2].Value.ToString();
                txtEditorial.Text = fila.Cells[3].Value.ToString();
                dtpFecha.Value = Convert.ToDateTime(fila.Cells[4].Value);
                TxtCopia.Text = fila.Cells[5].Value.ToString();
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(cmd))
            {
                if (string.IsNullOrWhiteSpace(txtISBN.Text) ||
                string.IsNullOrWhiteSpace(txtTitulo.Text) ||
                string.IsNullOrWhiteSpace(txtAutor.Text) ||
                string.IsNullOrWhiteSpace(txtEditorial.Text) ||
                string.IsNullOrWhiteSpace(TxtCopia.Text))
                {
                    MessageBox.Show("Por favor, completa todos los campos.");
                    return;
                }
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Libros (ISBN, Titulo, Autor, Editorial, Publicacion, Num_Copias ) VALUES (@ISBN, @Titulo, @Autor, @Editorial, @Año, @Copias)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ISBN", txtISBN.Text);
                        command.Parameters.AddWithValue("@Titulo", txtTitulo.Text);
                        command.Parameters.AddWithValue("@Autor", txtAutor.Text);
                        command.Parameters.AddWithValue("@Editorial", txtEditorial.Text);
                        command.Parameters.AddWithValue("@Año", dtpFecha.Value);
                        command.Parameters.AddWithValue("@Copias", TxtCopia.Text);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Libro agregado a la base de datos.");

                        txtISBN.Text = "";
                        txtTitulo.Text = "";
                        txtAutor.Text = "";
                        txtEditorial.Text = "";
                        dtpFecha.Value = DateTime.Now;
                        TxtCopia.Text = "";

                        CargarLibros();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el libro: " + ex.Message);
                }
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DGWLibros.CurrentRow != null)
            {
                string isbnSeleccionado = DGWLibros.CurrentRow.Cells[0].Value.ToString();
                using (SqlConnection connection = new SqlConnection(cmd))
                {
                    try
                    {
                        connection.Open();
                        string query = "DELETE FROM Libros WHERE ISBN = @ISBN";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ISBN", isbnSeleccionado);

                            command.ExecuteNonQuery();
                            MessageBox.Show("Libro eliminado.");

                            txtISBN.Text = "";
                            txtTitulo.Text = "";
                            txtAutor.Text = "";
                            txtEditorial.Text = "";
                            dtpFecha.Value = DateTime.Now;
                            TxtCopia.Text = "";

                            CargarLibros();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el libro: " + ex.Message);
                    }
                }
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (DGWLibros.CurrentRow != null)
            {
                using (SqlConnection connection = new SqlConnection(cmd))
                {
                    try
                    {
                        connection.Open();
                        string query = "UPDATE Libros SET Titulo = @Titulo, Autor = @Autor, Editorial = @Editorial, Publicacion = @Año, Num_Copias = @Copias WHERE ISBN = @ISBN";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ISBN", txtISBN.Text);
                            command.Parameters.AddWithValue("@Titulo", txtTitulo.Text);
                            command.Parameters.AddWithValue("@Autor", txtAutor.Text);
                            command.Parameters.AddWithValue("@Editorial", txtEditorial.Text);
                            command.Parameters.AddWithValue("@Año", dtpFecha.Value);
                            command.Parameters.AddWithValue("@Copias", TxtCopia.Text);

                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Libro modificado.");
                            }
                            else
                            {
                                MessageBox.Show("No se encontró el libro con el ISBN proporcionado.");
                            }

                            command.ExecuteNonQuery();

                            txtISBN.Text = "";
                            txtTitulo.Text = "";
                            txtAutor.Text = "";
                            txtEditorial.Text = "";
                            dtpFecha.Value = DateTime.Now;
                            TxtCopia.Text = "";

                            CargarLibros();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al modificar el libro: " + ex.Message);
                    }
                }
            }
        }
        private void prestamosYDevolucionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prestamos_y_devoluciones ventanaPYD = new Prestamos_y_devoluciones();
            ventanaPYD.ShowDialog();
        }

        private void registroDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registrar_Usuarios ventanaRU = new Registrar_Usuarios();
            ventanaRU.ShowDialog();
        }
        private void TxtCopia_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
