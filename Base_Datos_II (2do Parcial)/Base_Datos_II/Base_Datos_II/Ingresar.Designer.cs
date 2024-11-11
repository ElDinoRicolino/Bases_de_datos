namespace Base_Datos_II
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        /// 
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnPersonal = new Button();
            labelNombre = new Label();
            txtNombre = new TextBox();
            labelContraseña = new Label();
            txtContraseña = new TextBox();
            btnIngresar = new Button();
            btnSalir = new Button();
            btnMiembro = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 32.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(123, 62);
            label1.Name = "label1";
            label1.Size = new Size(538, 51);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido a la biblioteca";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(315, 126);
            label2.Name = "label2";
            label2.Size = new Size(171, 26);
            label2.TabIndex = 1;
            label2.Text = "Ingresar como:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 32.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(279, 164);
            label3.Name = "label3";
            label3.Size = new Size(0, 51);
            label3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 32.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(334, 67);
            label4.Name = "label4";
            label4.Size = new Size(0, 51);
            label4.TabIndex = 3;
            // 
            // btnPersonal
            // 
            btnPersonal.BackColor = Color.FromArgb(59, 130, 246);
            btnPersonal.Cursor = Cursors.Hand;
            btnPersonal.FlatAppearance.BorderColor = Color.FromArgb(59, 130, 246);
            btnPersonal.FlatAppearance.BorderSize = 0;
            btnPersonal.FlatStyle = FlatStyle.Flat;
            btnPersonal.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnPersonal.ForeColor = SystemColors.ButtonFace;
            btnPersonal.Location = new Point(400, 154);
            btnPersonal.Name = "btnPersonal";
            btnPersonal.Size = new Size(135, 52);
            btnPersonal.TabIndex = 6;
            btnPersonal.Text = "Personal";
            btnPersonal.UseVisualStyleBackColor = false;
            btnPersonal.Click += btnPersonal_Click;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.BackColor = Color.FromArgb(243, 244, 246);
            labelNombre.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelNombre.Location = new Point(206, 219);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(85, 24);
            labelNombre.TabIndex = 9;
            labelNombre.Text = "Nombre";
            labelNombre.Visible = false;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(206, 246);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(399, 23);
            txtNombre.TabIndex = 10;
            txtNombre.Visible = false;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // labelContraseña
            // 
            labelContraseña.AutoSize = true;
            labelContraseña.FlatStyle = FlatStyle.Popup;
            labelContraseña.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelContraseña.Location = new Point(201, 276);
            labelContraseña.Name = "labelContraseña";
            labelContraseña.Size = new Size(116, 24);
            labelContraseña.TabIndex = 11;
            labelContraseña.Text = "Contraseña";
            labelContraseña.Visible = false;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(206, 303);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(399, 23);
            txtContraseña.TabIndex = 12;
            txtContraseña.Visible = false;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(107, 114, 128);
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(343, 336);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(125, 40);
            btnIngresar.TabIndex = 13;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Visible = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(252, 165, 165);
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(252, 165, 165);
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Location = new Point(367, 382);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(76, 40);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnMiembro
            // 
            btnMiembro.BackColor = Color.SkyBlue;
            btnMiembro.Cursor = Cursors.Hand;
            btnMiembro.FlatAppearance.BorderColor = Color.FromArgb(59, 130, 246);
            btnMiembro.FlatAppearance.BorderSize = 0;
            btnMiembro.FlatStyle = FlatStyle.Flat;
            btnMiembro.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnMiembro.ForeColor = SystemColors.ActiveCaptionText;
            btnMiembro.Location = new Point(266, 154);
            btnMiembro.Name = "btnMiembro";
            btnMiembro.Size = new Size(135, 52);
            btnMiembro.TabIndex = 16;
            btnMiembro.Text = "Miembro";
            btnMiembro.UseVisualStyleBackColor = false;
            btnMiembro.Click += btnMiembro_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            ClientSize = new Size(814, 502);
            ControlBox = false;
            Controls.Add(btnMiembro);
            Controls.Add(btnSalir);
            Controls.Add(btnIngresar);
            Controls.Add(txtContraseña);
            Controls.Add(labelContraseña);
            Controls.Add(txtNombre);
            Controls.Add(labelNombre);
            Controls.Add(btnPersonal);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Biblioteca";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnPersonal;
        private Label labelNombre;
        private TextBox txtNombre;
        private Label labelContraseña;
        private TextBox txtContraseña;
        private Button btnIngresar;
        private Button btnSalir;
        private Button btnMiembro;
    }


}