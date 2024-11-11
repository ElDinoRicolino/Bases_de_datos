using System;
using System.Drawing;
using System.Windows.Forms;

namespace Base_Datos_II
{
    public partial class Inicio : Form
    {
        private string tipoUsuario;
        public Inicio()
        {
            InitializeComponent();
            SetupControls();

        }

        private void SetupControls()
        {

            // Eventos de texto
            txtNombre.TextChanged += txtNombre_TextChanged;
            txtContraseña.TextChanged += txtContraseña_TextChanged;
            txtid.TextChanged += txtid_TextChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnMiembro_Click(object sender, EventArgs e)
        {
            tipoUsuario = "Miembro";
            labelID.Visible = true;
            txtid.Visible = true;
            labelContraseña.Visible = true;
            txtContraseña.Visible = true;
            btnIngresar.Visible = true;

            labelNombre.Visible = false;
            txtNombre.Visible = false;
            this.Hide();
        }
        private void btnPersonal_Click(object sender, EventArgs e)
        {
            tipoUsuario = "Personal";
            labelNombre.Visible = true;
            txtNombre.Visible = true;
            labelContraseña.Visible = true;
            txtContraseña.Visible = true;
            btnIngresar.Visible = true;

            labelID.Visible = false;
            txtid.Visible = false;
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (tipoUsuario == "Miembro")
            {
                Miembro ventanaMiembro = new Miembro();
                ventanaMiembro.ShowDialog();
            }
            else if (tipoUsuario == "Personal")
            {
                Personal ventanaPersonal = new Personal();
                ventanaPersonal.ShowDialog();
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
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

        private void labelContraseña_Click(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
