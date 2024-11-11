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
            registroDeUsuariosToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)DGWLibros).BeginInit();
            MenuPersonal.SuspendLayout();
            SuspendLayout();
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(640, 94);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(139, 23);
            dtpFecha.TabIndex = 60;
            dtpFecha.Value = new DateTime(2024, 10, 7, 0, 0, 0, 0);
            // 
            // TxtCopia
            // 
            TxtCopia.Cursor = Cursors.IBeam;
            TxtCopia.Location = new Point(640, 128);
            TxtCopia.Multiline = true;
            TxtCopia.Name = "TxtCopia";
            TxtCopia.Size = new Size(139, 22);
            TxtCopia.TabIndex = 59;
            TxtCopia.KeyPress += TxtCopia_KeyPress_1;
            // 
            // txtISBN
            // 
            txtISBN.Cursor = Cursors.IBeam;
            txtISBN.Location = new Point(640, 158);
            txtISBN.Multiline = true;
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(139, 22);
            txtISBN.TabIndex = 58;
            // 
            // txtEditorial
            // 
            txtEditorial.Cursor = Cursors.IBeam;
            txtEditorial.Location = new Point(136, 158);
            txtEditorial.Multiline = true;
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(256, 22);
            txtEditorial.TabIndex = 57;
            // 
            // txtAutor
            // 
            txtAutor.Cursor = Cursors.IBeam;
            txtAutor.Location = new Point(136, 127);
            txtAutor.Multiline = true;
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(256, 22);
            txtAutor.TabIndex = 56;
            // 
            // txtTitulo
            // 
            txtTitulo.Cursor = Cursors.IBeam;
            txtTitulo.Location = new Point(136, 96);
            txtTitulo.Multiline = true;
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(256, 22);
            txtTitulo.TabIndex = 55;
            // 
            // labelAutor
            // 
            labelAutor.AutoSize = true;
            labelAutor.BackColor = Color.FromArgb(250, 250, 250);
            labelAutor.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelAutor.ForeColor = Color.FromArgb(51, 51, 51);
            labelAutor.Location = new Point(31, 127);
            labelAutor.Name = "labelAutor";
            labelAutor.Size = new Size(55, 24);
            labelAutor.TabIndex = 54;
            labelAutor.Text = "Autor";
            // 
            // labelISBN
            // 
            labelISBN.AutoSize = true;
            labelISBN.BackColor = Color.FromArgb(250, 250, 250);
            labelISBN.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelISBN.ForeColor = Color.FromArgb(51, 51, 51);
            labelISBN.Location = new Point(566, 157);
            labelISBN.Name = "labelISBN";
            labelISBN.Size = new Size(52, 24);
            labelISBN.TabIndex = 53;
            labelISBN.Text = "ISBN";
            // 
            // labelEditorial
            // 
            labelEditorial.AutoSize = true;
            labelEditorial.BackColor = Color.FromArgb(250, 250, 250);
            labelEditorial.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelEditorial.ForeColor = Color.FromArgb(51, 51, 51);
            labelEditorial.Location = new Point(31, 158);
            labelEditorial.Name = "labelEditorial";
            labelEditorial.Size = new Size(77, 24);
            labelEditorial.TabIndex = 52;
            labelEditorial.Text = "Editorial";
            // 
            // labelAño
            // 
            labelAño.AutoSize = true;
            labelAño.BackColor = Color.FromArgb(250, 250, 250);
            labelAño.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelAño.ForeColor = Color.FromArgb(51, 51, 51);
            labelAño.Location = new Point(431, 92);
            labelAño.Name = "labelAño";
            labelAño.Size = new Size(177, 24);
            labelAño.TabIndex = 51;
            labelAño.Text = "Año De Publicacion";
            // 
            // labelCopias
            // 
            labelCopias.AutoSize = true;
            labelCopias.BackColor = Color.FromArgb(250, 250, 250);
            labelCopias.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelCopias.ForeColor = Color.FromArgb(51, 51, 51);
            labelCopias.Location = new Point(549, 125);
            labelCopias.Name = "labelCopias";
            labelCopias.Size = new Size(68, 24);
            labelCopias.TabIndex = 50;
            labelCopias.Text = "Copias";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.BackColor = Color.FromArgb(250, 250, 250);
            labelTitulo.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitulo.ForeColor = Color.FromArgb(51, 51, 51);
            labelTitulo.Location = new Point(31, 96);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(56, 24);
            labelTitulo.TabIndex = 49;
            labelTitulo.Text = "Titulo";
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(59, 130, 246);
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.FlatAppearance.BorderColor = Color.FromArgb(59, 130, 246);
            btnModificar.FlatStyle = FlatStyle.Popup;
            btnModificar.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(404, 458);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(152, 40);
            btnModificar.TabIndex = 48;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(0, 123, 255);
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatAppearance.BorderColor = Color.FromArgb(0, 123, 255);
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = SystemColors.ButtonFace;
            btnAgregar.Location = new Point(287, 458);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 40);
            btnAgregar.TabIndex = 61;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(255, 66, 66);
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderColor = Color.FromArgb(255, 66, 66);
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(562, 458);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(126, 40);
            btnEliminar.TabIndex = 46;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // DGWLibros
            // 
            DGWLibros.BackgroundColor = Color.FromArgb(77, 77, 77);
            DGWLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGWLibros.Columns.AddRange(new DataGridViewColumn[] { DGWISBN, DGWTitulo, DGWAutor, DGWEditorial, DGWPublicacion, DGWCopias });
            DGWLibros.Location = new Point(31, 196);
            DGWLibros.Name = "DGWLibros";
            DGWLibros.RowHeadersWidth = 62;
            DGWLibros.RowTemplate.Height = 25;
            DGWLibros.Size = new Size(763, 244);
            DGWLibros.TabIndex = 45;
            DGWLibros.CellContentClick += DGWLibros_CellContentClick;
            // 
            // DGWISBN
            // 
            DGWISBN.HeaderText = "ISBN";
            DGWISBN.MinimumWidth = 8;
            DGWISBN.Name = "DGWISBN";
            DGWISBN.Width = 125;
            // 
            // DGWTitulo
            // 
            DGWTitulo.HeaderText = "Titulo";
            DGWTitulo.MinimumWidth = 8;
            DGWTitulo.Name = "DGWTitulo";
            DGWTitulo.Width = 212;
            // 
            // DGWAutor
            // 
            DGWAutor.HeaderText = "Autor";
            DGWAutor.MinimumWidth = 8;
            DGWAutor.Name = "DGWAutor";
            DGWAutor.Width = 210;
            // 
            // DGWEditorial
            // 
            DGWEditorial.HeaderText = "Editorial";
            DGWEditorial.MinimumWidth = 8;
            DGWEditorial.Name = "DGWEditorial";
            DGWEditorial.Width = 190;
            // 
            // DGWPublicacion
            // 
            DGWPublicacion.HeaderText = "Publicacion";
            DGWPublicacion.MinimumWidth = 8;
            DGWPublicacion.Name = "DGWPublicacion";
            DGWPublicacion.Width = 120;
            // 
            // DGWCopias
            // 
            DGWCopias.HeaderText = "Copias";
            DGWCopias.MinimumWidth = 8;
            DGWCopias.Name = "DGWCopias";
            DGWCopias.Width = 90;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Crimson;
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.FlatAppearance.BorderColor = Color.Crimson;
            btnVolver.FlatStyle = FlatStyle.Popup;
            btnVolver.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.ForeColor = SystemColors.ButtonFace;
            btnVolver.Location = new Point(694, 458);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(108, 40);
            btnVolver.TabIndex = 43;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(25, 25, 25);
            label1.Location = new Point(31, 45);
            label1.Name = "label1";
            label1.Size = new Size(112, 45);
            label1.TabIndex = 42;
            label1.Text = "Libros";
            // 
            // MenuPersonal
            // 
            MenuPersonal.BackColor = SystemColors.ButtonFace;
            MenuPersonal.ImageScalingSize = new Size(24, 24);
            MenuPersonal.Items.AddRange(new ToolStripItem[] { librosToolStripMenuItem, prestamosYDevolucionesToolStripMenuItem, registroDeUsuariosToolStripMenuItem, reportesToolStripMenuItem });
            MenuPersonal.Location = new Point(0, 0);
            MenuPersonal.Name = "MenuPersonal";
            MenuPersonal.Size = new Size(814, 24);
            MenuPersonal.TabIndex = 44;
            MenuPersonal.Text = "menuStrip1";
            // 
            // librosToolStripMenuItem
            // 
            librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            librosToolStripMenuItem.Size = new Size(51, 20);
            librosToolStripMenuItem.Text = "Libros";
            // 
            // prestamosYDevolucionesToolStripMenuItem
            // 
            prestamosYDevolucionesToolStripMenuItem.Name = "prestamosYDevolucionesToolStripMenuItem";
            prestamosYDevolucionesToolStripMenuItem.Padding = new Padding(18, 0, 4, 0);
            prestamosYDevolucionesToolStripMenuItem.Size = new Size(170, 20);
            prestamosYDevolucionesToolStripMenuItem.Text = "Prestamos y devoluciones";
            prestamosYDevolucionesToolStripMenuItem.Click += prestamosYDevolucionesToolStripMenuItem_Click;
            // 
            // registroDeUsuariosToolStripMenuItem
            // 
            registroDeUsuariosToolStripMenuItem.Name = "registroDeUsuariosToolStripMenuItem";
            registroDeUsuariosToolStripMenuItem.Size = new Size(127, 20);
            registroDeUsuariosToolStripMenuItem.Text = "Registro De Usuarios";
            registroDeUsuariosToolStripMenuItem.Click += registroDeUsuariosToolStripMenuItem_Click;
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Padding = new Padding(18, 0, 4, 0);
            reportesToolStripMenuItem.Size = new Size(79, 20);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // Libros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(814, 502);
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
            Margin = new Padding(3, 2, 3, 2);
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
        private Button btnVolver;
        private Label label1;
        private MenuStrip MenuPersonal;
        private ToolStripMenuItem librosToolStripMenuItem;
        private ToolStripMenuItem prestamosYDevolucionesToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private DataGridViewTextBoxColumn DGWISBN;
        private DataGridViewTextBoxColumn DGWTitulo;
        private DataGridViewTextBoxColumn DGWAutor;
        private DataGridViewTextBoxColumn DGWEditorial;
        private DataGridViewTextBoxColumn DGWPublicacion;
        private DataGridViewTextBoxColumn DGWCopias;
        private ToolStripMenuItem registroDeUsuariosToolStripMenuItem;
    }
}