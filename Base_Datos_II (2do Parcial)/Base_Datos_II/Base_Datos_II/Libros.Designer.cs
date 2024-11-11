namespace Base_Datos_II
{
    partial class Libros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Libros));
            dtpFecha = new DateTimePicker();
            TxtCopia = new TextBox();
            txtISBN = new TextBox();
            txtEditorial = new TextBox();
            txtAutor = new TextBox();
            txtTitulo = new TextBox();
            labelAutor = new Label();
            labelISBN = new Label();
            labelEditorial = new Label();
            labelAño = new Label();
            labelCopias = new Label();
            labelTitulo = new Label();
            btnModificar = new Button();
            btnAgregar = new Button();
            btnEliminar = new Button();
            DGWLibros = new DataGridView();
            DGWISBN = new DataGridViewTextBoxColumn();
            DGWTitulo = new DataGridViewTextBoxColumn();
            DGWAutor = new DataGridViewTextBoxColumn();
            DGWEditorial = new DataGridViewTextBoxColumn();
            DGWPublicacion = new DataGridViewTextBoxColumn();
            DGWCopias = new DataGridViewTextBoxColumn();
            btnVolver = new Button();
            label1 = new Label();
            MenuPersonal = new MenuStrip();
            librosToolStripMenuItem = new ToolStripMenuItem();
            prestamosYDevolucionesToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)DGWLibros).BeginInit();
            MenuPersonal.SuspendLayout();
            SuspendLayout();
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(732, 126);
            dtpFecha.Margin = new Padding(3, 4, 3, 4);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(158, 27);
            dtpFecha.TabIndex = 60;
            dtpFecha.Value = new DateTime(2024, 10, 7, 0, 0, 0, 0);
            dtpFecha.Visible = false;
            // 
            // TxtCopia
            // 
            TxtCopia.Cursor = Cursors.IBeam;
            TxtCopia.Location = new Point(732, 170);
            TxtCopia.Margin = new Padding(3, 4, 3, 4);
            TxtCopia.Multiline = true;
            TxtCopia.Name = "TxtCopia";
            TxtCopia.Size = new Size(158, 28);
            TxtCopia.TabIndex = 59;
            TxtCopia.Visible = false;
            // 
            // txtISBN
            // 
            txtISBN.Cursor = Cursors.IBeam;
            txtISBN.Location = new Point(732, 211);
            txtISBN.Margin = new Padding(3, 4, 3, 4);
            txtISBN.Multiline = true;
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(158, 28);
            txtISBN.TabIndex = 58;
            txtISBN.Visible = false;
            // 
            // txtEditorial
            // 
            txtEditorial.Cursor = Cursors.IBeam;
            txtEditorial.Location = new Point(156, 210);
            txtEditorial.Margin = new Padding(3, 4, 3, 4);
            txtEditorial.Multiline = true;
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(292, 28);
            txtEditorial.TabIndex = 57;
            txtEditorial.Visible = false;
            // 
            // txtAutor
            // 
            txtAutor.Cursor = Cursors.IBeam;
            txtAutor.Location = new Point(156, 169);
            txtAutor.Margin = new Padding(3, 4, 3, 4);
            txtAutor.Multiline = true;
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(292, 28);
            txtAutor.TabIndex = 56;
            txtAutor.Visible = false;
            // 
            // txtTitulo
            // 
            txtTitulo.Cursor = Cursors.IBeam;
            txtTitulo.Location = new Point(156, 128);
            txtTitulo.Margin = new Padding(3, 4, 3, 4);
            txtTitulo.Multiline = true;
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(292, 28);
            txtTitulo.TabIndex = 55;
            txtTitulo.Visible = false;
            // 
            // labelAutor
            // 
            labelAutor.AutoSize = true;
            labelAutor.BackColor = Color.FromArgb(250, 250, 250);
            labelAutor.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelAutor.ForeColor = Color.FromArgb(51, 51, 51);
            labelAutor.Location = new Point(35, 169);
            labelAutor.Name = "labelAutor";
            labelAutor.Size = new Size(69, 29);
            labelAutor.TabIndex = 54;
            labelAutor.Text = "Autor";
            labelAutor.Visible = false;
            labelAutor.Click += labelAutor_Click;
            // 
            // labelISBN
            // 
            labelISBN.AutoSize = true;
            labelISBN.BackColor = Color.FromArgb(250, 250, 250);
            labelISBN.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelISBN.ForeColor = Color.FromArgb(51, 51, 51);
            labelISBN.Location = new Point(647, 209);
            labelISBN.Name = "labelISBN";
            labelISBN.Size = new Size(69, 29);
            labelISBN.TabIndex = 53;
            labelISBN.Text = "ISBN";
            labelISBN.Visible = false;
            // 
            // labelEditorial
            // 
            labelEditorial.AutoSize = true;
            labelEditorial.BackColor = Color.FromArgb(250, 250, 250);
            labelEditorial.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelEditorial.ForeColor = Color.FromArgb(51, 51, 51);
            labelEditorial.Location = new Point(35, 211);
            labelEditorial.Name = "labelEditorial";
            labelEditorial.Size = new Size(102, 29);
            labelEditorial.TabIndex = 52;
            labelEditorial.Text = "Editorial";
            labelEditorial.Visible = false;
            labelEditorial.Click += labelEditorial_Click;
            // 
            // labelAño
            // 
            labelAño.AutoSize = true;
            labelAño.BackColor = Color.FromArgb(250, 250, 250);
            labelAño.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelAño.ForeColor = Color.FromArgb(51, 51, 51);
            labelAño.Location = new Point(493, 122);
            labelAño.Name = "labelAño";
            labelAño.Size = new Size(223, 29);
            labelAño.TabIndex = 51;
            labelAño.Text = "Año De Publicacion";
            labelAño.Visible = false;
            // 
            // labelCopias
            // 
            labelCopias.AutoSize = true;
            labelCopias.BackColor = Color.FromArgb(250, 250, 250);
            labelCopias.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelCopias.ForeColor = Color.FromArgb(51, 51, 51);
            labelCopias.Location = new Point(627, 167);
            labelCopias.Name = "labelCopias";
            labelCopias.Size = new Size(89, 29);
            labelCopias.TabIndex = 50;
            labelCopias.Text = "Copias";
            labelCopias.Visible = false;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.BackColor = Color.FromArgb(250, 250, 250);
            labelTitulo.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitulo.ForeColor = Color.FromArgb(51, 51, 51);
            labelTitulo.Location = new Point(35, 128);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(74, 29);
            labelTitulo.TabIndex = 49;
            labelTitulo.Text = "Titulo";
            labelTitulo.Visible = false;
            labelTitulo.Click += labelTitulo_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(59, 130, 246);
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.FlatAppearance.BorderColor = Color.FromArgb(59, 130, 246);
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(462, 611);
            btnModificar.Margin = new Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(174, 53);
            btnModificar.TabIndex = 48;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Visible = false;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(0, 123, 255);
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatAppearance.BorderColor = Color.FromArgb(0, 123, 255);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = SystemColors.ButtonFace;
            btnAgregar.Location = new Point(328, 611);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(128, 53);
            btnAgregar.TabIndex = 47;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Visible = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(255, 66, 66);
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderColor = Color.FromArgb(255, 66, 66);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(642, 611);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(144, 53);
            btnEliminar.TabIndex = 46;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Visible = false;
            // 
            // DGWLibros
            // 
            DGWLibros.BackgroundColor = Color.FromArgb(77, 77, 77);
            DGWLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGWLibros.Columns.AddRange(new DataGridViewColumn[] { DGWISBN, DGWTitulo, DGWAutor, DGWEditorial, DGWPublicacion, DGWCopias });
            DGWLibros.Location = new Point(35, 261);
            DGWLibros.Margin = new Padding(3, 4, 3, 4);
            DGWLibros.Name = "DGWLibros";
            DGWLibros.RowHeadersWidth = 62;
            DGWLibros.RowTemplate.Height = 25;
            DGWLibros.Size = new Size(872, 325);
            DGWLibros.TabIndex = 45;
            DGWLibros.Visible = false;
            // 
            // DGWISBN
            // 
            DGWISBN.HeaderText = "ISBN";
            DGWISBN.MinimumWidth = 8;
            DGWISBN.Name = "DGWISBN";
            DGWISBN.Width = 80;
            // 
            // DGWTitulo
            // 
            DGWTitulo.HeaderText = "Titulo";
            DGWTitulo.MinimumWidth = 8;
            DGWTitulo.Name = "DGWTitulo";
            DGWTitulo.Width = 202;
            // 
            // DGWAutor
            // 
            DGWAutor.HeaderText = "Autor";
            DGWAutor.MinimumWidth = 8;
            DGWAutor.Name = "DGWAutor";
            DGWAutor.Width = 200;
            // 
            // DGWEditorial
            // 
            DGWEditorial.HeaderText = "Editorial";
            DGWEditorial.MinimumWidth = 8;
            DGWEditorial.Name = "DGWEditorial";
            DGWEditorial.Width = 180;
            // 
            // DGWPublicacion
            // 
            DGWPublicacion.HeaderText = "Publicacion";
            DGWPublicacion.MinimumWidth = 8;
            DGWPublicacion.Name = "DGWPublicacion";
            DGWPublicacion.Width = 110;
            // 
            // DGWCopias
            // 
            DGWCopias.HeaderText = "Copias";
            DGWCopias.MinimumWidth = 8;
            DGWCopias.Name = "DGWCopias";
            DGWCopias.Width = 80;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Crimson;
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.FlatAppearance.BorderColor = Color.Crimson;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.ForeColor = SystemColors.ButtonFace;
            btnVolver.Location = new Point(793, 611);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(124, 53);
            btnVolver.TabIndex = 43;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(25, 25, 25);
            label1.Location = new Point(35, 60);
            label1.Name = "label1";
            label1.Size = new Size(137, 54);
            label1.TabIndex = 42;
            label1.Text = "Libros";
            label1.Visible = false;
            // 
            // MenuPersonal
            // 
            MenuPersonal.BackColor = SystemColors.ButtonFace;
            MenuPersonal.ImageScalingSize = new Size(24, 24);
            MenuPersonal.Items.AddRange(new ToolStripItem[] { librosToolStripMenuItem, prestamosYDevolucionesToolStripMenuItem, reportesToolStripMenuItem });
            MenuPersonal.Location = new Point(0, 0);
            MenuPersonal.Name = "MenuPersonal";
            MenuPersonal.Padding = new Padding(7, 3, 0, 3);
            MenuPersonal.Size = new Size(930, 30);
            MenuPersonal.TabIndex = 44;
            MenuPersonal.Text = "menuStrip1";
            // 
            // librosToolStripMenuItem
            // 
            librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            librosToolStripMenuItem.Size = new Size(63, 24);
            librosToolStripMenuItem.Text = "Libros";
            // 
            // prestamosYDevolucionesToolStripMenuItem
            // 
            prestamosYDevolucionesToolStripMenuItem.Name = "prestamosYDevolucionesToolStripMenuItem";
            prestamosYDevolucionesToolStripMenuItem.Padding = new Padding(18, 0, 4, 0);
            prestamosYDevolucionesToolStripMenuItem.Size = new Size(205, 24);
            prestamosYDevolucionesToolStripMenuItem.Text = "Prestamos y devoluciones";
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Padding = new Padding(18, 0, 4, 0);
            reportesToolStripMenuItem.Size = new Size(94, 24);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // Libros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(930, 669);
            Controls.Add(dtpFecha);
            Controls.Add(TxtCopia);
            Controls.Add(txtISBN);
            Controls.Add(txtEditorial);
            Controls.Add(txtAutor);
            Controls.Add(txtTitulo);
            Controls.Add(labelAutor);
            Controls.Add(labelISBN);
            Controls.Add(labelEditorial);
            Controls.Add(labelAño);
            Controls.Add(labelCopias);
            Controls.Add(labelTitulo);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(btnEliminar);
            Controls.Add(DGWLibros);
            Controls.Add(btnVolver);
            Controls.Add(label1);
            Controls.Add(MenuPersonal);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Libros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Libros";
            Load += Libros_Load;
            ((System.ComponentModel.ISupportInitialize)DGWLibros).EndInit();
            MenuPersonal.ResumeLayout(false);
            MenuPersonal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpFecha;
        private TextBox TxtCopia;
        private TextBox txtISBN;
        private TextBox txtEditorial;
        private TextBox txtAutor;
        private TextBox txtTitulo;
        private Label labelAutor;
        private Label labelISBN;
        private Label labelEditorial;
        private Label labelAño;
        private Label labelCopias;
        private Label labelTitulo;
        private Button btnModificar;
        private Button btnAgregar;
        private Button btnEliminar;
        private DataGridView DGWLibros;
        private DataGridViewTextBoxColumn DGWISBN;
        private DataGridViewTextBoxColumn DGWTitulo;
        private DataGridViewTextBoxColumn DGWAutor;
        private DataGridViewTextBoxColumn DGWEditorial;
        private DataGridViewTextBoxColumn DGWPublicacion;
        private DataGridViewTextBoxColumn DGWCopias;
        private Button btnVolver;
        private Label label1;
        private MenuStrip MenuPersonal;
        private ToolStripMenuItem librosToolStripMenuItem;
        private ToolStripMenuItem prestamosYDevolucionesToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
    }
}