using MicroSisPlani.Msm_Forms;
using Prj_CapaNegocio;
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
    public partial class frmInformeDeDia : Form
    {
        public frmInformeDeDia()
        {
            InitializeComponent();
        }

        public string tipoReporte = "";
        private void frmInformeDeDia_Load(object sender, EventArgs e)
        {
            if (tipoReporte == "Dia")
            {
                GenerarInformeDelDia();
            }else if(tipoReporte == "Mes")
            {
                GenerarInformeDelMes();
            }
        }
           

        private void GenerarInformeDelDia()
        {
            RN_Asistencia obj = new RN_Asistencia();
            DataTable dt = new DataTable();


            dt = obj.cargarTodosAsistencia_delDia( Convert.ToDateTime( this.Tag.ToString()));

            if (dt.Rows.Count > 0)
            {
                rptAsistenciaDelDia rpt = new rptAsistenciaDelDia();
                rpt.SetDataSource (dt);
                vsrInfoAsistencia.ReportSource = rpt;
            }
            else
            {
                Frm_Advertencia dv = new Frm_Advertencia();
                dv.Lbl_Msm1.Text = "No hay Asistencia del Dia Seleccionado";
                dv.ShowDialog();
                dv.Tag = "";
                this.Tag = "";
                this.Close();
            }
        }

        private void GenerarInformeDelMes()
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Tag = "";
            this.Close();
        }
    }
}
