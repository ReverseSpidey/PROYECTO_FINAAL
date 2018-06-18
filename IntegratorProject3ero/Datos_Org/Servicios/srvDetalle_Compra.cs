using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos_Org.Entidades;
using Datos_Org.Modelo;

namespace Datos_Org.Servicios
{
    public class srvDetalle_Compra
    {
        public void Ingresar_Detalle(Detalle_compra item)
        {
            try
            {
                using (var db = new EntidadesCinema())
                {
                    db.Detalle_compra.Add(item);
                    db.SaveChanges();
                    MessageBox.Show("SI ENTRO PAPU");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR");
            } 
        }
    }
}
