using Datos_Org.Entidades;
using Datos_Org.Modelo;
using System;
using System.Collections;
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
    public partial class PELICULA : Form
    {
        srvPelicula srv = new srvPelicula();
        public PELICULA()
        {
            InitializeComponent();
            listar();
            LlenarCombo();
        }

        public void listar()
        {
            DataGridViewRow row = this.dgvPeliculas.RowTemplate;
            
            dgvPeliculas.AutoGenerateColumns = false;
            dgvPeliculas.DataSource = srv.ObtenrDatePeli();
            //dgvPeliculas.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            row.Height = 100;
            row.MinimumHeight = 20;
            dgvPeliculas.Columns[7].Visible = false;
        }
        private void LlenarCombo() {
            cboPeliculas.DataSource = srv.GetPeliculas();
            cboPeliculas.DisplayMember = "nombre_pelicula";
            cboPeliculas.ValueMember = "id_pelicula";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Peliculas obj = new Peliculas(this);
            obj.ShowDialog();
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dgvPeliculas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            vPelicula obj_pel = new vPelicula();
            if (e.ColumnIndex == 8)
            {
                obj_pel.nombre_pelicula = dgvPeliculas.Rows[e.RowIndex].Cells[0].Value.ToString();
                obj_pel.Duracion = dgvPeliculas.Rows[e.RowIndex].Cells[1].Value.ToString();
                obj_pel.nom_genero = dgvPeliculas.Rows[e.RowIndex].Cells[2].Value.ToString();
                obj_pel.nom_idioma = dgvPeliculas.Rows[e.RowIndex].Cells[3].Value.ToString();
                obj_pel.nom_clasif = dgvPeliculas.Rows[e.RowIndex].Cells[4].Value.ToString();
                obj_pel.Sinopsis = dgvPeliculas.Rows[e.RowIndex].Cells[5].Value.ToString();
                obj_pel.Imagen_pelicula = (byte[])dgvPeliculas.Rows[e.RowIndex].Cells[6].Value;
                obj_pel.Id_pelicula = (Int32)dgvPeliculas.Rows[e.RowIndex].Cells[7].Value;
                Peliculas peli = new Peliculas(obj_pel, this);
                peli.ShowDialog();
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Hashtable map = new Hashtable();
            if (this.cboPeliculas.Text.Trim().Length != 0)
                map["nombre_pelicula"] = this.cboPeliculas.Text.Trim().ToUpper();

           // dgvPeliculas.AutoGenerateColumns = false;
            dgvPeliculas.DataSource = srv.getListPelis(map);


        }
    }
}
