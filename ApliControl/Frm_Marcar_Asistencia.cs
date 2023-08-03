//using DPFP;
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
using MicroSisPlani.Msm_Forms;
using DPFP;
using DPFP.Gui;
using System.IO;
using System.Diagnostics.Eventing.Reader;
using Prj_Capa_Negocio;

namespace MicroSisPlani
{
    public partial class Frm_Marcar_Asistencia : Form
    {
        public Frm_Marcar_Asistencia()
        {
            InitializeComponent();

        }

        private void CargarHorarios()
        {
            RN_Horario objH = new RN_Horario();
            DataTable dt = new DataTable();

            dt = objH.RN_CargarHorario();
            if (dt.Rows.Count > 0)
            {
                dtp_horaIngre.Value = Convert.ToDateTime(dt.Rows[0]["HoEntrada"]);
                Lbl_HoraEntrada.Text = dtp_horaIngre.Value.Hour.ToString() + ":" + dtp_horaIngre.Value.Minute.ToString();
                dtp_horaSalida.Value = Convert.ToDateTime(dt.Rows[0]["HoSalida"]);
                dtp_hora_tolercia.Value = Convert.ToDateTime(dt.Rows[0]["MiTolrncia"]);
                Dtp_Hora_Limite.Value = Convert.ToDateTime(dt.Rows[0]["HoLimite"]);
            }
        }

