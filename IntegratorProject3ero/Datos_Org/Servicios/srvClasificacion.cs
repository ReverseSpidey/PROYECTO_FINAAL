using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos_Org.Entidades;
using Datos_Org.Modelo;

namespace Datos_Org.Servicios
{
    public class srvClasificacion
    {
        public List<Clasificacion> Clasificacion()
        {
            List<Clasificacion> type = new List<Clasificacion>();

            using (var db = new EntidadesCinema())
            {
                type = (from x in db.Clasificacion
                        select x).ToList();
            }

            return type;
        }

    }
}
