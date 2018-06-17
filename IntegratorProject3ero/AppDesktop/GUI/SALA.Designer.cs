namespace AppDesktop.GUI
{
    partial class SALA
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.nupCodigo = new System.Windows.Forms.NumericUpDown();
            this.btnValidar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSala = new System.Windows.Forms.DataGridView();
            this.Cod_sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num_sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ver = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.picMinimizar = new System.Windows.Forms.PictureBox();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.nupCodigo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvSala);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 314);
            this.panel1.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(72)))), ((int)(((byte)(21)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(314, 16);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(84, 29);
            this.btnBuscar.TabIndex = 56;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // nupCodigo
            // 
            this.nupCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nupCodigo.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupCodigo.Location = new System.Drawing.Point(245, 18);
            this.nupCodigo.Name = "nupCodigo";
            this.nupCodigo.Size = new System.Drawing.Size(50, 25);
            this.nupCodigo.TabIndex = 5;
            // 
            // btnValidar
            // 
            this.btnValidar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(72)))), ((int)(((byte)(21)))));
            this.btnValidar.FlatAppearance.BorderSize = 0;
            this.btnValidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnValidar.ForeColor = System.Drawing.Color.White;
            this.btnValidar.Location = new System.Drawing.Point(352, 11);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(90, 32);
            this.btnValidar.TabIndex = 55;
            this.btnValidar.Text = "Nueva Sala";
            this.btnValidar.UseVisualStyleBackColor = false;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(145, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "N° de Sala:";
            // 
            // dgvSala
            // 
            this.dgvSala.AllowUserToAddRows = false;
            this.dgvSala.AllowUserToDeleteRows = false;
            this.dgvSala.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSala.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSala.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSala.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod_sala,
            this.Num_sala,
            this.cod_tipo,
            this.Tipo,
            this.Ver});
            this.dgvSala.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSala.EnableHeadersVisualStyles = false;
            this.dgvSala.GridColor = System.Drawing.Color.White;
            this.dgvSala.Location = new System.Drawing.Point(0, 56);
            this.dgvSala.Name = "dgvSala";
            this.dgvSala.ReadOnly = true;
            this.dgvSala.Size = new System.Drawing.Size(539, 258);
            this.dgvSala.TabIndex = 0;
            this.dgvSala.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickColumn);
            // 
            // Cod_sala
            // 
            this.Cod_sala.DataPropertyName = "Cod_sala";
            this.Cod_sala.HeaderText = "Código";
            this.Cod_sala.Name = "Cod_sala";
            this.Cod_sala.ReadOnly = true;
            // 
            // Num_sala
            // 
            this.Num_sala.DataPropertyName = "Num_sala";
            this.Num_sala.HeaderText = "N° Sala";
            this.Num_sala.Name = "Num_sala";
            this.Num_sala.ReadOnly = true;
            // 
            // cod_tipo
            // 
            this.cod_tipo.DataPropertyName = "cod_tipo";
            this.cod_tipo.HeaderText = "Código Tipo";
            this.cod_tipo.Name = "cod_tipo";
            this.cod_tipo.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "NombreSala_tipo";
            this.Tipo.HeaderText = "Tipo de Sala";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Ver
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(72)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.Ver.DefaultCellStyle = dataGridViewCellStyle4;
            this.Ver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ver.HeaderText = "";
            this.Ver.Name = "Ver";
            this.Ver.ReadOnly = true;
            this.Ver.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ver.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Ver.Text = "Ver";
            this.Ver.UseColumnTextForButtonValue = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 59;
            this.label3.Text = "SALAS";
            // 
            // picMinimizar
            // 
            this.picMinimizar.Image = global::AppDesktop.Properties.Resources.Minimizar_32;
            this.picMinimizar.Location = new System.Drawing.Point(473, 12);
            this.picMinimizar.Name = "picMinimizar";
            this.picMinimizar.Size = new System.Drawing.Size(24, 23);
            this.picMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMinimizar.TabIndex = 58;
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
            this.picCerrar.TabIndex = 57;
            this.picCerrar.TabStop = false;
            this.picCerrar.Click += new System.EventHandler(this.picCerrar_Click);
            // 
            // SALA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(10)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(539, 363);
            this.Controls.Add(this.picMinimizar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.picCerrar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SALA";
            this.Text = "SALA";
            this.Load += new System.EventHandler(this.SALA_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvSala;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.NumericUpDown nupCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_sala;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_sala;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewButtonColumn Ver;
        private System.Windows.Forms.PictureBox picMinimizar;
        private System.Windows.Forms.PictureBox picCerrar;
    }
}