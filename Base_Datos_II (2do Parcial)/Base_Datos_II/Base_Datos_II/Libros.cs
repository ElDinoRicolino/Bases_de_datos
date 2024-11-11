using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base_Datos_II
{
    public partial class Libros : Form
    {
        public Libros()
        {
            InitializeComponent();
        }

        private void Libros_Load(object sender, EventArgs e)
        {
            label1.Visible = true;
            DGWLibros.Visible = true;
            btnAgregar.Visible = true;
            btnEliminar.Visible = true;
            btnModificar.Visible = true;

            txtTitulo.Visible = true;
            txtAutor.Visible = true;
            TxtCopia.Visible = true;
            txtEditorial.Visible = true;
            txtISBN.Visible = true;

            labelTitulo.Visible = true;
            labelAutor.Visible = true;
            labelAño.Visible = true;
            labelCopias.Visible = true;
            labelISBN.Visible = true;
            labelEditorial.Visible = true;

            dtpFecha.Visible = true;
        }

        private void labelEditorial_Click(object sender, EventArgs e)
        {

        }

        private void labelAutor_Click(object sender, EventArgs e)
        {

        }

        private void labelTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
