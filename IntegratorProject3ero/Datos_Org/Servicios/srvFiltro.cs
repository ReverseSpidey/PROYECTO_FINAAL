using Datos_Org.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos_Org.Entidades;

namespace Datos_Org.Servicios
{
    public class srvFiltro
    {
        public List<Ciudad> getCiudades()
        {
            using (var db = new CinemaEntidades())
            {
                return db.Ciudad.ToList();
            }
        }
        public List<Sucursal> getSucursales(int cod_ciu)
        {
            using (var db = new CinemaEntidades())
            {
                return db.Sucursal.Where(x => x.Cod_ciudad == cod_ciu).ToList();
            }
        }
    }
}
