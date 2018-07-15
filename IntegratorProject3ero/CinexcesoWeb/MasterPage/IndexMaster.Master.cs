using Datos_Org.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos_Org.Modelo;

namespace CinexcesoWeb.MasterPage
{
    public partial class IndexMaster : System.Web.UI.MasterPage
    {
        srvFiltro filtro = new srvFiltro();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                dtpCiudad.DataSource = filtro.getCiudades();
                dtpCiudad.DataBind();
            }

        }

        protected void SeleccionarCiudad(object sender, EventArgs e)
        {
            if (dtpCiudad.SelectedValue.ToString() != null)
            {
                int cod = Convert.ToInt32(dtpCiudad.SelectedValue.ToString());
                dtpSucursal.DataSource = filtro.getSucursales(cod);
                dtpSucursal.DataBind();
                dtpSucursal.AutoPostBack = true;

            }
        }
    }
}