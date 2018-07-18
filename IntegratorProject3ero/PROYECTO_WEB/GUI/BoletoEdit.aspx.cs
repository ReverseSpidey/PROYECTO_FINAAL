using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos_Org.Modelo;
using Datos_Org.Servicios;
using Datos_Org.Entidades;

namespace PROYECTO_WEB.GUI
{
    public partial class BoletoEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)//si no es la primera vez no limpies
            {
                if ((String)Session["operacion"] == "editando")//igualando
                {
                    preparaEdicion();

                    //DatosInterface();//las sesiones osn la manera en que se  comunican los formularios 

                }
                else
                {
                    preparaNuevo();

                }
            }
        }

        private void DatosInterface()
        {


            //OBTIENE LOS DATOS
            Tipo_boleto obj = (Tipo_boleto)Session["oBoleto"];//Llamar a la sesion
            txtNomBoleto.Text = obj.nombre_tipo;
            txtPrecioBoleto.Text = obj.Precio_tipo.ToString();
           
        }

        public Tipo_boleto interfaceDatos()
        {
            //RETORNA LOS DATOS
            Tipo_boleto obj = new Tipo_boleto();
            obj.nombre_tipo = txtNomBoleto.Text.Trim();
            obj.Precio_tipo = Convert.ToDecimal(txtPrecioBoleto.Text.Trim());
            
            return obj;
        }



        public void limpiar()
        {
            txtNomBoleto.Text = "";
            txtPrecioBoleto.Text = " ";
        }

        public void preparaNuevo()
        {
            btnAgregar.Visible = true;
            btnGuardarNext.Visible = true;
            btnRegresar.Visible = true;
            btnEliminar.Visible = false;
            limpiar();
        }
        public void preparaEdicion()
        {
            btnAgregar.Visible = true;
            btnGuardarNext.Visible = false;
            btnRegresar.Visible = true;
            btnEliminar.Visible = true;
            
            limpiar();
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("BoletoPrincipal.aspx");
        }
    }
}