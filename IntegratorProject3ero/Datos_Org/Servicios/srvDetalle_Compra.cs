﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos_Org.Entidades;
using Datos_Org.Modelo;

namespace Datos_Org.Servicios
{
    public class srvDetalle_Compra
    {
        public void Ingresar_Detalle(Detalle_compra item)
        {
            try
            {
                using (var db = new EntidadesCinema())
                {
                    db.Detalle_compra.Add(item);
                    db.SaveChanges();
                    MessageBox.Show("SI ENTRO PAPU");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR");
            } 
        }

        public void Actualizar(Detalle_compra item)
        {
            try
            {
                using (var db = new EntidadesCinema())
                {
                    Detalle_compra obj = db.Detalle_compra.Where(x => x.id_detalle == item.id_detalle).FirstOrDefault();
                    if (obj != null)
                    {
                        obj.id_asiento = item.id_asiento;

                        db.SaveChanges();
                        MessageBox.Show("Confirmación del asiento disponible","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("Verifica los datos a Actualizar");//es un error que yo creo

            }
        }


        public List<vDetallecompra> Detalle(vFuncion ji)
        {
            List<vDetallecompra> obj = new List<vDetallecompra>();
            using (var db = new EntidadesCinema())
            {
                obj = (from x in db.Detalle_compra where x.Id_funcion == ji.ID_funcion
                       select new vDetallecompra
                       {
                           id_asiento = x.id_asiento,
                           pelicula_nom = x.Funcion.Pelicula.nombre_pelicula,
                           sala_num = x.Funcion.Cod_sala,
                           horario = x.Funcion.Hora_ini,
                           fila = x.Asiento.fila,
                           columna = x.Asiento.columna
                           
                           
                       }).ToList();
                return obj;
            }
        }

        public List<vDetallecompra> getDetalles_Compra(int asiento)
        {
            List<vDetallecompra> obj = new List<vDetallecompra>();
            using (var db = new EntidadesCinema())
            {
                obj = (from x in db.Detalle_compra
                       where x.id_asiento == asiento
                       select new vDetallecompra
                       {
                           id_detalle = x.id_detalle
                       }).ToList();
                return obj;
            }
        }
    }
}
