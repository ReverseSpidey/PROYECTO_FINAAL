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
    public partial class Asiento_Columna : Form
    {
        public int columns;
        newAsiento jeje;
        public Asiento_Columna()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            columns = Convert.ToInt32(txtColumnas.Text);

            this.DialogResult = DialogResult.OK;

            txtColumnas.Clear();
            jeje = new newAsiento(this);
        }
    }
}
