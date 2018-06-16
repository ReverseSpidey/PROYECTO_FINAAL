using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppDesktop.GUI;

namespace AppDesktop.GUI
{
    public partial class frm_PERSONA : Form
    {
        public frm_PERSONA()
        {
            InitializeComponent();

            
        }

        int posY = 0;
        int posX = 0;

        private void picCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void PERSONA_Load(object sender, EventArgs e)
        {
            
        }

        private void PERSONA_MouseMove(object sender, MouseEventArgs e)
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de cancelar su registro?", "Se requiere confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Hide();
            }
                
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de guardar los datos?", "Se requiere confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Hide();
                MessageBox.Show("Datos guardados con exito!!!");
            }
        }

        private void pciMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
