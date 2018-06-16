using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using Datos_Org.Modelo;
using Datos_Org.Entidades;

namespace AppDesktop.GUI
{
    public partial class Peliculas : Form
    {

        Peliculas frm_peliculas;
        public bool nuevo;
        Pelicula obj;
        srvPelicula srv = new srvPelicula();
        public Peliculas(Pelicula obj, Peliculas frm)
        {
            InitializeComponent();
            //preparaEdicion();
            nuevo = false;
            this.obj = obj;
            datosInterface();
            frm_peliculas = frm;

        }

        public Peliculas(Peliculas frm)
        {
            InitializeComponent();
            //preparaNuevo();
            nuevo = true;
            frm_peliculas = frm;
        }





        public void datosInterface()
        {
            txtNombre.Text = obj.nombre_pelicula;
            txtSinopsis.Text = obj.Sinopsis;
            txtDuracion.Text = Convert.ToString(obj.Duracion);
            cboClasif.SelectedValue = obj.id_clasif;
            cboGenero.SelectedValue = obj.ID_genero;
            cboIdioma.SelectedValue = obj.Cod_idioma;

        }

        public Pelicula interfaceDatos()
        {
            obj = new Pelicula();
            obj.nombre_pelicula = txtNombre.Text.Trim();
            obj.Sinopsis = txtSinopsis.Text.Trim();
            obj.Duracion = txtDuracion.Text;
            obj.id_clasif = Convert.ToInt16(cboClasif.SelectedValue);
            obj.ID_genero = Convert.ToInt16(cboGenero.SelectedValue);
            obj.Cod_idioma = Convert.ToInt16(cboIdioma.SelectedValue);
            return obj;
        }




        private void btnEstablecer_Click(object sender, EventArgs e)
        {

            
        }



        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (nuevo == true)
            {
                srv.AgregarPelicula(interfaceDatos());
                frm_peliculas.listar();
                this.Close();
            }
            else
            {
                srv.ModificarPelicula(interfaceDatos());
                frm_peliculas.listar();
                this.Close();
            }
        }

        private void listar()
        {
            throw new NotImplementedException();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }
    }
}
