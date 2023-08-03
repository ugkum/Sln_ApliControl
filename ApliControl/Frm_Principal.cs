using MicroSisPlani.Personal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prj_Capa_Entidad;
using Prj_Capa_Negocio;
using Prj_CapaNegocio;
using MicroSisPlani.Msm_Forms;
using System.IO;
using MicroSisPlani.Informes;
using ApliControl;
using ApliControl.Informes;

namespace MicroSisPlani
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        RN_Utilitario objUtil = new RN_Utilitario();

        void cargarRobotTipo()
        {
            string res = objUtil.BD_ListarTipoFalta(5);
            if (res == "Si") { rdb_ActivarRobot.Checked= true; }
            else if (res == "No") { rdb_Desact_Robot.Checked = true; }
        }
        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            btn_cancel_horio.ForeColor = Color.White;

            ListarPersonal();
            ConfiguraListviewAsistencia();
            CargarHorario();
            cargarRobotTipo();
            timerFalta.Start();
        }



        private void pnl_titu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button ==MouseButtons.Left )
            {
                Utilitarios u = new Utilitarios();
                u.Mover_formulario(this);
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Explorador_Personal pers = new Frm_Explorador_Personal();
            pers.MdiParent = this;
            pers.Show();

        }

        private void bt_personal_Click(object sender, EventArgs e)
        {
           
            elTabPage2 .Visible = true;
            elTab1.SelectedTabPageIndex = 1;
            CargarTodoPersonal();


        }

        private void Frm_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Sino sino = new Frm_Sino();

            fil.Show();
            sino.Lbl_msm1.Text = "¿Estas Seguro de Salir y Abandonar el sistema?";
            sino.ShowDialog();
            fil.Hide();
            if (Convert.ToString(sino.Tag) == "Si")
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }

        }

        public void cargarDatosDeUsuario()
        {
            try
            {
                Frm_Filtro fil = new Frm_Filtro();
                fil.Show();
                MessageBox.Show("Bienvenido Sr: " + Cls_Libreria.Apellidos ," Bienvenido al Sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
                fil.Hide();
                Lbl_NomUsu.Text = Cls_Libreria.Apellidos;
                lbl_rolNom.Text = Cls_Libreria.Rol;

                if (Cls_Libreria.Foto.Trim().Length == 0 | Cls_Libreria.Foto == null) return;
                if (File.Exists(Cls_Libreria.Foto) == true)
                {
                    pic_user.Load(Cls_Libreria.Foto);
                }
                else
                {
                    pic_user.Image = ApliControl.Properties.Resources.user;
                }
            }
            catch (Exception)
            {

               
            }
        }
        private void btn_nuevoAsis_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Marcar_Asis_Manual frm = new Frm_Marcar_Asis_Manual();
            fil.Show();
            frm.ShowDialog();
            fil.Hide();
        }

        private void bt_Explo_Asis_Click(object sender, EventArgs e)
        {

            elTabPage3.Visible = false;
            elTab1.SelectedTabPageIndex = 2;
            Cargar_Todas_Asistencia_delDia(dtpFechaAsis.Value);

        }

        private void Btn_Cerrar_TabPers_Click(object sender, EventArgs e)
        {
            elTabPage2 .Visible = false ;
            elTab1.SelectedTabPageIndex = 0;
        }

        private void btn_cerrarEx_Asis_Click(object sender, EventArgs e)
        {
            elTabPage3.Visible = false;
            elTab1.SelectedTabPageIndex = 0;
        }

        private void bt_copiarNroDNI_Click(object sender, EventArgs e)
        {
           
        }


        #region "Personal"
        private void ListarPersonal()
        {
            var lis = lsv_person;
            lis.Columns.Clear();
            lis.Items.Clear();
            lis.View = View.Details;
            lis.GridLines = true;
            lis.FullRowSelect = true;
            lis.Scrollable = true;
            lis.HideSelection = false;
            lis.Columns.Add("Id Persona", 0, HorizontalAlignment.Left);
            lis.Columns.Add("Dni", 95, HorizontalAlignment.Left);
            lis.Columns.Add("Nombre del Socio", 316, HorizontalAlignment.Left);
            lis.Columns.Add("Direccion", 0, HorizontalAlignment.Left);
            lis.Columns.Add("Correo", 0, HorizontalAlignment.Left);
            lis.Columns.Add("Sex", 0, HorizontalAlignment.Left);
            lis.Columns.Add("Fec Nacim.", 110, HorizontalAlignment.Left);
            lis.Columns.Add("Nro Celular", 120, HorizontalAlignment.Left);
            lis.Columns.Add("Rol", 100, HorizontalAlignment.Left);
            lis.Columns.Add("Distrito", 0, HorizontalAlignment.Left);
            lis.Columns.Add("Estado", 100, HorizontalAlignment.Left);
        }

        private void CargarTodoPersonal()
        {
            RN_Personal objP = new RN_Personal();
            DataTable dt = new DataTable();
            dt = objP.RN_Leer_todoPersonal();
            if (dt.Rows.Count > 0)
            {
                llenarlisview(dt);

            }

        }

        private void BuscarTodoPersonal(string buscar)
        {
            RN_Personal objP = new RN_Personal();
            DataTable dt = new DataTable();
            dt = objP.RN_Buscar_todoPersonal(buscar);
            if (dt.Rows.Count > 0)
            {
                llenarlisview(dt);

            }
            else
            {
                lsv_person.Items.Clear();
            }

        }

        private void llenarlisview(DataTable dt)
        {
          
            lsv_person.Items.Clear();
            for(int i =0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem fila = new ListViewItem(dr["Id_Pernl"].ToString());
                fila.SubItems.Add(dr["DNIPR"].ToString()); 
                fila.SubItems.Add(dr["Nombre_Completo"].ToString());
                fila.SubItems.Add(dr["Domicilio"].ToString());
                fila.SubItems.Add(dr["Correo"].ToString());
                fila.SubItems.Add(dr["Sexo"].ToString());
                fila.SubItems.Add(dr["Fec_Naci"].ToString());
                fila.SubItems.Add(dr["Celular"].ToString());
                fila.SubItems.Add(dr["NomRol"].ToString());
                fila.SubItems.Add(dr["Distrito"].ToString());
                fila.SubItems.Add(dr["Estado_Per"].ToString());

                lsv_person.Items.Add(fila);
            }

            Lbl_total.Text = Convert.ToString(lsv_person.Items.Count);
        

        }
       

        private void Bt_NewPerso_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Registro_Personal per = new Frm_Registro_Personal();

            fil.Show();
            per.xEdit = false;
            per.ShowDialog();
            fil.Hide();

            if (Convert.ToString(per.Tag) == "")
            {
                return;
            }
            CargarTodoPersonal();


        }

        private void txt_Buscar_OnValueChanged(object sender, EventArgs e)
        {
            if(txt_Buscar.Text.Trim().Length > 2)
            {
                BuscarTodoPersonal(txt_Buscar.Text);
            }
        }
        #endregion

        private void txt_Buscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                BuscarTodoPersonal(txt_Buscar.Text);
            }
        }

        private void btn_VerTodoPerso_Click(object sender, EventArgs e)
        {
            CargarTodoPersonal();
        }

        private void Btn_EditPerso_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Registro_Personal per = new Frm_Registro_Personal();
            if (lsv_person.SelectedIndices.Count == 0)
            {
                //mostrar mensaje

            }
            else
            {
                var ls = lsv_person.SelectedItems[0];
                string idPersona = ls.SubItems[0].Text;
                fil.Show();
                per.BuscarPersonalParaEditar(idPersona);
                per.ShowDialog();
                fil.Hide();
                if (per.Tag.ToString() == "A")
                {
                    CargarTodoPersonal();
                }
            }
        }

        private void btn_SaveHorario_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Msm_Bueno ok = new Frm_Msm_Bueno();
            Frm_Advertencia adver = new Frm_Advertencia();

            try
            {
                RN_Horario hor = new RN_Horario();
                EN_Horario por = new EN_Horario();

               

                por.Idhora = lbl_idHorario.Text;
                por.HoEntrada = dtp_horaIngre.Value;
                por.HoTole = dtp_hora_tolercia.Value;
                por.HoLimite = Dtp_Hora_Limite.Value;
                por.HoSalida = dtp_horaSalida.Value;

                hor.RN_ActualizarHorario(por);
                fil.Show();
                ok.Lbl_msm1.Text = "El Horario fue Actualizado";
                ok.ShowDialog();
                fil.Hide();
                elTabPage4.Visible = false;
                elTab1.SelectedTabPageIndex = 0;
            }
            catch (Exception)
            {

                fil.Show();
                adver.Lbl_Msm1.Text = "Ocurrio un Error al Actualizar";
                adver.ShowDialog();
                fil.Hide();

               
            }
        }

        private void bt_Config_Click(object sender, EventArgs e)
        {
            elTabPage4.Visible = true;
            elTab1.SelectedTabPageIndex = 3;
            CargarHorario();
            cargarRobotTipo();
        }

        private void CargarHorario()
        {
            RN_Horario obj = new RN_Horario();
            DataTable dt = new DataTable();

            dt = obj.RN_CargarHorario();
            if (dt.Rows.Count == 0) return;

            lbl_idHorario.Text = Convert.ToString(dt.Rows[0]["Id_Hor"]);
            dtp_horaIngre.Value= Convert.ToDateTime(dt.Rows[0]["HoEntrada"]);
            dtp_horaSalida.Value = Convert.ToDateTime(dt.Rows[0]["HoSalida"]);
            dtp_hora_tolercia.Value = Convert.ToDateTime(dt.Rows[0]["MiTolrncia"]);
            Dtp_Hora_Limite.Value = Convert.ToDateTime(dt.Rows[0]["HoLimite"]);
        }

        #region "Assitencia"
        private void ConfiguraListviewAsistencia()
        {
            lsv_asis.Columns.Clear();
            lsv_asis.Items.Clear();
            lsv_asis.View = View.Details;
            lsv_asis.GridLines = true;
            lsv_asis.FullRowSelect = true;
            lsv_asis.Scrollable = true;
            lsv_asis.HideSelection = false;
            lsv_asis.Columns.Add("Id Asis", 0, HorizontalAlignment.Left);
            lsv_asis.Columns.Add("Dni", 80, HorizontalAlignment.Left);
            lsv_asis.Columns.Add("Nombre del Personal", 316, HorizontalAlignment.Left);
            lsv_asis.Columns.Add("Fecha", 90, HorizontalAlignment.Left);
            lsv_asis.Columns.Add("Dia", 80, HorizontalAlignment.Left);
            lsv_asis.Columns.Add("Ho Ingreso", 90, HorizontalAlignment.Left);
            lsv_asis.Columns.Add("Tardnza", 70, HorizontalAlignment.Left);
            lsv_asis.Columns.Add("Ho Salida", 90, HorizontalAlignment.Left);
            lsv_asis.Columns.Add("Adelanto", 90, HorizontalAlignment.Left);
            lsv_asis.Columns.Add("Justificacion", 0, HorizontalAlignment.Left);
            lsv_asis.Columns.Add("Estado", 100, HorizontalAlignment.Left);
            
        }

        private void Cargar_Todas_Asistencia()
        {
            RN_Asistencia obj = new RN_Asistencia();
            DataTable dt = new DataTable();
            dt = obj.cargarTodosAsistencia();
            if (dt.Rows.Count > 0)
            {
                llenarlisview_asis(dt);
            }
        }

        private void Cargar_Todas_Asistencia_delDia(DateTime dia)
        {
            RN_Asistencia obj = new RN_Asistencia();
            DataTable dt = new DataTable();
            dt = obj.cargarTodosAsistencia_delDia(dia);
            if (dt.Rows.Count > 0)
            {
                llenarlisview_asis(dt);
            }
        }

        private void Cargar_Todas_Asistencia_xMes(DateTime fecha)
        {
            RN_Asistencia obj = new RN_Asistencia();
            DataTable dt = new DataTable();
            dt = obj.cargarTodosAsistencia_delMes(fecha);
            if (dt.Rows.Count > 0)
            {
                llenarlisview_asis(dt);
            }
        }

        private void Cargar_Todas_Asistencia_xValor(string valor)
        {
            RN_Asistencia obj = new RN_Asistencia();
            DataTable dt = new DataTable();
            dt = obj.BuscarAsistenciaParaExplorador(valor);
            if (dt.Rows.Count > 0)
            {
                llenarlisview_asis(dt);
            }
        }

        private void llenarlisview_asis(DataTable dt)
        {

            lsv_asis.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem fila = new ListViewItem(dr["Id_asis"].ToString());
                fila.SubItems.Add(dr["DNIPR"].ToString());
                fila.SubItems.Add(dr["Nombre_Completo"].ToString());
                fila.SubItems.Add(dr["FechaAsis"].ToString());
                fila.SubItems.Add(dr["Nombre_dia"].ToString());
                fila.SubItems.Add(dr["HoIngreso"].ToString());
                fila.SubItems.Add(dr["Tardanzas"].ToString());
                fila.SubItems.Add(dr["HoSalida"].ToString());
                fila.SubItems.Add(dr["Adelanto"].ToString());
                fila.SubItems.Add(dr["Justifacion"].ToString());
                fila.SubItems.Add(dr["EstadoAsis"].ToString());

                lsv_asis.Items.Add(fila);
            }
        }


        #endregion

        private void txt_buscarAsis_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Cargar_Todas_Asistencia_xValor(txt_buscarAsis.Text);
            }
        }

        private void lbl_lupaAsis_Click(object sender, EventArgs e)
        {
            Cargar_Todas_Asistencia();
        }

        private void verAsistenciaDelDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Solo_Fecha solo = new Frm_Solo_Fecha();
            fil.Show();
            solo.ShowDialog();
            fil.Hide();
            if (solo.Tag.ToString() == "A")
            {
                DateTime xFecha = solo.dtp_fecha.Value;
                Cargar_Todas_Asistencia_delDia(xFecha);
            }
            else
            {
                lsv_asis.Items.Clear();
            }
            
        }

        private void mostrarTodoAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cargar_Todas_Asistencia();
        }

        private void bt_registrarHuellaDigital_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Regis_huella per = new Frm_Regis_huella();
           

            if (lsv_person.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Selecciona el Personal para Editar Su Huella", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                var lsv = lsv_person.SelectedItems[0];
                string xidPer = lsv.SubItems[0].Text;
                fil.Show();
                per.BuscarPersonalParaEditar(xidPer);
                per.ShowDialog();
                fil.Hide();

                if (Convert.ToString(per.Tag) == "")
                {
                    CargarTodoPersonal();
                }
            }
        }

        private void btn_Asis_With_Huella_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Marcar_Asistencia frm = new Frm_Marcar_Asistencia();
            fil.Show();
            frm.ShowDialog();
            fil.Hide();
        }

        private void btn_Savedrobot_Click(object sender, EventArgs e)
        {
            string serie = "";

            if (rdb_ActivarRobot.Checked == true)
            {
                serie = "Si";
            }else if(rdb_Desact_Robot.Checked == true)
            {
                serie = "No";
            }

           
            objUtil.BD_ActualizarRobotFalta(5, serie);
            cargarRobotTipo();

            Frm_Filtro fil = new Frm_Filtro();
            Frm_Msm_Bueno ok = new Frm_Msm_Bueno();
            fil.Show();
            ok.Lbl_msm1.Text = "El Robot fue Actualizado";
            ok.ShowDialog();
            fil.Hide();

            elTab1.SelectedTabPageIndex = 0;
            elTabPage4.Visible = false;
        }

        private void elTabPage4_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancel_horio_Click(object sender, EventArgs e)
        {
            elTab1.SelectedTabPageIndex = 0;
            elTabPage4.Visible = false;
        }

        private void bt_nuevoPersonal_Click(object sender, EventArgs e)
        {
            Bt_NewPerso_Click(sender,e);
        }

        private void bt_editarPersonal_Click(object sender, EventArgs e)
        {
            Btn_EditPerso_Click(sender, e);
        }

        private void bt_mostrarTodoElPersonal_Click(object sender, EventArgs e)
        {
            CargarTodoPersonal();
        }

        private void timerFalta_Tick(object sender, EventArgs e)
        {
            RN_Asistencia obj = new RN_Asistencia();
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Advertencia adver = new Frm_Advertencia();
            Frm_Msm_Bueno bueno = new Frm_Msm_Bueno();
            DataTable datPer = new DataTable();
            RN_Personal objPer = new RN_Personal();

            int HoLimite = Dtp_Hora_Limite.Value.Hour;
            int MiLimite = Dtp_Hora_Limite.Value.Minute;

            int HoraCap = DateTime.Now.Hour;
            int MinuCap = DateTime.Now.Minute;

            string dniPer = "";
            int cant = 0;
            int TotalItem = 0;
            string xIdPersona = "";
            string idAsis = "";
            string xjustificacion = "";

            if (HoraCap >= HoLimite)
            {
                if (MinuCap > MiLimite)
                {
                    datPer = objPer.RN_Leer_todoPersonal();
                    if(datPer.Rows.Count > 0)
                    {
                        TotalItem = datPer.Rows.Count;
                        foreach (DataRow dr in datPer.Rows)
                        {
                            dniPer = Convert.ToString(dr["DNIPR"]);
                            xIdPersona = Convert.ToString(dr["Id_Pernl"]);

                            DataTable dtCheckAssi = obj.BD_Chekar_Si_PersonalTieneAsistenciaRegistrada(xIdPersona);

                            if ( Convert.ToInt32( dtCheckAssi.Rows[0][0].ToString())==0)
                            {
                                DataTable dtMarcoFalta = obj.BD_Chekar_Si_ya_Marco_Falta(xIdPersona);
                                if (Convert.ToInt32(dtMarcoFalta.Rows[0][0].ToString()) == 0)
                                {
                                    RN_Asistencia objAsistencia1 = new RN_Asistencia();
                                    EN_Asistencia objEAsis = new EN_Asistencia();
                                    RN_Utilitario objUtil = new RN_Utilitario();
                                    //idAsis = objUtil.BD_nroDoc(3);
                                    DataTable dtJus = objAsistencia1.RN_Verificaciones_JustificacionAprobada(xIdPersona);
                                    if (Convert.ToInt32(dtJus.Rows[0][0].ToString()) > 0)
                                    {
                                        xjustificacion = "Falta Tiene Justificación";
                                    }
                                    else
                                    {
                                        xjustificacion = "No Tiene Justificación";
                                    }

                                    objAsistencia1.BD_Registrar_Falta_Personal(xIdPersona, xjustificacion);
                                    //objUtil.BD_ActualizaTipoDoc(3);
                                    cant += 1;
                                }
                            }
                        }
                        if (cant > 1)
                        {
                            timerFalta.Stop();
                            fil.Show();
                            bueno.Lbl_msm1.Text = "Un total de " + cant.ToString()+"/"+TotalItem+" faltas se han registrado exitosamente";
                            bueno.Show();
                            fil.Hide();
                        }
                        else
                        {
                            timerFalta.Stop();
                            fil.Show();
                            bueno.Lbl_msm1.Text = "El dia de hoy no falto nadie al trabajo, las " + TotalItem+" Personas Marcaron su Asistencia";
                            bueno.Show();
                            fil.Hide();
                        }
                    }
                    else
                    {
                        return;
                    }
                }
            }

        }

        private void imprimirAsistenciaDelDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            frmInformeDeDia frm = new frmInformeDeDia();
            Frm_Solo_Fecha frmFecha = new Frm_Solo_Fecha();

            fil.Show();
            frmFecha.ShowDialog();
            fil.Hide();

            if (frmFecha.Tag.ToString() == "")
            {
                return;
            }

            DateTime fecha = frmFecha.dtp_fecha.Value;
            frm.tipoReporte = "Dia";
            frm.Tag = fecha.ToString();
            fil.Show();
            frm.ShowDialog();
            fil.Hide();

        }
    }
}
