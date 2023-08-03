using Prj_CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApliControl
{
    public partial class Frm_Regis_huella : Form
    {
        public Frm_Regis_huella()
        {
            InitializeComponent();
        }

        private void Frm_Regis_huella_Load(object sender, EventArgs e)
        {

        }

        string xFotoRuta = "";
        public void BuscarPersonalParaEditar(string idPersona)
        {
            try
            {
                RN_Personal obj = new RN_Personal();
                DataTable dt = new DataTable();
               
                dt = obj.RN_Buscar_todoPersonal(idPersona);
                if (dt.Rows.Count > 0)
                {
                    lblIdPersonal.Text = Convert.ToString(dt.Rows[0]["Id_Pernl"]);
                    lblDni.Text = Convert.ToString(dt.Rows[0]["DNIPR"]);
                    lblPersonal.Text = Convert.ToString(dt.Rows[0]["Nombre_Completo"]);
                    
                    xFotoRuta = Convert.ToString(dt.Rows[0]["Foto"]);

                    if (File.Exists(xFotoRuta) == true)
                    {
                        pictureBox1.Load(xFotoRuta);
                    }
                    else
                    {
                        pictureBox1.Load(Application.StartupPath + @"\user.png");
                    }

                }
                
               
            }
            catch (Exception)
            {


            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Tag = "";
            this.Close();

        }

        private void enrollmentControl1_OnStartEnroll(object Control, string ReaderSerialNumber, int Finger)
        {
            ListEvents.Items.Insert(0, string.Format("OnStartEnroll: {0}, finger {1}", ReaderSerialNumber, Finger));
        }

        private void enrollmentControl1_OnSampleQuality(object Control, string ReaderSerialNumber, int Finger, DPFP.Capture.CaptureFeedback CaptureFeedback)
        {
            ListEvents.Items.Insert(0, String.Format("OnSampleQuality: {0}, finger {1}, {2}", ReaderSerialNumber, Finger, CaptureFeedback));
        }

        private void enrollmentControl1_OnReaderDisconnect(object Control, string ReaderSerialNumber, int Finger)
        {
            ListEvents.Items.Insert(0, String.Format("OnReaderDisconnect: {0}, finger {1}", ReaderSerialNumber, Finger));
        }

        private void enrollmentControl1_OnReaderConnect(object Control, string ReaderSerialNumber, int Finger)
        {
            ListEvents.Items.Insert(0, String.Format("OnReaderConnect: {0}, finger {1}", ReaderSerialNumber, Finger));
        }

        private void enrollmentControl1_OnFingerTouch(object Control, string ReaderSerialNumber, int Finger)
        {
            ListEvents.Items.Insert(0, String.Format("OnFingerTouch: {0}, finger {1}", ReaderSerialNumber, Finger));
        }

        private void enrollmentControl1_OnFingerRemove(object Control, string ReaderSerialNumber, int Finger)
        {
            ListEvents.Items.Insert(0, String.Format("OnFingerRemove: {0}, finger {1}", ReaderSerialNumber, Finger));
        }

        private void enrollmentControl1_OnEnroll(object Control, int FingerMask, DPFP.Template Template, ref DPFP.Gui.EventHandlerStatus EventHandlerStatus)
        {
            byte[] bytes = null;
            RN_Personal objp = new RN_Personal();

            if(Template is null)
            {
                Template.Serialize(ref bytes);
                MessageBox.Show("No se Pudo realizar la Operacion Requerida", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblIdPersonal.Text = "";
                lblPersonal.Text = "";
                lblDni.Text = "";
                pictureBox1.Image = null;
                this.Tag = "";
                this.Close();

            }
            else
            {
                Template.Serialize(ref bytes);
                objp.RN_Registrar_Huella_Dactilar_Personal(lblIdPersonal.Text, bytes);
                enrollmentControl1.Enabled = false;
                lblIdPersonal.Text = "";
                lblPersonal.Text = "";
                lblDni.Text = "";
                pictureBox1.Image = null;
                MessageBox.Show("La Huella Dactilar del Personal, Fue registrado Exitosamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                this.Tag = "A";
                this.Close();
            }
        }
    }
}
