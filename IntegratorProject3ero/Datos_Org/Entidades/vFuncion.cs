using Datos_Org.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos_Org.Entidades
{
    public class vFuncion
    {
        public int Cod_sala { get; set; }
        public int Id_pelicula { get; set; }
        public string Hora_ini { get; set; }
        public int ID_funcion { get; set; }
        public string nombre_peli { get; set; }
        public string tipo_sala { get; set; }



        public virtual ICollection<Compra> Compra { get; set; }
        public virtual Sala Sala_ref { get; set; }
        public virtual Pelicula Pelicula_ref { get; set; }
    }
}
