using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos_Org.Entidades;
using Datos_Org.Modelo;
using Datos_Org.Servicios;

namespace AppDesktop.GUI
{
    public partial class Funciones : Form
    {
        srvPelicula peli = new srvPelicula();
        srvFuncion func = new srvFuncion();
        public Funciones()
        {
            InitializeComponent();
            LlenarComponentes();
        }
        public void LlenarComponentes()
        {
            cboPeliculas.DataSource = peli.GetPeliculas();
            cboPeliculas.DisplayMember = "nombre_pelicula";
            cboPeliculas.ValueMember = "id_pelicula";
            dgvFunciones.AutoGenerateColumns = false;
            dgvFunciones.DataSource = func.ObtenFuncion();

            dgvFunciones.Columns[5].Visible = false;
            dgvFunciones.Columns[6].Visible = false;
            dgvFunciones.Columns[7].Visible = false;
        }


        private void SeleccionarRegistro(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                vFuncion vista = new vFuncion();
                if (e.ColumnIndex == 4)
                {
                    vista.NUM_SALA = Convert.ToInt32(dgvFunciones.Rows[e.RowIndex].Cells[0].Value.ToString());
                    vista.nombre_peli = dgvFunciones.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
                    vista.Hora_ini = dgvFunciones.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
                    vista.FechaFun = Convert.ToDateTime(dgvFunciones.Rows[e.RowIndex].Cells[3].Value.ToString().Trim());
                    vista.ID_funcion = Convert.ToInt32(dgvFunciones.Rows[e.RowIndex].Cells[5].Value.ToString().Trim());
                    vista.Id_pelicula = Convert.ToInt32(dgvFunciones.Rows[e.RowIndex].Cells[6].Value.ToString().Trim());
                    vista.Cod_sala = Convert.ToInt32(dgvFunciones.Rows[e.RowIndex].Cells[7].Value.ToString().Trim());
                    CatFunciones cat = new CatFunciones(vista,this);
                    cat.Show();
                    this.Close();
                }
            }
            catch
            { }           
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int id = (Int32)cboPeliculas.SelectedValue;
            dgvFunciones.AutoGenerateColumns = false;
            dgvFunciones.DataSource = func.Horario(id);

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            CatFunciones cate = new CatFunciones(this);
            cate.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
