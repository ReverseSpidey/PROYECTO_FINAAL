using Datos_Org.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CinexcesoWeb.GUI
{
    public partial class wfrmFuncionPelicula : System.Web.UI.Page
    {
        srvPelicula svPeli = new srvPelicula();
        vPelicula vPel;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.QueryString["ID"] != null)
            {
               int id_pelicula = int.Parse(Request.QueryString["ID"]);
                LlenarPeli(id_pelicula);
            }
        }

        private void LlenarPeli(int peli)
        {          
            vPel = new vPelicula();
            foreach(vPelicula obj in svPeli.ObtenrDatePeli(peli))
            {
                vPel.Id_pelicula = obj.Id_pelicula;
                vPel.nombre_pelicula = obj.nombre_pelicula;
                vPel.Duracion = obj.Duracion;
                vPel.nom_clasif = obj.nom_clasif;
                vPel.nom_genero = obj.nom_genero;
                vPel.nom_idioma = obj.nom_idioma;
                vPel.Imagen_pelicula = obj.Imagen_pelicula;
                vPel.Sinopsis = obj.Sinopsis;
                ConvertirImagen(vPel.Imagen_pelicula);

            }

        }

        public void ConvertirImagen(byte[] ImagenPeliEdit)
        {

            string imreBase64Data = Convert.ToBase64String(ImagenPeliEdit);
            string imgDataURL = string.Format("data:image/png;base64,{0}", imreBase64Data);


            imagen.Src = imgDataURL;
        }
    }
}