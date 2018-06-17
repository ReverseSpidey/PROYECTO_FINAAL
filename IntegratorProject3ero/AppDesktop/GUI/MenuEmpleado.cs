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
    public partial class MenuEmpleado : Form
    {
        int cont;
        public MenuEmpleado()
        {
            InitializeComponent();
            timer1.Enabled = true;
            pnlCatalogos.Visible = false;

        }

        private void btnPelicula_Click(object sender, EventArgs e)
        {
            pnlCatalogos.Visible = false;


            if (cont % 2 > 0)
            {
                pnlCatalogos.Visible = false;

            }
            else if (cont % 2 == 0)
            {
                pnlCatalogos.Visible = true;
            }

            cont++;
        }

        private void AddFormInPanel(object formHijo)
        {
            if (this.panelcine.Controls.Count > 0)
                this.panelcine.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelcine.Controls.Add(fh);
            this.panelcine.Tag = fh;
            fh.Show();

        }

        private void btnPelicula2_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new MenuPeliculas());
        }

        private void panelcine_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString();
        }
    }
}
