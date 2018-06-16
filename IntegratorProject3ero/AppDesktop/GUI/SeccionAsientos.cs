using Datos_Org.Servicios;
using Datos_Org.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos_Org.Modelo;

namespace AppDesktop.GUI
{
    public partial class SeccionAsientos : Form
    {
        srvTipoBoleto srvTipo = new srvTipoBoleto();
        srvAsiento asi = new srvAsiento();
        vTipo_Boleto vista = new vTipo_Boleto();
        vFuncion fun;
        double[] tipo = new double[3];
        double acumulador_tot;

        public SeccionAsientos(vFuncion func)
        {
            InitializeComponent();
            this.fun = func;
            
        }

        private void nupNinio_ValueChanged(object sender, EventArgs e)
        {
            foreach (var x in srvTipo.ObtenerPrecio().Where(x => x.id_tipo == 6))
            {
                acumulador_tot += Convert.ToDouble(x.Precio_tipo);
            }
            txtTotal.Text = acumulador_tot.ToString();

        }

        private void nupAdulto_ValueChanged(object sender, EventArgs e)
        {
            foreach (var x in srvTipo.ObtenerPrecio().Where(x => x.id_tipo == 7))
            {
                acumulador_tot += Convert.ToDouble(x.Precio_tipo);
            }
            txtTotal.Text = acumulador_tot.ToString();
        }

        private void nupAbuelo_ValueChanged(object sender, EventArgs e)
        {
            foreach (var x in srvTipo.ObtenerPrecio().Where(x => x.id_tipo == 8))
            {
                acumulador_tot += Convert.ToDouble(x.Precio_tipo);
            }
            txtTotal.Text = acumulador_tot.ToString();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + fun.Sala.Tipo_sala.Nombre_sala);
        }
    }
}
