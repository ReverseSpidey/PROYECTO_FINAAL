using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos_Org.Entidades;
using Datos_Org.Modelo;
using Datos_Org.Servicios;

namespace Datos_Org.Servicios
{
    public class srvFuncion
    {
        public List<vFuncion> Horario(int id)
        {
            List<vFuncion> obj = new List<vFuncion>();
            using (var db = new EntidadesCinema())
            {
                obj = (from x in db.Funcion
                       select new vFuncion
                       {
                           nombre_peli = x.Pelicula.nombre_pelicula,
                           Hora_ini = x.Hora_ini,
                           Cod_sala = x.Cod_sala,
                           ID_funcion = x.ID_funcion,
                           Id_pelicula = x.Id_pelicula,
                           tipo_sala = x.Sala.Tipo_sala.Nombre_sala,
                           NUM_SALA = x.Sala.Num_sala.Value

                       }).Where(a => a.Id_pelicula == id).ToList();
                return obj;
            }
        }


    }
}
