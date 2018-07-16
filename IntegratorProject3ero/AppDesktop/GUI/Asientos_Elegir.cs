using Datos_Org.Entidades;
using Datos_Org.Modelo;
using Datos_Org.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
namespace AppDesktop.GUI
{
using System.Threading.Tasks;
using System.Windows.Forms;

    public partial class Asientos_Elegir : Form
    {
        char letter = 'A';
        char letra = 'A';
        Button[,] but;
        Label[] titulo;
        vFuncion vista;
        srvSala objsal = new srvSala();
        srvAsiento asi = new srvAsiento();
        srvDetalle_Compra vend = new srvDetalle_Compra();
        srvDetalle_Compra deeet = new srvDetalle_Compra();
        int fila, columna;
        int total_asiento;
        int contador = 0;
        int ID;
        public int[] id_boleto;
        Detalle_compra det;
        public decimal Total_FIN;
        int[] tipos = new int[3];//para allmacenar los totales de cada tipo de boleto
        public decimal prec_sala;
        int id_fun;
        public Asientos_Elegir(vFuncion obj, int num, int abuelo, int adul, int ninio, decimal total_pagar, decimal precio_sala)
        {
            InitializeComponent();
            id_fun = obj.ID_funcion;
            vista = obj;
            RecupFilaColumn();
            total_asiento = num;
            tipos[0] = abuelo;
            tipos[1] = adul;
            tipos[2] = ninio;
            id_boleto = new int[total_asiento];//arreglo para almacenar los id de boleto
            prec_sala = precio_sala;
            contador = total_asiento;
            but = new Button[fila, columna];
            titulo = new Label[fila];
            CrearAsientos();
            Asignar_Datos();
            Recorrer();
            Total_FIN = total_pagar;
            

            //MessageBox.Show("EL CODIGO DE LA SALA ES: " + vista.Cod_sala +" y el número de la sala es"+ vista.NUM_SALA);
        }

        private void RecupFilaColumn()//Recupero filas y columnas de la sala
        {
            foreach (var item in objsal.getListSALAS().Where(a => a.Num_sala == vista.NUM_SALA))
            {
                fila = Convert.ToInt32(item.CANT_FILAS);
                columna = Convert.ToInt32(item.CANT_COLUMNAS);
            }
        }
        int c, cont = 0;
        int val;
        
        private void CrearAsientos()
        {
            for (int f = 0; f <= fila - 1; f++)
            {
                for (c = 0; c <= columna - 1; c++)
                {
                    but[f, c] = new Button();
                    but[f, c].Width = 43;
                    but[f, c].Height = 37;
                    but[f, c].BackColor = Color.Azure;
                    but[f, c].Location = new Point(45 * f, 40 * c);
                    Cuerpo.Controls.Add(but[f, c]);
                    but[f, c].FlatStyle = FlatStyle.Flat;
                    but[f, c].Click += new EventHandler(but_Click);
                    val = f + 1;
                    but[f, c].Text = val.ToString();
                    but[f, c].Name = letra.ToString();
                    //lista donde yo recupere fila y columna de la base de datos
                    letra++;
                    if (letra == (65 + columna))
                    {
                        letra = 'A';
                    }
                    foreach (var x in vend.getAsientoVendido(id_fun))
                    {
                        //MessageBox.Show("Columna de la matriz"+ but[f, c].Text + "\nFila de matriz " + but[f, c].Name + "Columna de lista" + x.columna + "fila de la lista" + x.fila);
                        if (x.columna.Trim().Equals(but[f, c].Text) && x.fila.Trim().Equals(but[f, c].Name))
                        {
                            MessageBox.Show("ENTRA");
                            but[f, c].Enabled = false;                           
                        }
                    }
                    

                }

            }
        }

        //este método me servía para asignarle un id de boleto a cada asiento
        public Detalle_compra RecupDatos(int id_comp, int cont)
        {
            det = new Detalle_compra();
            det.id_asiento = id_boleto[cont];
            det.Id_funcion = vista.ID_funcion;
            det.id_compra = id_comp;

            MessageBox.Show("RECUP ID del asiento ES: " + det.id_asiento);
            if (tipos[0] > 0)
            {
                det.ID_TIPOBOLETO = 8;
                tipos[0]--;
            }
            else if (tipos[1] > 0)
            {
                det.ID_TIPOBOLETO = 7;
                tipos[1]--;
            }
            else if (tipos[2] > 0)
            {
                det.ID_TIPOBOLETO = 6;
                tipos[2]--;
            }
            return det;

        }




        private void Asignar_Datos()
        {
            for (int fila = 0; fila <= columna - 1; fila++)
            {
                titulo[fila] = new Label();
                titulo[fila].Width = 20;
                titulo[fila].Height = 20;
                titulo[fila].Location = new Point(0, 40 * fila);
                pnlNombre.Controls.Add(titulo[fila]);
                titulo[fila].Text = letter.ToString();
                titulo[fila].ForeColor = Color.White;
                letter++;
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Reserva OBJ = new Reserva(vista, total_asiento, this);
            OBJ.Show();
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void Recorrer()
        {
            foreach (Control x in Cuerpo.Controls)
            {
                if (x is Button)
                {
                    if (cont <= total_asiento - 1 && x.Enabled == true)
                    {
                        x.BackColor = Color.Red;
                        string valor = x.Text;
                        string name = x.Name;
                        int codigo = vista.Cod_sala;

                        foreach (var i in asi.GetAsiento(name, valor, codigo))
                        {
                            ID = i.id_siento;//necesito el id para hacer el insert en detalle_compra
                        }
                        //deeet.Ingresar_Detalle(RecupDatos());
                        id_boleto[cont] = ID;
                        cont++;
                    }
                    else
                    {
                        if (x.Enabled == false)
                        {
                            x.BackColor = Color.Gray;
                        }
                        else
                        {
                            x.BackColor = Color.Green;

                        }

                    }

                }
            }
        }


        private void but_Click(object sender, EventArgs e)
        {
            Button butt = (Button)sender;
            string valor = butt.Text;
            string name = butt.Name;
            int codigo = vista.Cod_sala;
            foreach (var x in asi.GetAsiento(name, valor, codigo))
            {
                ID = x.id_siento;
            }

            if (butt.BackColor == Color.Red)
            {
                butt.BackColor = Color.Green;
                contador--;
                id_boleto[contador] = ID;
            }
            else if (butt.BackColor == Color.Green)
            {
                if (contador == total_asiento)
                {
                    MessageBox.Show("Se han seleccionado los " + contador + " Boleto(s).");
                }
                else
                {
                    butt.BackColor = Color.Red;
                    //deeet.Actualizar(RecupDatos());//metodo para hacer act
                    id_boleto[contador] = ID;

                    contador++;
                    int falta = total_asiento - contador;
                }

            }
        }

    }
}

