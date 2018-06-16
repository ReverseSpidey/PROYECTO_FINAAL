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
using System.Collections;

namespace AppDesktop.GUI
{
    public partial class SALA : Form
    {
        srvSala srv = new srvSala();

        public SALA()
        {
            InitializeComponent();


        }
        private void SALA_Load(object sender, EventArgs e)
        {
            Listar();
        }
        public void Listar()
        {
            dgvSala.AutoGenerateColumns = false;
            dgvSala.DataSource = srv.Sala_c_tipo();
            dgvSala.Columns[0].Visible = false;
            dgvSala.Columns[2].Visible = false;



        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            NuevaSala nuv = new NuevaSala(this);
            nuv.ShowDialog();
        }

        private void ClickColumn(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                Sala sal = new Sala();
                sal.Num_sala = Convert.ToInt32(dgvSala.Rows[e.RowIndex].Cells[1].Value.ToString());
                sal.cod_tipo = Convert.ToInt32(dgvSala.Rows[e.RowIndex].Cells[2].Value.ToString());
                NuevaSala nev = new NuevaSala(sal, this);
                nev.ShowDialog();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Hashtable map = new Hashtable();
            if (this.nupCodigo.Value != 0)
                map["NUM_SALA"] = Convert.ToInt16(nupCodigo.Value);


            dgvSala.AutoGenerateColumns = false;
            dgvSala.DataSource = srv.getListSala(map);
        }
    }
}
