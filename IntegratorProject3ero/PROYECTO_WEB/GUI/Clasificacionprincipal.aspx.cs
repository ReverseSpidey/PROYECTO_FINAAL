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
    public partial class Clasificacionprincipal : System.Web.UI.Page
    {
        srvClasificacion clasificacion = new srvClasificacion();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {

            }

            listardatos();
        }


        public void listardatos()
        {
            gvTipodeclasificacion.AutoGenerateColumns = false;//evita que se generen columnas
            gvTipodeclasificacion.DataSource = clasificacion.Clasificacion();
            gvTipodeclasificacion.DataBind();
            gvTipodeclasificacion.Columns[0].Visible = false;
            gvTipodeclasificacion.Columns[1].ItemStyle.Width = 100;
           
        }
    }
}