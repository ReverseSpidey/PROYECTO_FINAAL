using Datos_Org.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos_Org.Entidades
{
    public class vAsiento
    {
        public int id_siento { get; set; }
        public string fila { get; set; }
        public string columna { get; set; }
        public int Cod_sala { get; set; }
        public Nullable<int> Num_sala { get; set; }
        public virtual Sala Sala_REL { get; set; }
        public int cant_colum { get; set; }


    }
}
