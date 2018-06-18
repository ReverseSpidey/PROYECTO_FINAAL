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

namespace Datos_Org.Servicios
{
    public class srvSala
    {
        public List<Sala> getListSALAS()
        {
            using (var db = new EntidadesCinema())
            {
                return db.Sala.ToList();
            }
        }

        public List<Tipo_sala> getlistTipo_Sala()
        {
            using (var db = new EntidadesCinema())
            {
                return db.Tipo_sala.ToList();
            }
        }




        public void AgregarSala(Sala item)
        {
            try
            {
                using (var db = new EntidadesCinema())
                {
                    db.Sala.Add(item);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Verifica los datos a Insertar");//es un error que yo creo

            }
        }

        public void ModificarSala(Sala item)
        {
            try
            {
                using (var db = new EntidadesCinema())
                {
                    Sala obj = db.Sala.Where(x => x.Cod_sala == item.Cod_sala).FirstOrDefault();
                    if (obj != null)
                    {
                        obj.Num_sala = item.Num_sala;
                        obj.cod_tipo = item.cod_tipo;
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("Verifica los datos a Actualizar");//es un error que yo creo

            }
        }


        public void BorrarSala(Sala item)
        {
            try
            {
                using (var db = new EntidadesCinema())
                {
                    Sala obj = db.Sala.Where(x => x.Num_sala == item.Num_sala).FirstOrDefault();
                    if (obj != null)
                    {
                        MessageBox.Show("si entro");
                        db.Sala.Remove(obj);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("Verifica los datos a Eliminar");//es un error que yo creo

            }
        }

        public List<Sala> getListSala(Hashtable datos)
        {
            try
            {
                using (var db = new EntidadesCinema())
                {
                    string query = @"SELECT VALUE SALA FROM Cinema_Model.Sala As Sala";
                    StringBuilder wheereis = new StringBuilder();
                    List<ObjectParameter> parameters = new List<ObjectParameter>();
                    if (datos.Contains("NUM_SALA"))
                    {
                        if (wheereis.Length > 0) wheereis.Append(" AND ");
                        wheereis.Append("Sala.NUM_SALA=@NUM_SALA");
                        parameters.Add(new ObjectParameter("NUM_SALA", datos["NUM_SALA"]));
                    }
                    
                    
                    if (wheereis.Length > 0)
                        query += " WHERE " + wheereis.ToString();

                    ObjectContext oc;
                    oc = ((IObjectContextAdapter)db).ObjectContext;

                    var q = new ObjectQuery<Sala>(query, oc);
                    if (wheereis.Length > 0)
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



        public List<vSala> Sala_c_tipo()
        {
            List<vSala> obj = new List<vSala>();
            using (var db = new EntidadesCinema())
            {
                obj = (from x in db.Sala
                       select new vSala
                       {
                           Cod_sala = x.Cod_sala,
                           Num_sala = x.Num_sala,
                           cod_tipo = x.cod_tipo,
                           NombreSala_tipo = x.Tipo_sala.Nombre_sala
                       }).ToList();
                return obj;
            }
        }

    }
}
