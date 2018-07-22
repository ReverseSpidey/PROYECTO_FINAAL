using Datos_Org.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos_Org.Servicios
{
    public class srvTipo_Sala
    {
        public List<Tipo_sala> GetPrecios()
        {
            List<Tipo_sala> tipe = new List<Tipo_sala>();
            using (var db = new CinemaEntidades())
            {
                tipe = (from x in db.Tipo_sala
                        select x).ToList();
                return tipe;
            }
        }
    }
}
