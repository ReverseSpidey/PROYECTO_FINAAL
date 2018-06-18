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

        PELICULA inf_peli;
        public bool nuevo;
        vPelicula obj_vista;
        vPelicula obj;
        Pelicula peli_org;
        srvPelicula srv = new srvPelicula();
        int valor_gen;
        int valor_idioma;
        int valor_clasif;
        public Peliculas(vPelicula obj,PELICULA frm)
        {
            //este es para editar peloculas es decir su informacion
            InitializeComponent();
            //preparaEdicion();
            nuevo = false;
            this.obj = obj;   
            inf_peli = frm;
            Llenar_combo();
            datosInterface();

        }

        public Peliculas(PELICULA frm)
        {
            //este quier decir que agregare una nueva peli
            InitializeComponent();
            preparaNuevo();
            nuevo = true;
            inf_peli = frm;
        }


        private void Llenar_combo()
        {
            #region
            cboIdioma.DataSource = srv.GetIdiomas();
            cboIdioma.ValueMember = "cod_idioma";
            cboIdioma.DisplayMember = "nombre_idioma";
            #endregion
            cboClasif.DataSource = srv.GetClasificacions();
            cboClasif.ValueMember = "id_clasif";
            cboClasif.DisplayMember = "nombre_clasif";

            cboGenero.DataSource = srv.GetGeneros();
            cboGenero.ValueMember = "id_genero";
            cboGenero.DisplayMember = "nombre_gen";

        }
        private void RecuperarValoresdeCombo()
        {
            foreach(var x in srv.GetClasificacions().Where(a => a.nombre_clasif == obj.nom_clasif))
            {
                valor_clasif = x.id_clasif;
            }
            foreach (var i in srv.GetGeneros().Where(a => a.nombre_gen == obj.nom_genero))
            {
                valor_gen = i.ID_genero;
            }
            foreach (var item in srv.GetIdiomas().Where(x => x.Nombre_idioma == obj.nom_idioma))
            {
                valor_idioma = item.Cod_idioma;
            }
        }

        public void datosInterface()
        {
            RecuperarValoresdeCombo();
            txtNombre.Text = obj.nombre_pelicula;
            txtSinopsis.Text = obj.Sinopsis;
            txtDuracion.Text = obj.Duracion;
            cboClasif.SelectedValue = valor_clasif;
            cboGenero.SelectedValue = valor_gen;
            cboIdioma.SelectedValue = valor_idioma;

        }

        public Pelicula interfaceDatos()
        {
            peli_org = new Pelicula();
            peli_org.nombre_pelicula = txtNombre.Text.Trim();
            peli_org.Sinopsis = txtSinopsis.Text.Trim();
            peli_org.Duracion = txtDuracion.Text;
            peli_org.id_clasif = Convert.ToInt16(cboClasif.SelectedValue);
            peli_org.ID_genero = Convert.ToInt16(cboGenero.SelectedValue);
            peli_org.Cod_idioma = Convert.ToInt16(cboIdioma.SelectedValue);
            return peli_org;
        }
        private void btnEstablecer_Click(object sender, EventArgs e)
        {

            
        }
        private void preparaNuevo()
        {
            btnCancelar.Visible = true;
            btnEliminar.Visible = false;
            btnGuardar.Visible = true;
            btnSaveNext.Visible = true;
            limpiar();
        }
        private void preparaEdicion()
        {

            btnCancelar.Visible = true;
            btnEliminar.Visible = true;
            btnGuardar.Visible = true;
            btnSaveNext.Visible = false;
            limpiar();
        }
        private void limpiar()
        {
            txtDuracion.Clear();
            txtNombre.Clear();
            txtSinopsis.Clear();
            cboClasif.SelectedIndex = 0;
            cboGenero.SelectedIndex = 0;
            cboIdioma.SelectedIndex = 0;
            picPelicula.Image = null;
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (nuevo == true)
            {
                srv.AgregarPelicula(interfaceDatos());
                
                this.Close();
            }
            else
            {
                srv.ModificarPelicula(interfaceDatos());
                inf_peli.listar();
                this.Close();
            }
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (nuevo == true)
            {
                srv.AgregarPelicula(interfaceDatos());

                this.Close();
            }
            else if(nuevo == false)
            {
                MessageBox.Show("entra");
                srv.ModificarPelicula(interfaceDatos());
                inf_peli.listar();
                this.Close();
            }
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bntGuardarYSeguir_Click(object sender, EventArgs e)
        {
            srv.AgregarPelicula(interfaceDatos());

        }
    }
}
