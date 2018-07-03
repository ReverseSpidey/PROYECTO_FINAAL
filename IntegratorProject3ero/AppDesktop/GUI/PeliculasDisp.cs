using Datos_Org.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDesktop.GUI
{
    public partial class PeliculasDisp : Form
    {
        PictureBox[] pic;
        srvPelicula peli = new srvPelicula();
        int[] ids;
        Button[] but;
        int cont = 0;
        public PeliculasDisp()
        {
            InitializeComponent();
        }

        private void PeliculasDisp_Load(object sender, EventArgs e)
        {

            pic = new PictureBox[peli.TotalPelis()];
            ids = new int[pic.Length];
            but = new Button[pic.Length];
            AgregarPic();
        }



        public void AgregarPic()
        {


            foreach (var x in peli.GetPeliculas())
            {
                if (cont < pic.Length)
                {
                    ids[cont] = Convert.ToInt32(x.Id_pelicula);

                    foreach (var item in peli.ObtenerImagen(ids[cont]))
                    {
                        MemoryStream memo;
                        //MessageBox.Show("el ide es: " + ids[cont]);
                        memo = new MemoryStream(x.Imagen_pelicula);
                        pic[cont] = new PictureBox();
                        pic[cont].Image = null;
                        pic[cont].Image = (Image.FromStream(memo));
                        pic[cont].Width = 180;
                        pic[cont].Height = 260;
                        pic[cont].Location = new Point(60 * 5, 10 * 5);
                        pnlCuerpo.Controls.Add(pic[cont]);
                        pic[cont].SizeMode = PictureBoxSizeMode.StretchImage;
                        but[cont] = new Button();
                        but[cont].Width = 80;
                        but[cont].Height = 60;
                        but[cont].BackColor = Color.FromArgb(222, 72, 21);
                        but[cont].FlatStyle = FlatStyle.Flat;
                        but[cont].ForeColor = Color.White;
                        but[cont].Text = "Ver Horarios";
                        but[cont].Location = new Point(55, 200);
                        but[cont].Font = new Font("Century Gothic", 9, FontStyle.Regular);
                        pic[cont].Controls.Add(but[cont]);
                        but[cont].Tag = ids[cont];
                        but[cont].Click += new EventHandler(but_Click);
                    }
                    cont++;
                }
            }
        }

        private void but_Click(object sender, EventArgs e)
        {
            Button butt = (Button)sender;
            MessageBox.Show(""+ butt.Tag);
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
