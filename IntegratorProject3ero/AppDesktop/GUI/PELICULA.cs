using Datos_Org.Entidades;
using Datos_Org.Modelo;
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
    public partial class PELICULA : Form
    {
        srvPelicula srv = new srvPelicula();
        public PELICULA()
        {
            InitializeComponent();
            listar();
        }

        public void listar()
        {
            dgvPeliculas.AutoGenerateColumns = false;
            dgvPeliculas.DataSource = srv.ObtenerSalas();

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
            if (e.ColumnIndex == 6)
            {
                obj_pel.nombre_pelicula = dgvPeliculas.Rows[e.RowIndex].Cells[0].Value.ToString();
                obj_pel.Duracion = dgvPeliculas.Rows[e.RowIndex].Cells[1].Value.ToString();
                obj_pel.nom_genero = dgvPeliculas.Rows[e.RowIndex].Cells[2].Value.ToString();
                obj_pel.nom_idioma = dgvPeliculas.Rows[e.RowIndex].Cells[3].Value.ToString();
                obj_pel.nom_clasif = dgvPeliculas.Rows[e.RowIndex].Cells[4].Value.ToString();
                obj_pel.Sinopsis = dgvPeliculas.Rows[e.RowIndex].Cells[5].Value.ToString();
                Peliculas peli = new Peliculas(obj_pel, this);
                peli.ShowDialog();
            }

        }
    }
}
