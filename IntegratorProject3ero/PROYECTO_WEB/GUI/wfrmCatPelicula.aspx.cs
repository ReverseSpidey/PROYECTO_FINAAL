using Datos_Org.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PROYECTO_WEB.GUI
{
    public partial class wfrmCatPelicula : System.Web.UI.Page
    {
        srvPelicula serv = new srvPelicula();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
            }
            LlenarDrop();
            listarData();
        }

        public void listarData()
        {
            gvPelículas.AutoGenerateColumns = false;
            gvPelículas.DataSource = serv.ObtenerSalas();
            gvPelículas.DataBind();
            gvPelículas.Columns[0].Visible = false;
            gvPelículas.Columns[1].ItemStyle.Width = 100;
        }
        private void LlenarDrop()
        {
            dptPelículas.DataSource = serv.GetPeliculas();
            dptPelículas.DataBind();
        }
        /*Evento rowcommand*/
        protected void SeleccionarPelicula(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.ToString() == "Editar")//si el comando dice editar recupera los datos y los devuelve al otro form
            {       /*YA RECUPERE LOS DATOS DEL OBJECT*/              
                vPelicula peli = new vPelicula();
                int index = Convert.ToInt32(e.CommandArgument.ToString());
                peli.Id_pelicula = (Int32)gvPelículas.DataKeys[index].Value;
                peli.nombre_pelicula = gvPelículas.Rows[index].Cells[2].Text.Trim();
                peli.nom_clasif = gvPelículas.Rows[index].Cells[3].Text.Trim();
                peli.nom_genero = gvPelículas.Rows[index].Cells[4].Text.Trim();
                peli.nom_idioma = gvPelículas.Rows[index].Cells[5].Text.Trim();
                peli.Sinopsis = gvPelículas.Rows[index].Cells[6].Text.Trim();

                /*Se van a crear dos sesiones ya que una almacena datos porque se editan
                 y la otra es caundo se agrega una Nueva Película*/
            }
        }
    }
}