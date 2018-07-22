using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using Datos_Org.Entidades;
using Datos_Org.Modelo;
using Datos_Org.Servicios;
using System.Windows.Forms;

namespace Datos_Org.Servicios
{
    public class srvFuncion
    {
        public List<vFuncion> Horario(int id)
        {
            List<vFuncion> obj = new List<vFuncion>();
            using (var db = new CinemaEntidades())
            {
                obj = (from x in db.Funcion
                       select new vFuncion
                       {
                           nombre_peli = x.Pelicula.nombre_pelicula,
                           Hora_ini = x.Hora_ini,
                           Cod_sala = x.Cod_sala,
                           ID_funcion = x.ID_funcion,
                           Id_pelicula = x.Id_pelicula,
                           tipo_sala = x.Sala.Tipo_sala.Nombre_sala,
                           NUM_SALA = x.Sala.Num_sala.Value,
                           FechaFun = x.FechaFun


                       }).Where(a => a.Id_pelicula == id).ToList();
                return obj;
            }
        }


        public List<vFuncion> ObtenFuncion()
        {
            List<vFuncion> obj = new List<vFuncion>();
            using (var db = new CinemaEntidades())
            {
                obj = (from x in db.Funcion
                       select new vFuncion
                       {
                           nombre_peli = x.Pelicula.nombre_pelicula,
                           Hora_ini = x.Hora_ini,
                           Cod_sala = x.Cod_sala,
                           ID_funcion = x.ID_funcion,
                           Id_pelicula = x.Id_pelicula,
                           tipo_sala = x.Sala.Tipo_sala.Nombre_sala,
                           NUM_SALA = x.Sala.Num_sala.Value,
                           FechaFun = x.FechaFun


                       }).ToList();
                return obj;
            }
        }
        public void AgregarFuncion(Funcion item)
        {
            try
            {
                using (var db = new CinemaEntidades())
                {
                    db.Funcion.Add(item);
                    db.SaveChanges();
                    MessageBox.Show("si sirvió paps");
                }
            }
            catch (Exception e)
            {
                throw new Exception("Verifica los datos a Insertar");//es un error que yo creo

            }
        }
        public void ModificarFuncion(Funcion item)
        {
            try
            {
                using (var db = new CinemaEntidades())
                {
                    Funcion obj = db.Funcion.Where(x => x.ID_funcion == item.ID_funcion).FirstOrDefault();
                    if (obj != null)
                    {
                        obj.Id_pelicula = item.Id_pelicula;
                        obj.Hora_ini = item.Hora_ini;
                        obj.FechaFun = item.FechaFun;
                        obj.Cod_sala = item.Cod_sala;
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
        public void BorrarFuncion(Funcion item)
        {
            try
            {
                using (var db = new CinemaEntidades())
                {
                    Funcion obj = db.Funcion.Where(x => x.ID_funcion == item.ID_funcion).FirstOrDefault();
                    if (obj != null)
                    {
                        db.Funcion.Remove(obj);
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
    }
}
