﻿using System;
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
        public List<vPelicula> ObtenerSalas()
        {
            List<vPelicula> vsal = new List<vPelicula>();
            using (var db = new EntidadesCinema())
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
                            Sinopsis = x.Sinopsis
                        }).ToList();
                return vsal;
            }
        }

        public List<Pelicula> GetPeliculas()
        {
            using (var db = new EntidadesCinema())
            {
                return db.Pelicula.ToList();
            }
        }

        public List<Clasificacion> GetClasificacions()
        {
            using (var db = new EntidadesCinema())
            {
                return db.Clasificacion.ToList();
            }
        }


        public List<Genero> GetGeneros()
        {
            using (var db = new EntidadesCinema())
            {
                return db.Genero.ToList();
            }
        }

        public List<Idioma> GetIdiomas()
        {
            using (var db = new EntidadesCinema())
            {
                return db.Idioma.ToList();
            }
        }






        public void AgregarPelicula(Pelicula item)
        {
            try
            {
                using (var db = new EntidadesCinema())
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
                using (var db = new EntidadesCinema())
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
                using (var db = new EntidadesCinema())
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
