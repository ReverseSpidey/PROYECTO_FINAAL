namespace AppDesktop.GUI
{
    partial class Asientos_Elegir
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Cuerpo = new System.Windows.Forms.Panel();
            this.picPantalla = new System.Windows.Forms.PictureBox();
            this.pnlNombre = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picPantalla)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 52);
            this.panel1.TabIndex = 4;
            // 
            // Cuerpo
            // 
            this.Cuerpo.AutoSize = true;
            this.Cuerpo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Cuerpo.Location = new System.Drawing.Point(68, 125);
            this.Cuerpo.Name = "Cuerpo";
            this.Cuerpo.Size = new System.Drawing.Size(0, 0);
            this.Cuerpo.TabIndex = 6;
            // 
            // picPantalla
            // 
            this.picPantalla.Dock = System.Windows.Forms.DockStyle.Top;
            this.picPantalla.Image = global::AppDesktop.Properties.Resources.SeatScreen;
            this.picPantalla.Location = new System.Drawing.Point(0, 52);
            this.picPantalla.Name = "picPantalla";
            this.picPantalla.Size = new System.Drawing.Size(760, 46);
            this.picPantalla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPantalla.TabIndex = 5;
            this.picPantalla.TabStop = false;
            // 
            // pnlNombre
            // 
            this.pnlNombre.AutoSize = true;
            this.pnlNombre.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlNombre.Location = new System.Drawing.Point(37, 136);
            this.pnlNombre.Name = "pnlNombre";
            this.pnlNombre.Size = new System.Drawing.Size(0, 0);
            this.pnlNombre.TabIndex = 7;
            // 
            // Asientos_Elegir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(10)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(760, 577);
            this.Controls.Add(this.pnlNombre);
            this.Controls.Add(this.Cuerpo);
            this.Controls.Add(this.picPantalla);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Asientos_Elegir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asientos_Elegir";
            ((System.ComponentModel.ISupportInitialize)(this.picPantalla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPantalla;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Cuerpo;
        private System.Windows.Forms.Panel pnlNombre;
    }
}