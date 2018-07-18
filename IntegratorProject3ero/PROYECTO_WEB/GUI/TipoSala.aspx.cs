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
    public partial class TipoSala : System.Web.UI.Page
    {
        srvTipo_Sala tipo_Sala = new srvTipo_Sala();//se agrega el servicio
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }

            listarData();
        }

        public void listarData()
        {

            //obtengo los datos para llenar el datavigriew
            gvTipoSala.AutoGenerateColumns = false;
            gvTipoSala.DataSource = tipo_Sala.GetPrecios();
            gvTipoSala.DataBind();
            gvTipoSala.Columns[0].Visible = false;
            gvTipoSala.Columns[1].ItemStyle.Width = 100;
            gvTipoSala.Columns[2].ItemStyle.Width = 100;
        }



    }
}