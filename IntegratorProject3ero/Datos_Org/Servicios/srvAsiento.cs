using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos_Org.Entidades;
using Datos_Org.Modelo;


namespace Datos_Org.Servicios
{
    public class srvAsiento
    {

        public List<Asiento> GetAsiento()//método para obtener todos los datos del asiento
        {
            using (var db = new Entidades_Cinema())
            {
                return db.Asiento.ToList();
            }
        }

        /*Método para obtener los id de sala*/
        public List<Sala> getSala()//método para obtener todos los datos del asiento
        {
            using (var db = new Entidades_Cinema())
            {
                return db.Sala.ToList();
            }
        }
        /*Agregar Asientos*/
        public void AgregarAsiento(Asiento item)
        {
            try
            {
                using (var db = new Entidades_Cinema())
                {
                    db.Asiento.Add(item);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Verifica los datos a Insertar");//es un error que yo creo
            }
        }


        public List<vAsiento> AsientoComplete()
        {
            List<vAsiento> obj = new List<vAsiento>();
            using (var db = new Entidades_Cinema())
            {
                obj = (from x in db.Asiento
                       select new vAsiento
                       {
                           id_siento = x.id_siento,
                           fila = x.fila,
                           columna = x.columna,
                           Cod_sala = x.Cod_sala,
                           Num_sala = x.Sala.Cod_sala

                       }).ToList();
                return obj;
            }
        }

        public List<vAsiento> CantAsientos(int num_sala)
        {
            List<vAsiento> obj = new List<vAsiento>();
            using (var db = new Entidades_Cinema())
            {
              obj= (from x in db.Asiento
                 where
                   x.Cod_sala == num_sala
                 group x by new
                 {
                     x.fila
                 } into g
                 select new vAsiento
                 {
                     cant_colum = g.Count(p => p.columna != null)
                 }).ToList();
                return obj;
            }

        }

    }
}

