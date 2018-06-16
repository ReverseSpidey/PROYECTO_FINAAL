namespace AppDesktop.GUI
{
    partial class SeccionAsientos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nupNinio = new System.Windows.Forms.NumericUpDown();
            this.nupAbuelo = new System.Windows.Forms.NumericUpDown();
            this.nupAdulto = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupNinio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAbuelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAdulto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Niño:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnValidar);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 345);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elegir tipo de boleto";
            // 
            // btnValidar
            // 
            this.btnValidar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(72)))), ((int)(((byte)(21)))));
            this.btnValidar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnValidar.FlatAppearance.BorderSize = 0;
            this.btnValidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidar.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.ForeColor = System.Drawing.Color.White;
            this.btnValidar.Location = new System.Drawing.Point(3, 279);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(282, 63);
            this.btnValidar.TabIndex = 58;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = false;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.nupNinio);
            this.panel1.Controls.Add(this.nupAbuelo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nupAdulto);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 256);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.txtTotal);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 49);
            this.panel2.TabIndex = 8;
            // 
            // txtTotal
            // 
            this.txtTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtTotal.Location = new System.Drawing.Point(203, 0);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(79, 49);
            this.txtTotal.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(-4, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total a pagar:";
            // 
            // nupNinio
            // 
            this.nupNinio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nupNinio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(72)))), ((int)(((byte)(21)))));
            this.nupNinio.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupNinio.ForeColor = System.Drawing.Color.White;
            this.nupNinio.Location = new System.Drawing.Point(13, 39);
            this.nupNinio.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nupNinio.Name = "nupNinio";
            this.nupNinio.Size = new System.Drawing.Size(88, 25);
            this.nupNinio.TabIndex = 5;
            this.nupNinio.ValueChanged += new System.EventHandler(this.nupNinio_ValueChanged);
            // 
            // nupAbuelo
            // 
            this.nupAbuelo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nupAbuelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(72)))), ((int)(((byte)(21)))));
            this.nupAbuelo.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupAbuelo.ForeColor = System.Drawing.Color.White;
            this.nupAbuelo.Location = new System.Drawing.Point(13, 165);
            this.nupAbuelo.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nupAbuelo.Name = "nupAbuelo";
            this.nupAbuelo.Size = new System.Drawing.Size(88, 25);
            this.nupAbuelo.TabIndex = 7;
            this.nupAbuelo.ValueChanged += new System.EventHandler(this.nupAbuelo_ValueChanged);
            // 
            // nupAdulto
            // 
            this.nupAdulto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nupAdulto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(72)))), ((int)(((byte)(21)))));
            this.nupAdulto.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupAdulto.ForeColor = System.Drawing.Color.White;
            this.nupAdulto.Location = new System.Drawing.Point(13, 100);
            this.nupAdulto.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nupAdulto.Name = "nupAdulto";
            this.nupAdulto.Size = new System.Drawing.Size(88, 25);
            this.nupAdulto.TabIndex = 6;
            this.nupAdulto.ValueChanged += new System.EventHandler(this.nupAdulto_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adulto:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adulto (Mayor de 60):\r\n";
            // 
            // SeccionAsientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(10)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(288, 345);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SeccionAsientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeccionAsientos";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupNinio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAbuelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAdulto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nupAbuelo;
        private System.Windows.Forms.NumericUpDown nupAdulto;
        private System.Windows.Forms.NumericUpDown nupNinio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
    }
}