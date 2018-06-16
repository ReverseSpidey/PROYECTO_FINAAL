using Datos_Org.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Datos_Org.Entidades
{
    public class vSala
    {
        public int Cod_sala { get; set; }
        public Nullable<int> Num_sala { get; set; }
        public int cod_tipo { get; set; }
        public string NombreSala_tipo { get; set; }


        public virtual ICollection<Funcion> Funcion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sucursal> Sucursal { get; set; }
        public virtual Tipo_sala Tipo_sala { get; set; }
    }
}
