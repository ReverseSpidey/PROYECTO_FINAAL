namespace AppDesktop.GUI
{
    partial class MenuPeliculas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picMinimizar = new System.Windows.Forms.PictureBox();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvHorarios = new System.Windows.Forms.DataGridView();
            this.ID_funcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUM_SALA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_peli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora_ini = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnElegir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cboPeliculas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 34);
            this.panel1.TabIndex = 0;
            // 
            // picMinimizar
            // 
            this.picMinimizar.Image = global::AppDesktop.Properties.Resources.Minimizar_32;
            this.picMinimizar.Location = new System.Drawing.Point(157, 4);
            this.picMinimizar.Name = "picMinimizar";
            this.picMinimizar.Size = new System.Drawing.Size(24, 23);
            this.picMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMinimizar.TabIndex = 62;
            this.picMinimizar.TabStop = false;
            // 
            // picCerrar
            // 
            this.picCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.picCerrar.Image = global::AppDesktop.Properties.Resources.cerrar_32;
            this.picCerrar.Location = new System.Drawing.Point(176, 0);
            this.picCerrar.Name = "picCerrar";
            this.picCerrar.Size = new System.Drawing.Size(24, 27);
            this.picCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCerrar.TabIndex = 61;
            this.picCerrar.TabStop = false;
            this.picCerrar.Click += new System.EventHandler(this.picCerrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 24);
            this.label3.TabIndex = 60;
            this.label3.Text = "Búsqueda de Funciones";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(659, 433);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvHorarios);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(659, 433);
            this.panel3.TabIndex = 3;
            // 
            // dgvHorarios
            // 
            this.dgvHorarios.AllowUserToAddRows = false;
            this.dgvHorarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.dgvHorarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvHorarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHorarios.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvHorarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvHorarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(72)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHorarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_funcion,
            this.NUM_SALA,
            this.cod_sala,
            this.tipo_sala,
            this.nombre_peli,
            this.Hora_ini,
            this.btnElegir});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHorarios.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgvHorarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHorarios.EnableHeadersVisualStyles = false;
            this.dgvHorarios.GridColor = System.Drawing.Color.White;
            this.dgvHorarios.Location = new System.Drawing.Point(0, 62);
            this.dgvHorarios.Name = "dgvHorarios";
            this.dgvHorarios.ReadOnly = true;
            this.dgvHorarios.Size = new System.Drawing.Size(659, 371);
            this.dgvHorarios.TabIndex = 4;
            this.dgvHorarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHorarios_CellContentClick);
            // 
            // ID_funcion
            // 
            this.ID_funcion.DataPropertyName = "ID_funcion";
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ID_funcion.DefaultCellStyle = dataGridViewCellStyle11;
            this.ID_funcion.HeaderText = "ID Funcion";
            this.ID_funcion.Name = "ID_funcion";
            this.ID_funcion.ReadOnly = true;
            // 
            // NUM_SALA
            // 
            this.NUM_SALA.DataPropertyName = "NUM_SALA";
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUM_SALA.DefaultCellStyle = dataGridViewCellStyle12;
            this.NUM_SALA.HeaderText = "Sala";
            this.NUM_SALA.Name = "NUM_SALA";
            this.NUM_SALA.ReadOnly = true;
            // 
            // cod_sala
            // 
            this.cod_sala.DataPropertyName = "cod_sala";
            this.cod_sala.HeaderText = "id sala";
            this.cod_sala.Name = "cod_sala";
            this.cod_sala.ReadOnly = true;
            // 
            // tipo_sala
            // 
            this.tipo_sala.DataPropertyName = "tipo_sala";
            this.tipo_sala.HeaderText = "Tipo de Sala";
            this.tipo_sala.Name = "tipo_sala";
            this.tipo_sala.ReadOnly = true;
            // 
            // nombre_peli
            // 
            this.nombre_peli.DataPropertyName = "nombre_peli";
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_peli.DefaultCellStyle = dataGridViewCellStyle13;
            this.nombre_peli.HeaderText = "Película";
            this.nombre_peli.Name = "nombre_peli";
            this.nombre_peli.ReadOnly = true;
            // 
            // Hora_ini
            // 
            this.Hora_ini.DataPropertyName = "Hora_ini";
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hora_ini.DefaultCellStyle = dataGridViewCellStyle14;
            this.Hora_ini.HeaderText = "Horario";
            this.Hora_ini.Name = "Hora_ini";
            this.Hora_ini.ReadOnly = true;
            // 
            // btnElegir
            // 
            this.btnElegir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(72)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            this.btnElegir.DefaultCellStyle = dataGridViewCellStyle15;
            this.btnElegir.FillWeight = 150F;
            this.btnElegir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElegir.HeaderText = "";
            this.btnElegir.Name = "btnElegir";
            this.btnElegir.ReadOnly = true;
            this.btnElegir.Text = "Elegir";
            this.btnElegir.UseColumnTextForButtonValue = true;
            this.btnElegir.Width = 150;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnBuscar);
            this.panel4.Controls.Add(this.cboPeliculas);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(659, 62);
            this.panel4.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(72)))), ((int)(((byte)(21)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(483, 13);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(103, 32);
            this.btnBuscar.TabIndex = 57;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cboPeliculas
            // 
            this.cboPeliculas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeliculas.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPeliculas.FormattingEnabled = true;
            this.cboPeliculas.Location = new System.Drawing.Point(283, 15);
            this.cboPeliculas.Name = "cboPeliculas";
            this.cboPeliculas.Size = new System.Drawing.Size(188, 30);
            this.cboPeliculas.TabIndex = 0;
            this.cboPeliculas.Click += new System.EventHandler(this.cboPeliculas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(89, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione la película";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.picCerrar);
            this.panel5.Controls.Add(this.picMinimizar);
            this.panel5.ForeColor = System.Drawing.Color.Coral;
            this.panel5.Location = new System.Drawing.Point(459, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 27);
            this.panel5.TabIndex = 63;
            // 
            // MenuPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(10)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(659, 467);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPeliculas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPeliculas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MenuPeliculas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPeliculas;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvHorarios;
        private System.Windows.Forms.PictureBox picMinimizar;
        private System.Windows.Forms.PictureBox picCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_funcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_SALA;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_sala;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_sala;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_peli;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora_ini;
        private System.Windows.Forms.DataGridViewButtonColumn btnElegir;
        private System.Windows.Forms.Panel panel5;
    }
}