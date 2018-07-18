using Datos_Org.Entidades;
using Datos_Org.Servicios;
using Datos_Org.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace PROYECTO_WEB.GUI
{
    public partial class BoletoPrincipal : System.Web.UI.Page
    {
        srvTipoBoleto tipoBoleto = new srvTipoBoleto();
        protected void Page_Load(object sender, EventArgs e)
        {
           if(!IsPostBack)//Si es la primera vez que carga la pagina es necesario ponerlo
            {
                
            }
            listarData();
        }


        public void listarData()
        {

            //obtengo los datos para llenar el datavigriew
            gvTipoBoleto.AutoGenerateColumns = false;
            gvTipoBoleto.DataSource = tipoBoleto.ObtenerPrecio();
            gvTipoBoleto.DataBind();
            gvTipoBoleto.Columns[0].Visible = false;
            gvTipoBoleto.Columns[1].ItemStyle.Width = 100;
            gvTipoBoleto.Columns[2].ItemStyle.Width = 100;
        }

        protected void Seleccionar(object sender, GridViewCommandEventArgs e)
        {

            if (e.CommandName.ToString() == "Editar")
            {
                Tipo_boleto obj = new Tipo_boleto();//Aqui hablo a la tabla del modelo que quiero
                int index = Convert.ToInt32(e.CommandArgument.ToString());//toma todos los datos
                int idgenero = Convert.ToInt32(gvTipoBoleto.DataKeys[index].Value.ToString());
                string boleto = gvTipoBoleto.Rows[index].Cells[1].Text.Trim();
                decimal precio = Convert.ToDecimal(gvTipoBoleto.Rows[index].Cells[2].Text.Trim());



                obj.id_tipoBoleto = idgenero;//Compara los datos del objeto con los obtenidos del datavigriew
                obj.nombre_tipo = boleto;
                obj.Precio_tipo = precio;


                Session["oBoleto"] = obj;//primero esto antes del redirect
                Session["operacion"] = "editando";
                Response.Redirect("BoletoEdit.aspx");//Para ingresar a una nueva ventana
            }

           
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            Session["operacion"] = "nuevo";
            Response.Redirect("BoletoEdit.aspx");
        }
    }
}