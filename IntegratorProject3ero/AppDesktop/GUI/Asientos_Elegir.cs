using Datos_Org.Entidades;
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
        Button[,] but = new Button[14, 10];
        Label[] titulo = new Label[10];
        vFuncion vista;
        srvSala objsal = new srvSala();
        int fila, columna;
        public Asientos_Elegir(vFuncion obj)
        {
            InitializeComponent();
            vista = obj;
            RecupFilaColumn();
            CrearAsientos();
            Asignar_Datos();

            MessageBox.Show("" + fila +" "+ columna);
        }

        private void RecupFilaColumn()
        {
            foreach (var item in objsal.getListSALAS().Where(a => a.Num_sala == vista.Cod_sala))
            {
                fila =Convert.ToInt32(item.CANT_FILAS);
                columna = Convert.ToInt32(item.CANT_COLUMNAS);
            }
        }
        private void CrearAsientos()
        {
            for (int f = 0; f <= fila - 1; f++)
            {

                for (int c = 0; c <= columna - 1; c++)
                {
                    but[f, c] = new Button();
                    but[f, c].Width = 43;
                    but[f, c].Height = 37;
                    but[f, c].BackColor = Color.Azure;
                    but[f, c].Location = new Point(45 * f, 40 * c);
                    Cuerpo.Controls.Add(but[f, c]);
                    but[f, c].FlatStyle = FlatStyle.Flat;
                    but[f, c].Click += new EventHandler(but_Click);
                    //but[f, c].Image = AppDesktop.res


                }
            }
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

        private void but_Click(object sender, EventArgs e)
        {
            Button butt = (Button)sender;
        }
    }
}
