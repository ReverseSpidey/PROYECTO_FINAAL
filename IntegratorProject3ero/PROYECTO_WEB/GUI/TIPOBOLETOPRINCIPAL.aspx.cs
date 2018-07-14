using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Datos_Org.Modelo;
using Datos_Org.Servicios;
using System.Collections;

namespace PROYECTO_WEB.GUI
{
    public partial class TIPOBOLETOPRINCIPAL : System.Web.UI.Page
    {

        srvTipoBoleto obj = new srvTipoBoleto();
        protected void Page_Load(object sender, EventArgs e)
        {
            getAllCursos();
        }
        public void getAllCursos()
        {
            gvResultado.DataSource = obj.ObtenerPrecio();
            gvResultado.DataBind();
        }

        protected void gvResultado_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.ToString() == "editar")
            {
              Tipo_boleto   obj = new Tipo_boleto();
                int index = Convert.ToInt32(e.CommandArgument.ToString());
                int id_tipoboleto =Convert.ToInt32( gvResultado.DataKeys[index].Value.ToString());
                
                string tipoboleto = gvResultado.Rows[index].Cells[0].Text.Trim();
                decimal precio =Convert.ToDecimal( gvResultado.Rows[index].Cells[1].Text.Trim());


                obj.id_tipoBoleto=id_tipoboleto;
                obj.nombre_tipo = tipoboleto;
                obj.Precio_tipo = precio;
                

                Session["oCurso"] = obj;//primero esto antes del redirect
                Session["operacion"] = "editando";//
                Response.Redirect("wrfmCursoEdit.aspx");
            }
        }
    }
}