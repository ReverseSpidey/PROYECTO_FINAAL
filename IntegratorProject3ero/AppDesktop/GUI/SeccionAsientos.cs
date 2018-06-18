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
        srvTipo_Sala sala = new srvTipo_Sala();
        srvAsiento asi = new srvAsiento();
        #region Vistas
        vTipo_Boleto vista = new vTipo_Boleto();
        vFuncion fun;
        vTipo_Sala tipe = new vTipo_Sala();
        #endregion
        decimal acumulador_tot = 0;
        decimal precio_sala;

        public SeccionAsientos(vFuncion func)
        {
            InitializeComponent();
            this.fun = func;
            lblSALA.Text = func.tipo_sala;
            foreach (var x in sala.GetPrecios().Where(a => a.Nombre_sala == func.tipo_sala))
            {
                tipe.Precio = x.Precio;//precio del tipo de sala
            }
            precio_sala = Convert.ToDecimal(tipe.Precio);
            
        }
        private decimal PrecioNinio()
        {
            foreach (var x in srvTipo.ObtenerPrecio().Where(x => x.id_tipoBoleto == 6))
            {
                vista.Precio_tipo = x.Precio_tipo + precio_sala;
            }
            decimal totNinio = Convert.ToDecimal(vista.Precio_tipo * nupNinio.Value);
            return totNinio;
        }
        private decimal PrecioAdulto()
        {
            foreach (var x in srvTipo.ObtenerPrecio().Where(x => x.id_tipoBoleto == 7))
            {
                this.vista.Precio_tipo = x.Precio_tipo + precio_sala;
            }
            decimal ttoAdulto = Convert.ToDecimal(this.vista.Precio_tipo * nupAdulto.Value);
            return ttoAdulto;
        }
        private decimal PrecioAbuelo()
        {
            foreach (var x in srvTipo.ObtenerPrecio().Where(x => x.id_tipoBoleto == 8))
            {
                this.vista.Precio_tipo = x.Precio_tipo + precio_sala;
            }
            decimal totAbuelo = Convert.ToDecimal(this.vista.Precio_tipo * nupAbuelo.Value);
            return totAbuelo;
        }
        private void nupNinio_ValueChanged(object sender, EventArgs e)
        {
            decimal tot = PrecioNinio();
            acumulador_tot = tot + PrecioAbuelo() + PrecioAdulto(); ;
            txtTotal.Text = acumulador_tot.ToString();
        }

        private void nupAdulto_ValueChanged(object sender, EventArgs e)
        {
            decimal tot = PrecioAdulto();
            acumulador_tot = PrecioNinio() + PrecioAbuelo() + tot;

            txtTotal.Text = acumulador_tot.ToString();
        }

        private void nupAbuelo_ValueChanged(object sender, EventArgs e)
        {
            decimal tot = PrecioAbuelo();
            acumulador_tot = PrecioNinio() + tot + PrecioAdulto();

            txtTotal.Text = acumulador_tot.ToString();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            int total = Convert.ToInt32(nupAbuelo.Value + nupAdulto.Value + nupNinio.Value);
            if (total > 8)
            {
                MessageBox.Show("La cantidad de boletos máximos son 8", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(total > 0 && total <= 8)
            {
                MessageBox.Show("Aquí van instrucciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Asientos_Elegir asiento = new Asientos_Elegir(fun);
                asiento.ShowDialog();
                
            }
        }
    }
}
