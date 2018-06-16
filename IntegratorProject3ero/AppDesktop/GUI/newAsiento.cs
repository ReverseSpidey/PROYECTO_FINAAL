using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos_Org.Modelo;
using Datos_Org.Servicios;

namespace AppDesktop.GUI
{
    public partial class newAsiento : Form
    {
        public bool es_nuevo;
        Asiento_Columna padre;
        srvAsiento asiento = new srvAsiento();
        char letter = 'A';
        ArrayList sent = new ArrayList();        
        int cont;
        Asiento asi;
        frmAsiento frmPadre;
        int cant_colum;
        public newAsiento(Asiento_Columna col)
        {
            InitializeComponent();
            padre = col;

        }
        public newAsiento(frmAsiento asient)
        {
            InitializeComponent();
            frmPadre = asient;
            es_nuevo = true;


        }
        public newAsiento(Asiento asii,frmAsiento obj)
        {
            InitializeComponent();
            frmPadre = obj;
            asi = asii;
            es_nuevo = false;//no es nueevo porque recibe datos del primer formulario
        }

        private void newAsiento_Load(object sender, EventArgs e)
        {
            llenarcomboSala();
            btnterminar.Visible = false;
        }

        private void llenarcomboSala()
        {

            cboFilas.Items.Add("Seleccionar");
            cboFilas.SelectedIndex = 0;
            
        }
        private void LlenarFilas()
        {
            try
            {
                if (txtFilas.Text != null)
                {
                    int max = Convert.ToInt32(txtFilas.Text);

                    for (int i = 0; i < max; i++)
                    {
                        cboFilas.Items.Add(letter);
                        letter++;
                    }
                    cont = max;
                }
            }
            catch (Exception e){
                MessageBox.Show("Verifica el número de filas");
                txtFilas.Clear();
            }
           
            
        }

        private void txtFilas_TextChanged(object sender, EventArgs e)
        {
            LlenarFilas();
        }


        private void VerificarColumns(object sender, EventArgs e)
        {
            int max = Convert.ToInt32(txtFilas.Text);

            if (sent.Contains(cboFilas.Text))
            {
                MessageBox.Show("Esta fila ya ha sido capturada");
            }
            else
            {
                sent.Add(cboFilas.Text);
                DialogResult jeje = new DialogResult();
                Asiento_Columna verif = new Asiento_Columna();
                jeje = verif.ShowDialog();

                if (jeje == DialogResult.OK)
                {
                    cont--;
                    lblFilas.Text = cont.ToString();
                }
            }
        }


        private Asiento RecuperarInfo()
        {
            cant_colum = padre.columns;
            for (int i = 0; i <= cant_colum; i++)
            {
                asi.Cod_sala = Convert.ToInt32(txtCod_sala.Text);
                asi.fila = cboFilas.Text;
                asi.columna = i.ToString();

            }



            return asi;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cont == 0)
            {
                btnterminar.Visible = true;
            }
            else
            {
            }
            asiento.AgregarAsiento(RecuperarInfo());


        }

        private void btnterminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
