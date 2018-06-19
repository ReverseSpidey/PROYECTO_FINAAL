using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos_Org.Entidades
{
    public class vDetallecompra
    {
        public int id_detalle { get; set; }
        public string columna { get; set; }

        public string fila { get; set; }


        public string pelicula_nom { get; set; } 

        public int sala_num { get; set; }

        public string horario { get; set; }


        public Nullable<int> id_asiento { get; set; }
        public Nullable<int> ID_TIPOBOLETO { get; set; }
        public Nullable<int> Id_funcion { get; set; }
    }
}
