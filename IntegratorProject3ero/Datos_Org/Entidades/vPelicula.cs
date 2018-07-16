using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos_Org.Entidades
{
    public class vPelicula
    {
        
        public int Id_pelicula { get; set; }
        public string nombre_pelicula { get; set; }
        public string Duracion { get; set; }
        public string Sinopsis { get; set; }
        public string nom_genero { get; set; }
        public string nom_idioma { get; set; }
        public string nom_clasif { get; set; }
        public byte[] Imagen_pelicula { get; set; }
    }
}
