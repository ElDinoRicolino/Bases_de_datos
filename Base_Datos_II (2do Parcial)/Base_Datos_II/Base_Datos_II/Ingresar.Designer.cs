﻿namespace Base_Datos_II
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
            labelID = new Label();
            txtid = new TextBox();
            labelNombre = new Label();
            txtNombre = new TextBox();
            labelContraseña = new Label();
            txtContraseña = new TextBox();
            btnIngresarM = new Button();
            btnIngresarP = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 32.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(102, 34);
            label1.Name = "label1";
            label1.Size = new Size(538, 51);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido a la biblioteca";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(294, 98);
            label2.Name = "label2";
            label2.Size = new Size(171, 26);
            label2.TabIndex = 1;
            label2.Text = "Ingresar como:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 32.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(258, 136);
            label3.Name = "label3";
            label3.Size = new Size(0, 51);
            label3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 32.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(313, 39);
            label4.Name = "label4";
            label4.Size = new Size(0, 51);
            label4.TabIndex = 3;
            label4.Click += label4_Click;
            // 
            // btnPersonal
            // 
            btnPersonal.BackColor = Color.FromArgb(59, 130, 246);
            btnPersonal.Cursor = Cursors.Hand;
            btnPersonal.FlatAppearance.BorderColor = Color.FromArgb(59, 130, 246);
            btnPersonal.FlatAppearance.BorderSize = 0;
            btnPersonal.FlatStyle = FlatStyle.Popup;
            btnPersonal.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnPersonal.ForeColor = SystemColors.ButtonFace;
            btnPersonal.Location = new Point(312, 125);
            btnPersonal.Name = "btnPersonal";
            btnPersonal.Size = new Size(135, 52);
            btnPersonal.TabIndex = 6;
            btnPersonal.Text = "Personal";
            btnPersonal.UseVisualStyleBackColor = false;
            btnPersonal.Click += btnPersonal_Click;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelID.Location = new Point(180, 191);
            labelID.Name = "labelID";
            labelID.Size = new Size(29, 24);
            labelID.TabIndex = 7;
            labelID.Text = "ID";
            labelID.Visible = false;
            // 
            // txtid
            // 
            txtid.Location = new Point(185, 218);
            txtid.Multiline = true;
            txtid.Name = "txtid";
            txtid.Size = new Size(399, 27);
            txtid.TabIndex = 8;
            txtid.Visible = false;
            txtid.TextChanged += txtid_TextChanged;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.BackColor = Color.FromArgb(243, 244, 246);
            labelNombre.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelNombre.Location = new Point(180, 191);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(85, 24);
            labelNombre.TabIndex = 9;
            labelNombre.Text = "Nombre";
            labelNombre.Visible = false;
            labelNombre.Click += label6_Click;
            // 
            // txtNombre
            // 
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Location = new Point(185, 218);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(399, 27);
            txtNombre.TabIndex = 10;
            txtNombre.Visible = false;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // labelContraseña
            // 
            labelContraseña.AutoSize = true;
            labelContraseña.FlatStyle = FlatStyle.Popup;
            labelContraseña.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelContraseña.Location = new Point(180, 248);
            labelContraseña.Name = "labelContraseña";
            labelContraseña.Size = new Size(116, 24);
            labelContraseña.TabIndex = 11;
            labelContraseña.Text = "Contraseña";
            labelContraseña.Visible = false;
            labelContraseña.Click += labelContraseña_Click;
            // 
            // txtContraseña
            // 
            txtContraseña.Cursor = Cursors.IBeam;
            txtContraseña.Location = new Point(185, 275);
            txtContraseña.Multiline = true;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(399, 27);
            txtContraseña.TabIndex = 12;
            txtContraseña.Visible = false;
            // 
            // btnIngresarM
            // 
            btnIngresarM.BackColor = Color.FromArgb(107, 114, 128);
            btnIngresarM.FlatAppearance.BorderSize = 0;
            btnIngresarM.FlatStyle = FlatStyle.Popup;
            btnIngresarM.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresarM.ForeColor = Color.White;
            btnIngresarM.Location = new Point(322, 308);
            btnIngresarM.Name = "btnIngresarM";
            btnIngresarM.Size = new Size(125, 40);
            btnIngresarM.TabIndex = 13;
            btnIngresarM.Text = "Ingresar";
            btnIngresarM.UseVisualStyleBackColor = false;
            btnIngresarM.Visible = false;
            btnIngresarM.Click += btnIngresarM_Click;
            // 
            // btnIngresarP
            // 
            btnIngresarP.BackColor = Color.FromArgb(107, 114, 128);
            btnIngresarP.Cursor = Cursors.Hand;
            btnIngresarP.FlatAppearance.BorderColor = Color.FromArgb(107, 114, 128);
            btnIngresarP.FlatAppearance.BorderSize = 0;
            btnIngresarP.FlatStyle = FlatStyle.Popup;
            btnIngresarP.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresarP.ForeColor = Color.White;
            btnIngresarP.Location = new Point(322, 308);
            btnIngresarP.Name = "btnIngresarP";
            btnIngresarP.Size = new Size(125, 40);
            btnIngresarP.TabIndex = 14;
            btnIngresarP.Text = "Ingresar";
            btnIngresarP.UseVisualStyleBackColor = false;
            btnIngresarP.Visible = false;
            btnIngresarP.Click += btnIngresarP_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(252, 165, 165);
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(252, 165, 165);
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Location = new Point(346, 354);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(76, 40);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            ClientSize = new Size(794, 464);
            ControlBox = false;
            Controls.Add(btnSalir);
            Controls.Add(btnIngresarP);
            Controls.Add(btnIngresarM);
            Controls.Add(txtContraseña);
            Controls.Add(labelContraseña);
            Controls.Add(txtNombre);
            Controls.Add(labelNombre);
            Controls.Add(txtid);
            Controls.Add(labelID);
            Controls.Add(btnPersonal);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
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
        private Label labelID;
        private TextBox txtid;
        private Label labelNombre;
        private TextBox txtNombre;
        private Label labelContraseña;
        private TextBox txtContraseña;
        private Button btnIngresarM;
        private Button btnIngresarP;
        private Button btnSalir;
    }


}