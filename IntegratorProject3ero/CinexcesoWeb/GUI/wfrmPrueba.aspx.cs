using Datos_Org.Entidades;
using Datos_Org.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CinexcesoWeb.GUI
{
    public partial class wfrmPrueba : System.Web.UI.Page
    {
        srvPelicula peli = new srvPelicula();
        vPelicula dPeli = new vPelicula();
        protected void Page_Load(object sender, EventArgs e)
        {
            RptPeliculas.DataSource = peli.GetPeliculas();
            RptPeliculas.DataBind();
        }
        private void ConsultarImagen()
        {

        }

        protected void RptPeliculas_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }
    }
}