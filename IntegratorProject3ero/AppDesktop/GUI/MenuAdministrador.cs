using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDesktop.GUI
{
    public partial class MenuAdministrador : Form
    {
        int posY = 0;
        int posX = 0;
        int cont = 0;
        bool panel;

        public MenuAdministrador()
        {
            InitializeComponent();
            timer1.Enabled = true;
            pnlCatalogos.Visible = false;
        }





        private void AbrirFormHija(object formhija)
        {
            if (this.panelcine.Controls.Count > 0)
                this.panelcine.Controls.RemoveAt(0);
            Form frm = formhija as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            this.panelcine.Controls.Add(frm);
        
            this.panelcine.Tag = frm;
            frm.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {

            AbrirFormHija(new frm_PERSONA());
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {


        }

        private void MenuAdministrador_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posY = e.Y;
                posX = e.X;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        

        private void panelcine_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posY = e.Y;
                posX = e.X;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            pnlCatalogos.Visible = false;
            

            if(cont%2 > 0)
            {
                pnlCatalogos.Visible = false;

            }
            else if(cont % 2 == 0)
            {
                pnlCatalogos.Visible = true;
            }

            cont++;


        }


        private void button1_Click_1(object sender, EventArgs e)
        {
           AbrirFormHija(new PELICULA());
        }


        private void btnSala_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new SALA());
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
   
        }

        private void btnAsiento_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new frmAsiento());

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de cerrar sesión?", "Se requiere confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Hide();
                LOGIN abrir = new LOGIN();
                abrir.Show();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