        private void pnl_titulo_MouseMove(object sender, MouseEventArgs e)
        {
            Complementos move = new Complementos();
            if (e.Button == MouseButtons.Left)
            {
                move.Mover_formulario(this);
            }


        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private DPFP.Verification.Verification verificar;
        private DPFP.Verification.Verification.Result resultado;
        private void Frm_Marcar_Asistencia_Load(object sender, EventArgs e)
        {
            verificar = new DPFP.Verification.Verification();
            resultado = new DPFP.Verification.Verification.Result();

            CargarHorarios();
        }

        private void xVerificationControl_OnComplete(object Control, FeatureSet FeatureSet, ref EventHandlerStatus EventHandlerStatus)
        {
            Template template = new Template();

            RN_Personal obj = new RN_Personal();
            RN_Asistencia objas = new RN_Asistencia();
            DataTable datos = new DataTable();
            DataTable datosAsis = new DataTable();

            string nroIdPersona = "";
            int xint = 1;
            byte[] figuraByte;
            string rutaFoto;
            bool terminarBucle = false;
            int totalFila = 0;

            Frm_Filtro fil = new Frm_Filtro();

            int HoLimite = Dtp_Hora_Limite.Value.Hour;
            int miLimite = Dtp_Hora_Limite.Value.Minute;

            int HoraCaptu = DateTime.Now.Hour;
            int minuteCaptu = DateTime.Now.Minute;

            try
            {
                datos = obj.RN_Leer_todoPersonal();
                totalFila = datos.Rows.Count;

                if (datos.Rows.Count > 0)
                {
                    var datop = datos.Rows[0];

                    foreach (DataRow xItem in datos.Rows)
                    {
                        if (terminarBucle == true) { break; }
                        figuraByte = (byte[])xItem["FinguerPrint"];
                        nroIdPersona = Convert.ToString(xItem["Id_Pernl"]);

                        template.DeSerialize(figuraByte);

                        verificar.Verify(FeatureSet, template, ref resultado);

                        if (resultado.Verified == true)
                        {
                            rutaFoto = Convert.ToString(xItem["Foto"]);
                            lbl_nombresocio.Text = Convert.ToString(xItem["Nombre_Completo"]);
                            Lbl_Idperso.Text = Convert.ToString(xItem["Id_Pernl"]);
                            lbl_Dni.Text = Convert.ToString(xItem["DNIPR"]);

                            if (File.Exists(rutaFoto) == true) { picSocio.Load(rutaFoto); }

                            DataTable pasoAsis = objas.RN_Verificaciones_si_ya_paso_Asistencia(Lbl_Idperso.Text);
                            if (pasoAsis.Rows.Count > 0)
                            {
                                lbl_msm.BackColor = Color.MistyRose;
                                lbl_msm.ForeColor = Color.Red;
                                lbl_msm.Text = "El Sistema verificó, que el personal ya marco su asistencia";
                                lbl_Cont.Text = "10";
                                xVerificationControl.Enabled = false;
                                pnl_Msm.Visible = true;
                                tmr_Conta.Enabled = true;
                                return;
                            }

                            DataTable dtVerEntrada = objas.RN_Verificaciones_si_ya_paso_Asistencia_Entrada(Lbl_Idperso.Text);
                            if (dtVerEntrada.Rows.Count > 0)
                            {
                                Frm_Sino sino = new Frm_Sino();
                                terminarBucle = true;
                                fil.Show();
                                sino.Lbl_msm1.Text = "El usuario ya tiene un registro de entrada, ¿Te gustaria marcar la salida?";
                                sino.ShowDialog();
                                fil.Hide();

                                if (Convert.ToString(sino.Tag) == "Si")
                                {
                                    datosAsis = objas.BD_BuscarAsistenciEntrada(Lbl_Idperso.Text);
                                    if (datosAsis.Rows.Count == 0) { return; }

                                    lbl_IdAsis.Text = Convert.ToString(datosAsis.Rows[0]["Id_Asis"]);

                                    objas.RN_RegistrarSalidaPersonal(lbl_IdAsis.Text, Lbl_Idperso.Text, lbl_hora.Text, 8);

                                    lbl_msm.BackColor = Color.YellowGreen;
                                    lbl_msm.ForeColor = Color.White;
                                    lbl_msm.Text = "La Salida del Personal Fue Registrado Correctamente";

                                    xVerificationControl.Enabled = false;
                                    pnl_Msm.Visible = true;
                                    lbl_Cont.Text = "10";
                                    tmr_Conta.Enabled = true;
                                    terminarBucle = true;

                                }
                            }
                            else
                            {
                                //entonces marcar entrada
                                if (HoraCaptu >= HoLimite)
                                {
                                    lbl_msm.BackColor = Color.MistyRose;
                                    lbl_msm.ForeColor = Color.Red;
                                    lbl_msm.Text = "Estimado Usuario, Su Hora de Entrada ya Caduco, Vulve a casa y Regrese Mañana";


                                    pnl_Msm.Visible = true;
                                    lbl_Cont.Text = "10";
                                    tmr_Conta.Enabled = true;
                                    xVerificationControl.Enabled = false;
                                    return;

                                }

                                calcular_minutos_tardanza();
                                RN_Utilitario objUtil = new RN_Utilitario();
                                lbl_IdAsis.Text = objUtil.BD_nroDoc(3);

                                objas.RN_RegistrarEntradaPersonal(lbl_IdAsis.Text, Lbl_Idperso.Text, lbl_hora.Text, Convert.ToDouble(lbl_totaltarde.Text), int.Parse(lbl_TotalHotrabajda.Text), lbl_justifi.Text);

                                objUtil.BD_ActualizaTipoDoc(3);

                                lbl_msm.BackColor = Color.YellowGreen;
                                lbl_msm.ForeColor = Color.White;
                                lbl_msm.Text = "La Entrada del Personal Fue Registrado Exitosamente";
                                pnl_Msm.Visible = true;
                                lbl_Cont.Text = "10";
                                tmr_Conta.Enabled = true;
                                xVerificationControl.Enabled = false;
                                terminarBucle = true;
                            }
                        }
                        else
                        {
                            if (xint == totalFila)
                            {
                                if (terminarBucle == false)
                                {
                                    lbl_msm.BackColor = Color.MistyRose;
                                    lbl_msm.ForeColor = Color.Red;
                                    lbl_msm.Text = "La Huella Dactilar no existe en la Base de Datos";
                                    pnl_Msm.Visible = true;
                                    lbl_Cont.Text = "10";
                                    tmr_Conta.Enabled = true;
                                   
                                }
                            }
                        }
                        xint += 1;
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo malo paso : " + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
        }

        private int sec=10;
        private void tmr_Conta_Tick(object sender, EventArgs e)
        {
            sec -= 1;
            lbl_Cont.Text = sec.ToString();
            lbl_Cont.Refresh();
            if (sec == 0)
            {
                limpiarFormulario();
                sec = 10;
                tmr_Conta.Stop();
                pnl_Msm.Visible = false;
                xVerificationControl.Enabled = true;
                lbl_Cont.Text = "10";
            }
        }

       private void limpiarFormulario()
        {
            lbl_nombresocio.Text = "";
            lbl_totaltarde.Text = "0";
            lbl_TotalHotrabajda.Text = "0";
            lbl_Dni.Text = "";
            lbl_Cont.Text = "0";
            lbl_IdAsis.Text = "";
            Lbl_Idperso.Text = "";
            lbl_justifi.Text = "";
            lbl_msm.BackColor = Color.Transparent;
            lbl_msm.Text = "";
            picSocio.Image = null;
            xVerificationControl.Enabled = true;
       }

        void calcular_minutos_tardanza()
        {
            RN_Asistencia obj = new RN_Asistencia();
            int horaCaptura = DateTime.Now.Hour;
            int minutoCaptura = DateTime.Now.Minute;

            int horaIn = dtp_horaIngre.Value.Hour;
            int minuIn = dtp_horaIngre.Value.Minute;

            int mnTotole = dtp_hora_tolercia.Value.Minute;

            int totalMinutoFijo=0;
            int totalTardanza=0;

            DataTable dt = obj.RN_Verificaciones_JustificacionAprobada(Lbl_Idperso.Text);
            if (dt.Rows.Count > 0)
            {
                lbl_justifi.Text = "Tardanza Justificada";
            }
            else
            {
                lbl_justifi.Text = "Tardanza no Justificada";
                totalTardanza = minuIn + mnTotole;
                if(horaCaptura==horaIn & minutoCaptura > totalMinutoFijo)
                {
                    totalTardanza = minutoCaptura;
                    lbl_totaltarde.Text = Convert.ToString(totalTardanza);
                }else if (horaCaptura > horaIn)
                {
                    int horaTarde;
                    horaTarde = horaCaptura - horaIn;
                    int horaEnMinuto;
                    horaEnMinuto = horaTarde * 60;
                    int totalTardex = horaEnMinuto - totalMinutoFijo;
                    totalTardanza = minutoCaptura + totalTardex;
                    lbl_totaltarde.Text = Convert.ToString(totalTardanza);
                }
            }
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToString("hh:mm:ss");
        }
    }
}
