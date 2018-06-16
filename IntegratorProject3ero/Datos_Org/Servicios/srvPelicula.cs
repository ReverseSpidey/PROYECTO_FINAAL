using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using Datos_Org.Modelo;
using System.Windows.Forms;
using System.Collections;
using Datos_Org.Entidades;

namespace Datos_Org.Entidades
{
   public class srvPelicula
    {


        public List<Pelicula> GetPeliculas()
        {
            using (var db = new Entidades_Cinema())
            {
                return db.Pelicula.ToList();
            }
        }

        public List<Clasificacion> GetClasificacions()
        {
            using (var db = new Entidades_Cinema())
            {
                return db.Clasificacion.ToList();
            }
        }


        public List<Genero> GetGeneros()
        {
            using (var db = new Entidades_Cinema())
            {
                return db.Genero.ToList();
            }
        }

        public List<Idioma> GetIdiomas()
        {
            using (var db = new Entidades_Cinema())
            {
                return db.Idioma.ToList();
            }
        }






        public void AgregarPelicula(Pelicula item)
        {
            try
            {
                using (var db = new Entidades_Cinema())
                {
                    db.Pelicula.Add(item);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Verifica los datos a Insertar");//es un error que yo creo

            }
        }

        public void ModificarPelicula(Pelicula item)
        {
            try
            {
                using (var db = new Entidades_Cinema())
                {
                    Pelicula obj = db.Pelicula.Where(x => x.Id_pelicula == item.Id_pelicula).FirstOrDefault();
                    if (obj != null)
                    {
                        obj.nombre_pelicula = item.nombre_pelicula;
                        obj.Duracion = item.Duracion;
                        obj.Sinopsis = item.Sinopsis;
                        obj.ID_genero = item.ID_genero;
                        obj.Cod_idioma = item.Cod_idioma;
                        obj.id_clasif = item.id_clasif;
                        obj.Imagen_pelicula = item.Imagen_pelicula;

                        db.SaveChanges();
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("Verifica los datos a Actualizar");//es un error que yo creo

            }
        }


        public void Borrarpelicula(Pelicula item)
        {
            try
            {
                using (var db = new Entidades_Cinema())
                {
                    Pelicula obj = db.Pelicula.Where(x => x.Id_pelicula == item.Id_pelicula).FirstOrDefault();
                    if (obj != null)
                    {
                        MessageBox.Show("si entro");
                        db.Pelicula.Remove(obj);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("Verifica los datos a Eliminar");//es un error que yo creo

            }
        }
    }

}
