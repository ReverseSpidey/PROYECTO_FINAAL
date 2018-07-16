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
            //btnSexy.ServerClick += new EventHandler(btnSexy_Click);
           
                dptPelículas.DataSource = serv.GetPeliculas();
                dptPelículas.DataBind();

        }

        private void CrearEventos()
        {
        }
        //private void btnSexy_Click(object sender, EventArgs e)
        //{
            
        //}
    }
}