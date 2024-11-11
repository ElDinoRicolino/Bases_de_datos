namespace Base_Datos_II
{
    partial class Registrar_Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registrar_Usuarios));
            MenuPersonal = new MenuStrip();
            librosToolStripMenuItem = new ToolStripMenuItem();
            prestamosYDevolucionesToolStripMenuItem = new ToolStripMenuItem();
            registroDeUsuariosToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            btnVolver = new Button();
            LabelPrestamo = new Label();
            LabelINombre = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNombre = new TextBox();
            txtAP = new TextBox();
            txtAM = new TextBox();
            pictureBox1 = new PictureBox();
            txtCorreo = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            btnAgregarUsuario = new Button();
            btnAgregarPersonal = new Button();
            MenuPersonal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            MenuPersonal.TabIndex = 46;
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
            prestamosYDevolucionesToolStripMenuItem.Click += prestamosYDevolucionesToolStripMenuItem_Click;
            // 
            // registroDeUsuariosToolStripMenuItem
            // 
            registroDeUsuariosToolStripMenuItem.Name = "registroDeUsuariosToolStripMenuItem";
            registroDeUsuariosToolStripMenuItem.Size = new Size(127, 20);
            registroDeUsuariosToolStripMenuItem.Text = "Registro De Usuarios";
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Padding = new Padding(18, 0, 4, 0);
            reportesToolStripMenuItem.Size = new Size(79, 20);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Crimson;
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.FlatAppearance.BorderColor = Color.Crimson;
            btnVolver.FlatStyle = FlatStyle.Popup;
            btnVolver.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.ForeColor = SystemColors.ButtonFace;
            btnVolver.Location = new Point(693, 450);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(109, 40);
            btnVolver.TabIndex = 70;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // LabelPrestamo
            // 
            LabelPrestamo.AutoSize = true;
            LabelPrestamo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            LabelPrestamo.Location = new Point(32, 43);
            LabelPrestamo.Name = "LabelPrestamo";
            LabelPrestamo.Size = new Size(437, 30);
            LabelPrestamo.TabIndex = 71;
            LabelPrestamo.Text = "Registro para usuarios nuevos o personal";
            // 
            // LabelINombre
            // 
            LabelINombre.AutoSize = true;
            LabelINombre.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelINombre.Location = new Point(32, 92);
            LabelINombre.Name = "LabelINombre";
            LabelINombre.Size = new Size(79, 24);
            LabelINombre.TabIndex = 72;
            LabelINombre.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(32, 150);
            label1.Name = "label1";
            label1.Size = new Size(149, 24);
            label1.TabIndex = 73;
            label1.Text = "Apellido Paterno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(32, 206);
            label2.Name = "label2";
            label2.Size = new Size(153, 24);
            label2.TabIndex = 74;
            label2.Text = "Apellido Materno";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(32, 262);
            label3.Name = "label3";
            label3.Size = new Size(90, 24);
            label3.TabIndex = 75;
            label3.Text = "Direccion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(32, 318);
            label4.Name = "label4";
            label4.Size = new Size(85, 24);
            label4.TabIndex = 76;
            label4.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(32, 374);
            label5.Name = "label5";
            label5.Size = new Size(168, 24);
            label5.TabIndex = 77;
            label5.Text = "Correo Electronico";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(117, 96);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(191, 23);
            txtNombre.TabIndex = 78;
            // 
            // txtAP
            // 
            txtAP.Location = new Point(187, 151);
            txtAP.Margin = new Padding(3, 2, 3, 2);
            txtAP.Name = "txtAP";
            txtAP.Size = new Size(191, 23);
            txtAP.TabIndex = 79;
            // 
            // txtAM
            // 
            txtAM.Location = new Point(187, 207);
            txtAM.Margin = new Padding(3, 2, 3, 2);
            txtAM.Name = "txtAM";
            txtAM.Size = new Size(191, 23);
            txtAM.TabIndex = 80;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(12, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(790, 392);
            pictureBox1.TabIndex = 81;
            pictureBox1.TabStop = false;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(206, 375);
            txtCorreo.Margin = new Padding(3, 2, 3, 2);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(238, 23);
            txtCorreo.TabIndex = 82;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(128, 263);
            txtDireccion.Margin = new Padding(3, 2, 3, 2);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(250, 23);
            txtDireccion.TabIndex = 83;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(123, 319);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(191, 23);
            txtTelefono.TabIndex = 84;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.BackColor = Color.FromArgb(59, 130, 246);
            btnAgregarUsuario.Cursor = Cursors.Hand;
            btnAgregarUsuario.FlatAppearance.BorderColor = Color.FromArgb(59, 130, 246);
            btnAgregarUsuario.FlatStyle = FlatStyle.Popup;
            btnAgregarUsuario.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarUsuario.ForeColor = Color.White;
            btnAgregarUsuario.Location = new Point(264, 450);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(203, 40);
            btnAgregarUsuario.TabIndex = 85;
            btnAgregarUsuario.Text = "Agregar Usuario";
            btnAgregarUsuario.UseVisualStyleBackColor = false;
            btnAgregarUsuario.Click += btnAgregarUsuario_Click;
            // 
            // btnAgregarPersonal
            // 
            btnAgregarPersonal.BackColor = Color.FromArgb(59, 130, 246);
            btnAgregarPersonal.Cursor = Cursors.Hand;
            btnAgregarPersonal.FlatAppearance.BorderColor = Color.FromArgb(59, 130, 246);
            btnAgregarPersonal.FlatStyle = FlatStyle.Popup;
            btnAgregarPersonal.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarPersonal.ForeColor = Color.White;
            btnAgregarPersonal.Location = new Point(473, 450);
            btnAgregarPersonal.Name = "btnAgregarPersonal";
            btnAgregarPersonal.Size = new Size(214, 40);
            btnAgregarPersonal.TabIndex = 86;
            btnAgregarPersonal.Text = "Agregar Personal";
            btnAgregarPersonal.UseVisualStyleBackColor = false;
            btnAgregarPersonal.Click += btnAgregarPersonal_Click;
            // 
            // Registrar_Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(814, 502);
            Controls.Add(btnAgregarPersonal);
            Controls.Add(btnAgregarUsuario);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(txtCorreo);
            Controls.Add(txtAM);
            Controls.Add(txtAP);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LabelINombre);
            Controls.Add(LabelPrestamo);
            Controls.Add(btnVolver);
            Controls.Add(MenuPersonal);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Registrar_Usuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro De Usuarios";
            MenuPersonal.ResumeLayout(false);
            MenuPersonal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuPersonal;
        private ToolStripMenuItem librosToolStripMenuItem;
        private ToolStripMenuItem prestamosYDevolucionesToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem registroDeUsuariosToolStripMenuItem;
        private Button btnVolver;
        private Label LabelPrestamo;
        private Label LabelINombre;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNombre;
        private TextBox txtAP;
        private TextBox txtAM;
        private PictureBox pictureBox1;
        private TextBox txtCorreo;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private Button btnAgregarUsuario;
        private Button btnAgregarPersonal;
    }
}