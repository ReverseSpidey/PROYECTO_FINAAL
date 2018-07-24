using Datos_Org.Entidades;
using Datos_Org.Modelo;
using Datos_Org.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDesktop.GUI
{
    public partial class CatFunciones : Form
    {
        vFuncion obFun;
        Funciones formFun;
        srvPelicula pelis = new srvPelicula();
        srvSala sal = new srvSala();
        bool NuevaFuncion;
        srvFuncion servFun = new srvFuncion();
        Funcion objFunc;//este objeto es para que podamos recuperar y hacer insert


        public CatFunciones(vFuncion fun,Funciones frmFuncion)
        {
            //aqui es cuando se va a editar alguna función
            InitializeComponent();
            NuevaFuncion = false;
            obFun = fun;
            formFun = frmFuncion;
            PrepararEdicion();
            LlenarcBO();
            DatosInterface();
        }
        public CatFunciones(Funciones frmFuNuevo)
        {
            InitializeComponent();
            NuevaFuncion = true;
            formFun = frmFuNuevo;
            LlenarcBO();
            PrepararNuevo();
        }
        private void LlenarcBO()
        {
            cboPeliculas.DataSource = pelis.ObtenrDatePeli();
            cboPeliculas.DisplayMember = "nombre_pelicula";
            cboPeliculas.ValueMember = "id_pelicula";

            cboSala.DataSource = sal.getListSALAS();
            cboSala.DisplayMember = "num_sala";
            cboSala.ValueMember = "cod_sala";
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Funciones abrir = new Funciones();
            abrir.Show();
            this.Close();
        }
        private void DatosInterface()
        {
            cboPeliculas.SelectedValue = obFun.Id_pelicula;
            dtpFechaFuncion.Value = (DateTime)obFun.FechaFun;
            txtHorario.Text = obFun.Hora_ini;
            cboSala.SelectedValue = obFun.Cod_sala;
        }
        public Funcion RecuperarDatos()
        {
            objFunc = new Funcion();
            if (NuevaFuncion == false)
            {
                objFunc.ID_funcion = obFun.ID_funcion;
            }
            objFunc.Id_pelicula = (Int32)cboPeliculas.SelectedValue;
            objFunc.Cod_sala = (Int32)cboSala.SelectedValue;
            objFunc.Hora_ini = txtHorario.Text;
            objFunc.FechaFun = dtpFechaFuncion.Value;
            return objFunc;
        }

        private void PrepararNuevo()
        {
            btnSaveNext.Enabled = true;
            btnEliminar.Visible = false;
            btnLimpiar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void PrepararEdicion()
        {
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = true;
            btnLimpiar.Visible = false;
            btnSaveNext.Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            formFun = new Funciones();
            if (NuevaFuncion == true)
            {
                servFun.AgregarFuncion(RecuperarDatos());
                formFun.Show();
                formFun.LlenarComponentes();
                this.Close();
            }
            else if (NuevaFuncion == false)
            {
                servFun.ModificarFuncion(RecuperarDatos());
                formFun.Show();
                formFun.LlenarComponentes();
                this.Close();
            }
        }
        private void Limpiar()
        {
            txtHorario.Clear();
            dtpFechaFuncion.Value = DateTime.Today;
            cboPeliculas.Text = "Seleccionar";
            cboSala.Text = "Seleccionar";
        }
        private void btnSaveNext_Click(object sender, EventArgs e)
        {
            formFun = new Funciones();
            servFun.AgregarFuncion(RecuperarDatos());
            formFun.LlenarComponentes();
            Limpiar();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            formFun = new Funciones();
            DialogResult resp = MessageBox.Show("¿Está seguro que desea eliminar esta función?","Confimración",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            switch (resp)
            {
                case DialogResult.Yes:
                    servFun.BorrarFuncion(RecuperarDatos());
                    formFun.LlenarComponentes();
                    formFun.Show();
                    this.Close();
                    break;
                case DialogResult.No:
                    this.Close();
                    break;
            }
            
        }
    }
}
