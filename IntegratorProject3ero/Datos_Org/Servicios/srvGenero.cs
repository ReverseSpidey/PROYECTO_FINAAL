using Datos_Org.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos_Org.Servicios
{
   public class srvGenero
    {

        public List<Genero> listargenero()
        {
            List<Genero> type = new List<Genero>();

            using (var db = new EntidadesCinema())
            {
                type = (from x in db.Genero
                        select x).ToList();

                return type;
            }

            
        }
    }
}
