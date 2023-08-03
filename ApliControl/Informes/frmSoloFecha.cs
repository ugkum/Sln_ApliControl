using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApliControl.Informes
{
    public partial class frmSoloFecha : Form
    {
        public frmSoloFecha()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Tag = "A";
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Tag = "";
            this.Close();
        }
    }
}
