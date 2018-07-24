using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos_Org.Modelo;
using Datos_Org.Servicios;
using Datos_Org.Entidades;

namespace AppDesktop.GUI
{
    public partial class MenuPeliculas : Form
    {
        int id;
        srvPelicula peli = new srvPelicula();
        srvFuncion fun = new srvFuncion();
        
        public MenuPeliculas()
        {
            InitializeComponent();
        }
        private void MenuPeliculas_Load(object sender, EventArgs e)
        {
            cboPeliculas.Items.Add("Cargando...");
        }
       
        private void CargarCombo()
        {
            cboPeliculas.DataSource = peli.GetPeliculas();
            cboPeliculas.DisplayMember = "nombre_pelicula";
            cboPeliculas.ValueMember = "ID_pelicula";
            
        }
        private void cboPeliculas_Click(object sender, EventArgs e)
        {
            CargarCombo();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(cboPeliculas.SelectedValue);
            DateTime fechaSel = dtpFechaFun.Value;
            LlenarData(fechaSel);
        }
        private void LlenarData(DateTime fechasel)
        {
            dgvHorarios.AutoGenerateColumns = false;
            dgvHorarios.DataSource = fun.Horario(id, fechasel);
            dgvHorarios.Columns[0].Visible = false;
        }

        private void dgvHorarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            vFuncion func = new vFuncion();
            if (e.ColumnIndex == 6)
            {
                func.ID_funcion = int.Parse
                    (dgvHorarios.Rows[e.RowIndex].Cells[0].Value.ToString());
                func.NUM_SALA = Convert.ToInt32(dgvHorarios.Rows[e.RowIndex].Cells[1].Value.ToString());
                func.Cod_sala = Convert.ToInt32(dgvHorarios.Rows[e.RowIndex].Cells[2].Value.ToString());
                func.tipo_sala = dgvHorarios.Rows[e.RowIndex].Cells[3].Value.ToString();
                func.nombre_peli = dgvHorarios.Rows[e.RowIndex].Cells[4].Value.ToString();
                func.Hora_ini = dgvHorarios.Rows[e.RowIndex].Cells[5].Value.ToString();

                SeccionAsientos selec = new SeccionAsientos(func);
                selec.ShowDialog();
            }
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
