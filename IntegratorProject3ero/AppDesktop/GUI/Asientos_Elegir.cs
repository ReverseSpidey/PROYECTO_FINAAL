﻿using Datos_Org.Entidades;
using Datos_Org.Modelo;
using Datos_Org.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDesktop.GUI
{
    public partial class Asientos_Elegir : Form
    {
        char letter = 'A';
        char letra = 'A';
        Button[,] but;
        Label[] titulo;
        vFuncion vista;
        srvSala objsal = new srvSala();
        srvAsiento asi = new srvAsiento();
        srvDetalle_Compra deeet = new srvDetalle_Compra();
        int fila, columna;
        int total_asiento;
        int contador = 0;
        int ID;
        Detalle_compra det;
        Asiento objasiento;
        int[] tipos = new int[3];//para allmacenar los totales de cada tipo de boleto

        
        public Asientos_Elegir(vFuncion obj, int num, int abuelo, int adul, int ninio)
        {
            InitializeComponent();
            vista = obj;
            RecupFilaColumn();           
            total_asiento = num;
            tipos[0] = abuelo;
            tipos[1] = adul;
            tipos[2] = ninio;
            
            
            contador = total_asiento;
            but = new Button[fila,columna];
            titulo = new Label[fila];
            CrearAsientos();
            Asignar_Datos();
            Recorrer();
        }

        private void RecupFilaColumn()
        {
            foreach (var item in objsal.getListSALAS().Where(a => a.Num_sala == vista.Cod_sala))
            {
                fila =Convert.ToInt32(item.CANT_FILAS);
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
                    but[f, c].Text =val.ToString();
                    but[f, c].Name = letra.ToString();

                    letra++;
                    if (letra == (65 + columna))
                    {
                        letra = 'A';
                    }
                    
                }

            }
        }

        private Detalle_compra RecupDatos()
        {
            det = new Detalle_compra();
            det.id_asiento = ID;
            det.Id_funcion = vista.ID_funcion;
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
            
        }

        private void Recorrer()
        {
            foreach (Control x in Cuerpo.Controls )
            {
                if (x is Button)
                {
                    if (cont <= total_asiento - 1)
                    {
                        x.BackColor = Color.Red;
                        string valor = x.Text;
                        string name = x.Name;
                        int codigo = vista.Cod_sala;

                        foreach (var i in asi.GetAsiento(name, valor, codigo))
                        {
                            ID = i.id_siento;//necesito el puto id para hacer el insert en detalle_compra
                        }
                        MessageBox.Show("fila" + name + "columna " + valor + "sala" + ID);
                        deeet.Ingresar_Detalle(RecupDatos());
                        cont++;
                    }
                    else
                    {
                        x.BackColor = Color.Green;

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
            deeet.Ingresar_Detalle(RecupDatos());//metodo para hacer insert
            if (butt.BackColor == Color.Red)
            {

                    butt.BackColor = Color.Green;
                    contador--;
                    int falta = total_asiento - contador;
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
                        contador++;
                    int falta = total_asiento - contador;
                    



                }

            }
         }
            
    }
}

