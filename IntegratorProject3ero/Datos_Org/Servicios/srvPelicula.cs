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
        public List<vPelicula> ObtenrDatePeli()
        {
            List<vPelicula> vsal = new List<vPelicula>();
            using (var db = new CinemaEntidades())
            {
                vsal = (from x in db.Pelicula
                        select new vPelicula
                        {
                            Id_pelicula = x.Id_pelicula,
                            nombre_pelicula = x.nombre_pelicula,
                            Duracion = x.Duracion,
                            nom_clasif = x.Clasificacion.nombre_clasif,
                            nom_genero = x.Genero.nombre_gen,
                            nom_idioma = x.Idioma.Nombre_idioma,
                            Sinopsis = x.Sinopsis,
                            Imagen_pelicula = x.Imagen_pelicula,                                                                                   
                        }).ToList();
                return vsal;
            }
        }
        public List<vPelicula> ObtenrDatePeli(int id_peli)
        {
            List<vPelicula> vsal = new List<vPelicula>();
            using (var db = new CinemaEntidades())
            {
                vsal = (from x in db.Pelicula
                        select new vPelicula
                        {
                            Id_pelicula = x.Id_pelicula,
                            nombre_pelicula = x.nombre_pelicula,
                            Duracion = x.Duracion,
                            nom_clasif = x.Clasificacion.nombre_clasif,
                            nom_genero = x.Genero.nombre_gen,
                            nom_idioma = x.Idioma.Nombre_idioma,
                            Sinopsis = x.Sinopsis,
                            Imagen_pelicula = x.Imagen_pelicula,
                        }).Where(x => x.Id_pelicula == id_peli).ToList();
                return vsal;
            }
        }

        public List<Pelicula> GetPeliculas()
        {
            using (var db = new CinemaEntidades())
            {
                return db.Pelicula.ToList();
            }

        
        }
        public List<vPelicula> ObtenerImagen(int id)
        {
            List<vPelicula> peli = new List<vPelicula>();
            using (var db = new CinemaEntidades())
            {
                peli = (from x in db.Pelicula
                        where x.Id_pelicula == id
                        select new vPelicula
                        {
                            Imagen_pelicula = x.Imagen_pelicula
                        }).ToList();
                return peli;
            }
        }

        public List<Clasificacion> GetClasificacions()
        {
            using (var db = new CinemaEntidades())
            {
                return db.Clasificacion.ToList();
            }
        }


        public List<Genero> GetGeneros()
        {
            using (var db = new CinemaEntidades())
            {
                return db.Genero.ToList();
            }
        }

        public List<Idioma> GetIdiomas()
        {
            using (var db = new CinemaEntidades())
            {
                return db.Idioma.ToList();
            }
        }


        public int TotalPelis()
        {
            List<Pelicula> list = new List<Pelicula>();
            using (var db = new CinemaEntidades())
            {
                return db.Pelicula.Count();
            }
        }



        public void AgregarPelicula(Pelicula item)
        {
            try
            {
                using (var db = new CinemaEntidades())
                {
                    db.Pelicula.Add(item);
                    db.SaveChanges();
                    MessageBox.Show("si sirvió paps");
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
                using (var db = new CinemaEntidades())
                {
                    Pelicula obj = db.Pelicula.Where(x => x.nombre_pelicula == item.nombre_pelicula).FirstOrDefault();
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
                        MessageBox.Show("Si se actualizó paps");
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
                using (var db = new CinemaEntidades())
                {
                    Pelicula obj = db.Pelicula.Where(x => x.Id_pelicula == item.Id_pelicula).FirstOrDefault();
                    if (obj != null)
                    {
                        db.Pelicula.Remove(obj);
                        db.SaveChanges();
                        MessageBox.Show("si entro");

                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("Verifica los datos a Eliminar");//es un error que yo creo

            }
        }
        public List<Pelicula> getListPelis(Hashtable datos)
        {
            try
            {
                using (var db = new CinemaEntidades())
                {
                    string query = @"SELECT VALUE Pelicula FROM EntidadesCinema.Pelicula As Pelicula ";
                    StringBuilder whereis = new StringBuilder();
                    List<ObjectParameter> parameters = new List<ObjectParameter>();


                    if (datos.Contains("nombre_pelicula"))
                    {
                        if (whereis.Length > 0) whereis.Append(" AND ");
                        whereis.Append("Pelicula.nombre_pelicula=@nombre_pelicula");
                        parameters.Add(new ObjectParameter("nombre_pelicula", datos["nombre_pelicula"]));
                    }
                    if (whereis.Length > 0)
                        query += " WHERE " + whereis.ToString();

                    ObjectContext oc;
                    oc = ((IObjectContextAdapter)db).ObjectContext;

                    var q = new ObjectQuery<Datos_Org.Modelo.Pelicula>(query, oc);

                    if (whereis.Length > 0)
                    {
                        foreach (ObjectParameter parametro in parameters)
                            q.Parameters.Add(parametro);

                    }
                    return q.ToList();
                }

            }
            catch (Exception e)
            {
                throw new Exception("Verifica los datos a buscar");
            }
        }

    }

}
