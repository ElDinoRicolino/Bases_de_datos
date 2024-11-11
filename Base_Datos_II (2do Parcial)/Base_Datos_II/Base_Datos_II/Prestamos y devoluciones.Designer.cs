namespace Base_Datos_II
{
    partial class Prestamos_y_devoluciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prestamos_y_devoluciones));
            MenuPersonal = new MenuStrip();
            librosToolStripMenuItem = new ToolStripMenuItem();
            prestamosYDevolucionesToolStripMenuItem = new ToolStripMenuItem();
            registroDeUsuariosToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            LabelPrestamo = new Label();
            textBoxNombre = new TextBox();
            LabelNombre = new Label();
            textBoxID = new TextBox();
            LabelApellido = new Label();
            textBoxAP = new TextBox();
            textBoxIDD = new TextBox();
            LabelISBN = new Label();
            textBoxISBN = new TextBox();
            LabelID = new Label();
            textBoxNombreD = new TextBox();
            LabelApellidoD = new Label();
            textBoxAPD = new TextBox();
            LabelNombreD = new Label();
            label10 = new Label();
            textBoxISBND = new TextBox();
            label11 = new Label();
            btn_DevolverLibro = new Button();
            btn_PrestarLibro = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnVolver = new Button();
            labelISBN_D = new Label();
            LabelIDD = new Label();
            MenuPersonal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // MenuPersonal
            // 
            MenuPersonal.BackColor = SystemColors.ButtonFace;
            MenuPersonal.ImageScalingSize = new Size(24, 24);
            MenuPersonal.Items.AddRange(new ToolStripItem[] { librosToolStripMenuItem, prestamosYDevolucionesToolStripMenuItem, registroDeUsuariosToolStripMenuItem, reportesToolStripMenuItem });
            MenuPersonal.Location = new Point(0, 0);
            MenuPersonal.Name = "MenuPersonal";
            MenuPersonal.Size = new Size(814, 24);
            MenuPersonal.TabIndex = 45;
            MenuPersonal.Text = "menuStrip1";
            // 
            // librosToolStripMenuItem
            // 
            librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            librosToolStripMenuItem.Size = new Size(51, 20);
            librosToolStripMenuItem.Text = "Libros";
            librosToolStripMenuItem.Click += librosToolStripMenuItem_Click;
            // 
            // prestamosYDevolucionesToolStripMenuItem
            // 
            prestamosYDevolucionesToolStripMenuItem.Name = "prestamosYDevolucionesToolStripMenuItem";
            prestamosYDevolucionesToolStripMenuItem.Padding = new Padding(18, 0, 4, 0);
            prestamosYDevolucionesToolStripMenuItem.Size = new Size(170, 20);
            prestamosYDevolucionesToolStripMenuItem.Text = "Prestamos y devoluciones";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(25, 25, 25);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 30);
            label1.TabIndex = 46;
            label1.Visible = false;
            // 
            // LabelPrestamo
            // 
            LabelPrestamo.AutoSize = true;
            LabelPrestamo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            LabelPrestamo.Location = new Point(65, 29);
            LabelPrestamo.Name = "LabelPrestamo";
            LabelPrestamo.Size = new Size(112, 30);
            LabelPrestamo.TabIndex = 47;
            LabelPrestamo.Text = "Prestamo";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(200, 99);
            textBoxNombre.Margin = new Padding(3, 2, 3, 2);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(191, 23);
            textBoxNombre.TabIndex = 48;
            // 
            // LabelNombre
            // 
            LabelNombre.AutoSize = true;
            LabelNombre.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNombre.Location = new Point(65, 98);
            LabelNombre.Name = "LabelNombre";
            LabelNombre.Size = new Size(79, 24);
            LabelNombre.TabIndex = 50;
            LabelNombre.Text = "Nombre";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(200, 130);
            textBoxID.Margin = new Padding(3, 2, 3, 2);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(191, 23);
            textBoxID.TabIndex = 51;
            textBoxID.KeyPress += textBoxID_KeyPress;
            // 
            // LabelApellido
            // 
            LabelApellido.AutoSize = true;
            LabelApellido.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelApellido.Location = new Point(396, 98);
            LabelApellido.Name = "LabelApellido";
            LabelApellido.Size = new Size(79, 24);
            LabelApellido.TabIndex = 52;
            LabelApellido.Text = "Apellido";
            // 
            // textBoxAP
            // 
            textBoxAP.Location = new Point(497, 100);
            textBoxAP.Margin = new Padding(3, 2, 3, 2);
            textBoxAP.Name = "textBoxAP";
            textBoxAP.Size = new Size(191, 23);
            textBoxAP.TabIndex = 53;
            // 
            // textBoxIDD
            // 
            textBoxIDD.Location = new Point(200, 355);
            textBoxIDD.Margin = new Padding(3, 2, 3, 2);
            textBoxIDD.Name = "textBoxIDD";
            textBoxIDD.Size = new Size(191, 23);
            textBoxIDD.TabIndex = 55;
            textBoxIDD.KeyPress += textBoxIDD_KeyPress;
            // 
            // LabelISBN
            // 
            LabelISBN.AutoSize = true;
            LabelISBN.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelISBN.Location = new Point(65, 63);
            LabelISBN.Name = "LabelISBN";
            LabelISBN.Size = new Size(52, 24);
            LabelISBN.TabIndex = 54;
            LabelISBN.Text = "ISBN";
            // 
            // textBoxISBN
            // 
            textBoxISBN.Location = new Point(200, 66);
            textBoxISBN.Margin = new Padding(3, 2, 3, 2);
            textBoxISBN.Name = "textBoxISBN";
            textBoxISBN.Size = new Size(191, 23);
            textBoxISBN.TabIndex = 64;
            // 
            // LabelID
            // 
            LabelID.AutoSize = true;
            LabelID.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelID.Location = new Point(65, 128);
            LabelID.Name = "LabelID";
            LabelID.Size = new Size(106, 24);
            LabelID.TabIndex = 63;
            LabelID.Text = "ID Personal";
            // 
            // textBoxNombreD
            // 
            textBoxNombreD.Location = new Point(200, 323);
            textBoxNombreD.Margin = new Padding(3, 2, 3, 2);
            textBoxNombreD.Name = "textBoxNombreD";
            textBoxNombreD.Size = new Size(191, 23);
            textBoxNombreD.TabIndex = 62;
            // 
            // LabelApellidoD
            // 
            LabelApellidoD.AutoSize = true;
            LabelApellidoD.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelApellidoD.Location = new Point(398, 320);
            LabelApellidoD.Name = "LabelApellidoD";
            LabelApellidoD.Size = new Size(79, 24);
            LabelApellidoD.TabIndex = 61;
            LabelApellidoD.Text = "Apellido";
            // 
            // textBoxAPD
            // 
            textBoxAPD.Location = new Point(497, 323);
            textBoxAPD.Margin = new Padding(3, 2, 3, 2);
            textBoxAPD.Name = "textBoxAPD";
            textBoxAPD.Size = new Size(191, 23);
            textBoxAPD.TabIndex = 60;
            // 
            // LabelNombreD
            // 
            LabelNombreD.AutoSize = true;
            LabelNombreD.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNombreD.Location = new Point(65, 320);
            LabelNombreD.Name = "LabelNombreD";
            LabelNombreD.Size = new Size(79, 24);
            LabelNombreD.TabIndex = 59;
            LabelNombreD.Text = "Nombre";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(0, 89);
            label10.Name = "label10";
            label10.Size = new Size(0, 24);
            label10.TabIndex = 58;
            // 
            // textBoxISBND
            // 
            textBoxISBND.Location = new Point(200, 294);
            textBoxISBND.Margin = new Padding(3, 2, 3, 2);
            textBoxISBND.Name = "textBoxISBND";
            textBoxISBND.Size = new Size(191, 23);
            textBoxISBND.TabIndex = 57;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(65, 253);
            label11.Name = "label11";
            label11.Size = new Size(191, 30);
            label11.TabIndex = 56;
            label11.Text = "Devolver un libro";
            // 
            // btn_DevolverLibro
            // 
            btn_DevolverLibro.BackColor = Color.FromArgb(67, 160, 71);
            btn_DevolverLibro.FlatStyle = FlatStyle.Popup;
            btn_DevolverLibro.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn_DevolverLibro.ForeColor = SystemColors.Control;
            btn_DevolverLibro.Location = new Point(194, 408);
            btn_DevolverLibro.Margin = new Padding(3, 2, 3, 2);
            btn_DevolverLibro.Name = "btn_DevolverLibro";
            btn_DevolverLibro.Size = new Size(514, 40);
            btn_DevolverLibro.TabIndex = 65;
            btn_DevolverLibro.Text = "Devolver Libro";
            btn_DevolverLibro.UseVisualStyleBackColor = false;
            btn_DevolverLibro.Click += btn_DevolverLibro_Click;
            // 
            // btn_PrestarLibro
            // 
            btn_PrestarLibro.BackColor = Color.FromArgb(30, 136, 229);
            btn_PrestarLibro.FlatStyle = FlatStyle.Popup;
            btn_PrestarLibro.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn_PrestarLibro.ForeColor = SystemColors.Control;
            btn_PrestarLibro.Location = new Point(173, 188);
            btn_PrestarLibro.Margin = new Padding(3, 2, 3, 2);
            btn_PrestarLibro.Name = "btn_PrestarLibro";
            btn_PrestarLibro.Size = new Size(514, 40);
            btn_PrestarLibro.TabIndex = 66;
            btn_PrestarLibro.Text = "Prestar Libro";
            btn_PrestarLibro.UseVisualStyleBackColor = false;
            btn_PrestarLibro.Click += btn_PrestarLibro_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(51, 239);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(721, 217);
            pictureBox1.TabIndex = 67;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Location = new Point(51, 26);
            pictureBox2.Margin = new Padding(4, 4, 4, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(721, 210);
            pictureBox2.TabIndex = 68;
            pictureBox2.TabStop = false;
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
            btnVolver.Size = new Size(109, 40);
            btnVolver.TabIndex = 69;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // labelISBN_D
            // 
            labelISBN_D.AutoSize = true;
            labelISBN_D.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelISBN_D.Location = new Point(65, 291);
            labelISBN_D.Name = "labelISBN_D";
            labelISBN_D.Size = new Size(52, 24);
            labelISBN_D.TabIndex = 70;
            labelISBN_D.Text = "ISBN";
            // 
            // LabelIDD
            // 
            LabelIDD.AutoSize = true;
            LabelIDD.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelIDD.Location = new Point(65, 352);
            LabelIDD.Name = "LabelIDD";
            LabelIDD.Size = new Size(106, 24);
            LabelIDD.TabIndex = 71;
            LabelIDD.Text = "ID Personal";
            // 
            // Prestamos_y_devoluciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(814, 502);
            Controls.Add(LabelIDD);
            Controls.Add(labelISBN_D);
            Controls.Add(btnVolver);
            Controls.Add(btn_PrestarLibro);
            Controls.Add(btn_DevolverLibro);
            Controls.Add(textBoxISBN);
            Controls.Add(LabelID);
            Controls.Add(textBoxNombreD);
            Controls.Add(LabelApellidoD);
            Controls.Add(textBoxAPD);
            Controls.Add(LabelNombreD);
            Controls.Add(label10);
            Controls.Add(textBoxISBND);
            Controls.Add(label11);
            Controls.Add(textBoxIDD);
            Controls.Add(LabelISBN);
            Controls.Add(textBoxAP);
            Controls.Add(LabelApellido);
            Controls.Add(textBoxID);
            Controls.Add(LabelNombre);
            Controls.Add(textBoxNombre);
            Controls.Add(LabelPrestamo);
            Controls.Add(label1);
            Controls.Add(MenuPersonal);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Prestamos_y_devoluciones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Prestamos Y Devoluciones";
            MenuPersonal.ResumeLayout(false);
            MenuPersonal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuPersonal;
        private ToolStripMenuItem librosToolStripMenuItem;
        private ToolStripMenuItem prestamosYDevolucionesToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private Label label1;
        private Label LabelPrestamo;
        private TextBox textBoxNombre;
        private Label LabelNombre;
        private TextBox textBoxID;
        private Label LabelApellido;
        private TextBox textBoxAP;
        private TextBox textBoxIDD;
        private Label LabelISBN;
        private TextBox textBoxISBN;
        private Label LabelID;
        private TextBox textBoxNombreD;
        private Label LabelApellidoD;
        private TextBox textBoxAPD;
        private Label LabelNombreD;
        private Label label10;
        private TextBox textBoxISBND;
        private Label label11;
        private Button btn_DevolverLibro;
        private Button btn_PrestarLibro;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnVolver;
        private Label labelISBN_D;
        private Label LabelIDD;
        private ToolStripMenuItem registroDeUsuariosToolStripMenuItem;
    }
}