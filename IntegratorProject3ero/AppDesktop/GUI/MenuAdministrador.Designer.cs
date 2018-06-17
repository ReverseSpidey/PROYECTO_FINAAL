namespace AppDesktop.GUI
{
    partial class MenuAdministrador
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
            this.components = new System.ComponentModel.Container();
            this.pan = new System.Windows.Forms.Panel();
            this.layout_Contenido = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlCatalogos = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelcine = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAsiento = new System.Windows.Forms.Button();
            this.btnSala = new System.Windows.Forms.Button();
            this.btnPelicula2 = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnPelicula = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.pan.SuspendLayout();
            this.layout_Contenido.SuspendLayout();
            this.pnlCatalogos.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pan
            // 
            this.pan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(72)))), ((int)(((byte)(21)))));
            this.pan.Controls.Add(this.layout_Contenido);
            this.pan.Controls.Add(this.btnPelicula);
            this.pan.Controls.Add(this.panel3);
            this.pan.Dock = System.Windows.Forms.DockStyle.Left;
            this.pan.Location = new System.Drawing.Point(0, 0);
            this.pan.Name = "pan";
            this.pan.Size = new System.Drawing.Size(133, 657);
            this.pan.TabIndex = 0;
            // 
            // layout_Contenido
            // 
            this.layout_Contenido.Controls.Add(this.btnAsiento);
            this.layout_Contenido.Controls.Add(this.pnlCatalogos);
            this.layout_Contenido.Controls.Add(this.btnUsuarios);
            this.layout_Contenido.Controls.Add(this.btnCerrar);
            this.layout_Contenido.Location = new System.Drawing.Point(3, 187);
            this.layout_Contenido.Name = "layout_Contenido";
            this.layout_Contenido.Size = new System.Drawing.Size(158, 458);
            this.layout_Contenido.TabIndex = 0;
            // 
            // pnlCatalogos
            // 
            this.pnlCatalogos.Controls.Add(this.btnSala);
            this.pnlCatalogos.Controls.Add(this.btnPelicula2);
            this.pnlCatalogos.Location = new System.Drawing.Point(3, 60);
            this.pnlCatalogos.Name = "pnlCatalogos";
            this.pnlCatalogos.Size = new System.Drawing.Size(127, 92);
            this.pnlCatalogos.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(72)))), ((int)(((byte)(21)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(133, 84);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, -34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 117);
            this.label1.TabIndex = 0;
            // 
            // panelcine
            // 
            this.panelcine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(10)))), ((int)(((byte)(18)))));
            this.panelcine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelcine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcine.Location = new System.Drawing.Point(133, 0);
            this.panelcine.Name = "panelcine";
            this.panelcine.Size = new System.Drawing.Size(906, 657);
            this.panelcine.TabIndex = 0;
            this.panelcine.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelcine_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 30);
            this.label4.TabIndex = 16;
            this.label4.Text = "Administrador:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(72)))), ((int)(((byte)(21)))));
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(133, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 49);
            this.panel1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(861, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "_";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(881, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // btnAsiento
            // 
            this.btnAsiento.FlatAppearance.BorderSize = 0;
            this.btnAsiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsiento.ForeColor = System.Drawing.Color.White;
            this.btnAsiento.Image = global::AppDesktop.Properties.Resources.Silla;
            this.btnAsiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsiento.Location = new System.Drawing.Point(3, 3);
            this.btnAsiento.Name = "btnAsiento";
            this.btnAsiento.Size = new System.Drawing.Size(127, 51);
            this.btnAsiento.TabIndex = 3;
            this.btnAsiento.Text = "Asiento";
            this.btnAsiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAsiento.UseVisualStyleBackColor = true;
            this.btnAsiento.Click += new System.EventHandler(this.btnAsiento_Click);
            // 
            // btnSala
            // 
            this.btnSala.FlatAppearance.BorderSize = 0;
            this.btnSala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSala.ForeColor = System.Drawing.Color.White;
            this.btnSala.Image = global::AppDesktop.Properties.Resources.Sala;
            this.btnSala.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSala.Location = new System.Drawing.Point(-3, 62);
            this.btnSala.Name = "btnSala";
            this.btnSala.Size = new System.Drawing.Size(127, 45);
            this.btnSala.TabIndex = 1;
            this.btnSala.Text = "Sala";
            this.btnSala.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSala.UseVisualStyleBackColor = true;
            this.btnSala.Click += new System.EventHandler(this.btnSala_Click);
            // 
            // btnPelicula2
            // 
            this.btnPelicula2.FlatAppearance.BorderSize = 0;
            this.btnPelicula2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPelicula2.ForeColor = System.Drawing.Color.White;
            this.btnPelicula2.Image = global::AppDesktop.Properties.Resources.Flash;
            this.btnPelicula2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPelicula2.Location = new System.Drawing.Point(0, -1);
            this.btnPelicula2.Name = "btnPelicula2";
            this.btnPelicula2.Size = new System.Drawing.Size(127, 57);
            this.btnPelicula2.TabIndex = 0;
            this.btnPelicula2.Text = "Pelicula";
            this.btnPelicula2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPelicula2.UseVisualStyleBackColor = true;
            this.btnPelicula2.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Image = global::AppDesktop.Properties.Resources.Empleado;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(3, 158);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(133, 61);
            this.btnUsuarios.TabIndex = 3;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Image = global::AppDesktop.Properties.Resources.Exit1;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(3, 225);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(133, 65);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnPelicula
            // 
            this.btnPelicula.FlatAppearance.BorderSize = 0;
            this.btnPelicula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPelicula.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnPelicula.ForeColor = System.Drawing.Color.White;
            this.btnPelicula.Image = global::AppDesktop.Properties.Resources.Configuracion;
            this.btnPelicula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPelicula.Location = new System.Drawing.Point(3, 117);
            this.btnPelicula.Name = "btnPelicula";
            this.btnPelicula.Size = new System.Drawing.Size(130, 67);
            this.btnPelicula.TabIndex = 1;
            this.btnPelicula.Text = "Agregar";
            this.btnPelicula.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPelicula.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPelicula.UseVisualStyleBackColor = true;
            this.btnPelicula.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppDesktop.Properties.Resources.ImagenCine;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(491, 12);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(95, 30);
            this.lblFecha.TabIndex = 18;
            this.lblFecha.Text = "Fecha:";
            // 
            // MenuAdministrador
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(10)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1039, 657);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelcine);
            this.Controls.Add(this.pan);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuAdministrador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuAdministrador_MouseMove);
            this.pan.ResumeLayout(false);
            this.layout_Contenido.ResumeLayout(false);
            this.pnlCatalogos.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelcine;
        private System.Windows.Forms.Panel pnlCatalogos;
        private System.Windows.Forms.Button btnPelicula2;
        private System.Windows.Forms.Button btnAsiento;
        private System.Windows.Forms.Button btnSala;
        private System.Windows.Forms.FlowLayoutPanel layout_Contenido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnPelicula;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFecha;
    }
}