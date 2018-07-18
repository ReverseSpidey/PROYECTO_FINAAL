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
        public List<Tipo_sala> GetPrecios()//El tipo sala se encuentra en modelo
        {
            List<Tipo_sala> tipe = new List<Tipo_sala>();//Es lo mismo que una consulta join
            using (var db = new EntidadesCinema())//obten de entidades y de la tabla tipo sala lo siguiente:
            {
                tipe = (from x in db.Tipo_sala//traeme todo de la tabla y listamelo
                        select x).ToList();
                return tipe;
            }


        }
    }
}
