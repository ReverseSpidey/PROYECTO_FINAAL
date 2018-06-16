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
    public partial class SeccionAsientos : Form
    {
        srvAsiento asi = new srvAsiento();
        int nume;
        int cont = 0;
        char leter = 'A';
        int n;
        public SeccionAsientos()
        {
            InitializeComponent();


        }

    }
}
