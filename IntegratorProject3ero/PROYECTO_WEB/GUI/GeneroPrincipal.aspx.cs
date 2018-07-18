using Datos_Org.Entidades;
using Datos_Org.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PROYECTO_WEB.GUI
{
    public partial class GeneroPrincipal : System.Web.UI.Page
    {
        srvGenero genero = new srvGenero();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {

            }
            listardatos();
        }


        public void listardatos()
        {
            gvGenero.AutoGenerateColumns = false;
            gvGenero.DataSource = genero.listargenero();
            gvGenero.Columns[0].Visible = false;
            gvGenero.DataBind();
            gvGenero.Columns[1].ItemStyle.Width = 100;
        }

        protected void SeleccionarGenero(object sender, GridViewCommandEventArgs e)
        {
           
        }
    }
}