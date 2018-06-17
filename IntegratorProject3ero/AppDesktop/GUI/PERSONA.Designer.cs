namespace AppDesktop.GUI
{
    partial class frm_PERSONA
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gpbDatosUsuario = new System.Windows.Forms.GroupBox();
            this.mxttelefono = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mxtMaterno = new System.Windows.Forms.MaskedTextBox();
            this.mxtNombre = new System.Windows.Forms.MaskedTextBox();
            this.mxtPaterno = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboTipoUsuario = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.bntGuardarYSeguir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.picMinimizar = new System.Windows.Forms.PictureBox();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.gpbDatosUsuario.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre(s):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(34, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "E-mail:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(256, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 21);
            this.label6.TabIndex = 21;
            this.label6.Text = "Contraseña:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(34, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 21);
            this.label8.TabIndex = 29;
            this.label8.Text = "A. Paterno:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(291, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 21);
            this.label9.TabIndex = 31;
            this.label9.Text = "A. Materno:";
            // 
            // gpbDatosUsuario
            // 
            this.gpbDatosUsuario.Controls.Add(this.mxttelefono);
            this.gpbDatosUsuario.Controls.Add(this.label2);
            this.gpbDatosUsuario.Controls.Add(this.mxtMaterno);
            this.gpbDatosUsuario.Controls.Add(this.label1);
            this.gpbDatosUsuario.Controls.Add(this.mxtNombre);
            this.gpbDatosUsuario.Controls.Add(this.label8);
            this.gpbDatosUsuario.Controls.Add(this.mxtPaterno);
            this.gpbDatosUsuario.Controls.Add(this.label9);
            this.gpbDatosUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpbDatosUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDatosUsuario.ForeColor = System.Drawing.Color.White;
            this.gpbDatosUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gpbDatosUsuario.Location = new System.Drawing.Point(12, 27);
            this.gpbDatosUsuario.Name = "gpbDatosUsuario";
            this.gpbDatosUsuario.Size = new System.Drawing.Size(514, 121);
            this.gpbDatosUsuario.TabIndex = 38;
            this.gpbDatosUsuario.TabStop = false;
            this.gpbDatosUsuario.Text = "Datos del empleado";
            // 
            // mxttelefono
            // 
            this.mxttelefono.Location = new System.Drawing.Point(396, 73);
            this.mxttelefono.Mask = "??????????????????????????????????????????????????????????????";
            this.mxttelefono.Name = "mxttelefono";
            this.mxttelefono.PromptChar = ' ';
            this.mxttelefono.Size = new System.Drawing.Size(106, 27);
            this.mxttelefono.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(310, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 33;
            this.label2.Text = "Teléfono:";
            // 
            // mxtMaterno
            // 
            this.mxtMaterno.Location = new System.Drawing.Point(396, 28);
            this.mxtMaterno.Mask = "??????????????????????????????????????????????????????????????";
            this.mxtMaterno.Name = "mxtMaterno";
            this.mxtMaterno.PromptChar = ' ';
            this.mxtMaterno.Size = new System.Drawing.Size(106, 27);
            this.mxtMaterno.TabIndex = 32;
            // 
            // mxtNombre
            // 
            this.mxtNombre.Location = new System.Drawing.Point(131, 26);
            this.mxtNombre.Mask = "??????????????????????????????????????????????????????????????";
            this.mxtNombre.Name = "mxtNombre";
            this.mxtNombre.PromptChar = ' ';
            this.mxtNombre.Size = new System.Drawing.Size(117, 27);
            this.mxtNombre.TabIndex = 11;
            // 
            // mxtPaterno
            // 
            this.mxtPaterno.Location = new System.Drawing.Point(131, 73);
            this.mxtPaterno.Mask = "??????????????????????????????????????????????????????????????";
            this.mxtPaterno.Name = "mxtPaterno";
            this.mxtPaterno.PromptChar = ' ';
            this.mxtPaterno.Size = new System.Drawing.Size(117, 27);
            this.mxtPaterno.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboTipoUsuario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtContrasenia);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(13, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 130);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acceso a cuenta";
            // 
            // cboTipoUsuario
            // 
            this.cboTipoUsuario.FormattingEnabled = true;
            this.cboTipoUsuario.Location = new System.Drawing.Point(249, 82);
            this.cboTipoUsuario.Name = "cboTipoUsuario";
            this.cboTipoUsuario.Size = new System.Drawing.Size(121, 27);
            this.cboTipoUsuario.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(126, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "Tipo de usuario";
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(365, 38);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(106, 27);
            this.txtContrasenia.TabIndex = 28;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(100, 38);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(117, 27);
            this.txtEmail.TabIndex = 22;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(72)))), ((int)(((byte)(21)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(13, 322);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(77, 29);
            this.btnGuardar.TabIndex = 41;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(72)))), ((int)(((byte)(21)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(358, 322);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 29);
            this.btnCancelar.TabIndex = 42;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // bntGuardarYSeguir
            // 
            this.bntGuardarYSeguir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(72)))), ((int)(((byte)(21)))));
            this.bntGuardarYSeguir.FlatAppearance.BorderSize = 0;
            this.bntGuardarYSeguir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntGuardarYSeguir.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bntGuardarYSeguir.ForeColor = System.Drawing.Color.White;
            this.bntGuardarYSeguir.Location = new System.Drawing.Point(96, 322);
            this.bntGuardarYSeguir.Name = "bntGuardarYSeguir";
            this.bntGuardarYSeguir.Size = new System.Drawing.Size(173, 29);
            this.bntGuardarYSeguir.TabIndex = 45;
            this.bntGuardarYSeguir.Text = "Guardar y seguir guardando";
            this.bntGuardarYSeguir.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(72)))), ((int)(((byte)(21)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(275, 322);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(77, 29);
            this.btnEliminar.TabIndex = 46;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(72)))), ((int)(((byte)(21)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(451, 322);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 29);
            this.btnLimpiar.TabIndex = 47;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // picMinimizar
            // 
            this.picMinimizar.Image = global::AppDesktop.Properties.Resources.Minimizar_32;
            this.picMinimizar.Location = new System.Drawing.Point(473, 12);
            this.picMinimizar.Name = "picMinimizar";
            this.picMinimizar.Size = new System.Drawing.Size(24, 23);
            this.picMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMinimizar.TabIndex = 44;
            this.picMinimizar.TabStop = false;
            this.picMinimizar.Click += new System.EventHandler(this.picMinimizar_Click);
            // 
            // picCerrar
            // 
            this.picCerrar.Image = global::AppDesktop.Properties.Resources.cerrar_32;
            this.picCerrar.Location = new System.Drawing.Point(503, 12);
            this.picCerrar.Name = "picCerrar";
            this.picCerrar.Size = new System.Drawing.Size(24, 23);
            this.picCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCerrar.TabIndex = 43;
            this.picCerrar.TabStop = false;
            this.picCerrar.Click += new System.EventHandler(this.picCerrar_Click_1);
            // 
            // frm_PERSONA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(10)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(539, 363);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.bntGuardarYSeguir);
            this.Controls.Add(this.picMinimizar);
            this.Controls.Add(this.picCerrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpbDatosUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_PERSONA";
            this.Text = "PERSONA";
            this.Load += new System.EventHandler(this.PERSONA_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PERSONA_MouseMove);
            this.gpbDatosUsuario.ResumeLayout(false);
            this.gpbDatosUsuario.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gpbDatosUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mxttelefono;
        private System.Windows.Forms.MaskedTextBox mxtMaterno;
        private System.Windows.Forms.MaskedTextBox mxtNombre;
        private System.Windows.Forms.MaskedTextBox mxtPaterno;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.PictureBox picCerrar;
        private System.Windows.Forms.PictureBox picMinimizar;
        private System.Windows.Forms.ComboBox cboTipoUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bntGuardarYSeguir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}