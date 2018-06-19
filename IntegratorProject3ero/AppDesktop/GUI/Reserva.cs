using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos_Org.Servicios;
using Datos_Org.Modelo;
using System.Collections;
using Datos_Org.Entidades;

namespace AppDesktop.GUI
{
    public partial class Reserva : Form
    {

        srvDetalle_Compra obj = new srvDetalle_Compra();

        vFuncion fun;
        int idfun = 0;
        int total_asientos;
        public Reserva(vFuncion obj, int total_asi)
        {
            InitializeComponent();
            fun = obj;
            idfun = fun.ID_funcion;
            total_asientos = total_asi;
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void Listar()
        {
            dgvReservas.AutoGenerateColumns = false;
            dgvReservas.DataSource = obj.Detalle(fun);
        }

        private void Reserva_Load(object sender, EventArgs e)
        {
            Listar();
            MessageBox.Show("" + idfun);
        }
    }
}
