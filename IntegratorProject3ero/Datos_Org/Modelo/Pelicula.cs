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
    
    public partial class Pelicula
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pelicula()
        {
            this.Funcion = new HashSet<Funcion>();
        }
    
        public int Id_pelicula { get; set; }
        public string nombre_pelicula { get; set; }
        public string Duracion { get; set; }
        public string Sinopsis { get; set; }
        public int ID_genero { get; set; }
        public int Cod_idioma { get; set; }
        public Nullable<int> id_clasif { get; set; }
        public byte[] Imagen_pelicula { get; set; }
        public string RutaFoto { get; set; }
    
        public virtual Clasificacion Clasificacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Funcion> Funcion { get; set; }
        public virtual Genero Genero { get; set; }
        public virtual Idioma Idioma { get; set; }
    }
}
