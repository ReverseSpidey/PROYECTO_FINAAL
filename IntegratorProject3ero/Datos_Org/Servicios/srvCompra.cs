using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos_Org.Entidades;
using Datos_Org.Modelo;
namespace Datos_Org.Servicios
{
    public class srvCompra
    {
        public int ID;
        public void AgregarCompra(Compra item)
        {
            try
            {
                using (var db = new EntidadesCinema())
                {
                    db.Compra.Add(item);
                    db.SaveChanges();
                    ID = item.id_compra;
                    MessageBox.Show("SI se insertó la compra");
                }
            }
            catch (Exception)
            {
                throw new Exception("Verifica los datos a Insertar");//es un error que yo creo
            }
        }
    }
}
