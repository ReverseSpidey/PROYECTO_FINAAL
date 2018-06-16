using AppDesktop.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos_Org.Servicios;
using Datos_Org.Modelo;

namespace AppDesktop
{
    public partial class frmAsiento : Form
    {
        srvAsiento asi = new srvAsiento();
        public frmAsiento()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            newAsiento obj = new newAsiento(this);
            obj.ShowDialog();
        }

        public void Listar()
        {
            dgvAsiento.AutoGenerateColumns = false;
            dgvAsiento.DataSource = asi.AsientoComplete();
            dgvAsiento.Columns[0].Visible = false;
            dgvAsiento.Columns[3].Visible = false;


        }

        private void frmAsiento_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Click_Registro(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                Asiento asi = new Asiento();
                asi.Cod_sala = Convert.ToInt32(dgvAsiento.Rows[e.RowIndex].Cells[0].Value);
                asi.fila = dgvAsiento.Rows[e.RowIndex].Cells[1].Value.ToString();
                asi.columna = dgvAsiento.Rows[e.RowIndex].Cells[2].Value.ToString();
                asi.Cod_sala = Convert.ToInt32(dgvAsiento.Rows[e.RowIndex].Cells[3].Value.ToString());
                MessageBox.Show(""+ asi.Cod_sala);
                newAsiento asiento = new newAsiento(asi, this);
                asiento.ShowDialog();
            }
        }
    }
}
