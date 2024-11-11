using System;
using System.Drawing;
using System.Windows.Forms;

namespace Base_Datos_II
{
    public partial class Inicio : Form
    {
        string Nombre = "Villedo";
        string Contraseña = "123";
        public Inicio()
        {
            InitializeComponent();
            SetupControls();

        }

        private void SetupControls()
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMiembro_Click(object sender, EventArgs e)
        {
            Miembro ventanaMiembro = new Miembro();
            ventanaMiembro.ShowDialog();
        }
        private void btnPersonal_Click(object sender, EventArgs e)
        {
            labelNombre.Visible = true;
            txtNombre.Visible = true;
            labelContraseña.Visible = true;
            txtContraseña.Visible = true;
            btnIngresar.Visible = true;
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != Nombre || txtContraseña.Text != Contraseña)
            {
                MessageBox.Show("Contraseña o Usuario incorrecta, vuelve a intentarlo");
                return;
            }
            Libros ventanaLibros = new Libros();
            ventanaLibros.ShowDialog();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            //cerrar el forms actual
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            int lineHeight = TextRenderer.MeasureText("A", txtNombre.Font).Height;
            int lineCount = txtNombre.Lines.Length;
            txtNombre.Height = lineHeight * lineCount + 10;
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            int lineHeight = TextRenderer.MeasureText("A", txtContraseña.Font).Height;
            int lineCount = txtContraseña.Lines.Length;
            txtContraseña.Height = lineHeight * lineCount + 10;
        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
