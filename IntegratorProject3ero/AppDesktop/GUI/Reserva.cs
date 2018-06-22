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
using AppDesktop.Ticket_Venta;

namespace AppDesktop.GUI
{
    public partial class Reserva : Form
    {
        int com;
        srvDetalle_Compra obj = new srvDetalle_Compra();
        Asientos_Elegir asientos;
        vFuncion fun;
        Compra comp;
        srvCompra srvComp = new srvCompra();
        srvDetalle_Compra det = new srvDetalle_Compra();
        int idfun = 0;
        int total_asientos;
        decimal TOT, pago_cli, CAMBIO;
        public Reserva(vFuncion obj, int total_asi, Asientos_Elegir frm_asiento_elegir)
        {
            InitializeComponent();
            btnImprimir.Visible = false;
            fun = obj;
            idfun = fun.ID_funcion;
            total_asientos = total_asi;//indica cauntos boletos se compraron
            asientos = frm_asiento_elegir;
            TOT = asientos.Total_FIN;
            lblTotal.Text = Convert.ToString(TOT);
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
            dgvReservas.Rows.Add(total_asientos, fun.nombre_peli, fun.Hora_ini, fun.NUM_SALA);
        }

        private void Reserva_Load(object sender, EventArgs e)
        {
            Listar();
            MessageBox.Show("" + idfun);
        }

        private Compra Recuperar()
        {
            comp = new Compra();
            comp.fecha_exp = DateTime.Now;
            comp.id_user = 1;
            comp.total_fin = TOT;
            comp.id_tipo = 1;
            return comp;
        }




        private void CrearTicket()
        {
            decimal precio_bol = 0;
            string tipo_bol = "";
            string fila = "";
            string columna = "";
            //Creamos una instancia d ela clase CrearTicket
            CrearTicket ticket = new CrearTicket();
            //NECESITO UN METODO QUE ME RECUPERE FILA Y COLUMA SEGUN EL ID DEL ASIENTO, TIPO DE BOLETO ETC..
            for (int i = 0; i < total_asientos; i++)
            {
                asientos.RecupDatos(com, i);
                int id = asientos.id_boleto[i];
                foreach (var x in det.getDetalles_Compra(id, com))
                {
                    tipo_bol = x.tipo_bol_nom;
                    fila = x.fila;
                    columna = x.columna;
                    if (tipo_bol == "Niño" || tipo_bol == "Adulto (Mayor 60)")
                    {
                        precio_bol = 30M + asientos.prec_sala;
                    }
                    else if (tipo_bol == "Adulto")
                    {
                        precio_bol = 40M + asientos.prec_sala;
                    }
                }

                #region BoletosImprimir
                //Ya podemos usar todos sus metodos
                ticket.AbreCajon();//Para abrir el cajon de dinero.

                //De aqui en adelante pueden formar su ticket a su gusto... Les muestro un ejemplo

                //Datos de la cabecera del Ticket.
                ticket.TextoCentro("CINEXCESO");
                ticket.TextoIzquierda("EXPEDIDO EN: LOCAL PRINCIPAL");
                ticket.TextoIzquierda("DIREC: DIRECCION DE LA EMPRESA");
                ticket.TextoIzquierda("TELEF: 4530000");
                ticket.TextoIzquierda("R.F.C: XXXXXXXXX-XX");
                ticket.TextoIzquierda("EMAIL: cmcmarce14@gmail.com");//Es el mio por si me quieren contactar ...
                ticket.TextoIzquierda("");
                ticket.TextoExtremos("Caja # 1", "Ticket # 002-00000" + i + "" + "0" + "0");
                ticket.lineasAsteriscos();

                //Sub cabecera.
                ticket.TextoIzquierda("");
                ticket.TextoIzquierda("ATENDIÓ: ALAN JOSÉ COLLI TUN");
                ticket.TextoIzquierda("CLIENTE: PUBLICO EN GENERAL");
                ticket.TextoIzquierda("");
                ticket.TextoExtremos("FECHA: " + DateTime.Now.ToShortDateString(), "HORA: " + DateTime.Now.ToShortTimeString());
                ticket.lineasAsteriscos();

                //Articulos a vender.
                ticket.EncabezadoVenta();//NOMBRE DEL ARTICULO, CANT, PRECIO, IMPORTE

                ticket.AgregaArticulo(fun.nombre_peli, fun.NUM_SALA.ToString(), fun.Hora_ini, precio_bol);
                ticket.TextoIzquierda("Asiento: " + fila + "" + columna);
                ticket.TextoIzquierda("Sala: " + fun.NUM_SALA);

                ticket.lineasIgual();

                //Resumen de la venta. Sólo son ejemplos
                ticket.AgregarTotales("         SUBTOTAL......$", precio_bol);
                //ticket.AgregarTotales("         IVA...........$", 10.04M);//La M indica que es un decimal en C#
                ticket.TextoIzquierda("");
                ticket.AgregarTotales("         EFECTIVO......$", pago_cli);
                ticket.AgregarTotales("         CAMBIO........$", CAMBIO);
                //Texto final del Ticket.
                ticket.TextoIzquierda("");
                ticket.TextoCentro("¡DISFRUTE LA FUNCIÓN!");
                ticket.CortaTicket();
                ticket.GuardarTicket();
                //ticket.ImprimirTicket("Microsoft XPS Document Writer");//Nombre de la impresora ticketera
                #endregion
            }


        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            CrearTicket();

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            pago_cli = Convert.ToDecimal(txtPago.Text);
            if (pago_cli >= TOT)
            {
                CAMBIO = pago_cli - TOT;
                //se hace el insert para compra
                srvComp.AgregarCompra(Recuperar());
                com = srvComp.ID;//ID DE LA COMPRA
                for (int i = 0; i < total_asientos; i++)
                {
                    det.Ingresar_Detalle(asientos.RecupDatos(com, i));

                }
                MessageBox.Show("GRACIAS POR TU COMPRA PRRO", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnImprimir.Visible = true;
            }
            else
            {
                MessageBox.Show("No se puede realizar la compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
