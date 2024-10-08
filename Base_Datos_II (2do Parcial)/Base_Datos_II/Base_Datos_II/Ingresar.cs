using System;
using System.Drawing;
using System.Windows.Forms;

namespace Base_Datos_II
{
    public partial class Inicio : Form
    {
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
            labelID.Visible = true;
            txtid.Visible = true;
            labelContraseña.Visible = true;
            txtContraseña.Visible = true;
            labelNombre.Visible = false;
            txtNombre.Visible = false;
            btnIngresarM.Visible = true;
            btnIngresarP.Visible = false;
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            labelID.Visible = false;
            txtid.Visible = false;
            labelContraseña.Visible = true;
            txtContraseña.Visible = true;
            labelNombre.Visible = true;
            txtNombre.Visible = true;
            btnIngresarM.Visible = false;
            btnIngresarP.Visible = true;
        }

        private void btnIngresarP_Click(object sender, EventArgs e)
        {
            Personal ventanaPersonal = new Personal();
            ventanaPersonal.ShowDialog();
        }

        private void btnIngresarM_Click(object sender, EventArgs e)
        {
            Miembro ventanaMiembro = new Miembro();
            ventanaMiembro.ShowDialog();
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
