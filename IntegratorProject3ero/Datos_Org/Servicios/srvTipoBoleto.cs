using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos_Org.Modelo;
using Datos_Org.Entidades;

namespace Datos_Org.Servicios
{
    public class srvTipoBoleto
    {
        public List<Tipo_boleto> ObtenerPrecio()
        {
            List<Tipo_boleto> obj = new List<Tipo_boleto>();
            using (var db = new Entidades_Cinema())
            {
                obj = (from x in db.Tipo_boleto
                      select x).ToList();
                return obj;       
            }
        }
    }
}
