//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos_Org.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Compra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Compra()
        {
            this.Detalle_compra = new HashSet<Detalle_compra>();
        }
    
        public int id_compra { get; set; }
        public Nullable<System.DateTime> fecha_exp { get; set; }
        public Nullable<decimal> total_fin { get; set; }
        public int id_tipo { get; set; }
        public int id_user { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detalle_compra> Detalle_compra { get; set; }
        public virtual Tipo_pago Tipo_pago { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
