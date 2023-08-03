
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
using Prj_Capa_Entidad;
using Prj_Capa_Negocio;
using Prj_CapaNegocio;
using System.IO;
using System.Reflection;

namespace MicroSisPlani.Personal
{
    public partial class Frm_Registro_Personal : Form
    {
        public Frm_Registro_Personal()
        {
            InitializeComponent();
        }

        //public bool editPerso = false;
      
        private void Frm_Registro_Personal_Load(object sender, EventArgs e)
        {
            if (xEdit == false)
            {
                cargarRol();
                cargarDistrito();

            }

        }

        private void cargarRol()
        {
            RN_Rol objRol = new RN_Rol();
            DataTable dt = new DataTable();
            try
            {
                dt= objRol.RN_Buscar_Todos_Roles();
                if (dt.Rows.Count > 0)
                {
                    cbo_rol.DataSource = dt;
                    cbo_rol.DisplayMember = "NomRol";
                    cbo_rol.ValueMember = "Id_Rol";
                }
                cbo_rol.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                
            }
        }

        private void cargarDistrito()
        {
            RN_Distrito objRol = new RN_Distrito();
            DataTable dt = new DataTable();
            try
            {
                dt = objRol.RN_Buscar_Todos_Distrito();
                if (dt.Rows.Count > 0)
                {
                    cbo_Distrito.DataSource = dt;
                    cbo_Distrito.DisplayMember = "Distrito";
                    cbo_Distrito.ValueMember = "Id_Distrito";
                }
                cbo_Distrito.SelectedIndex = -1;
            }
            catch (Exception ex)
            {


            }
        }


        private bool validar()
        {
            Frm_Advertencia ver = new Frm_Advertencia();
            Frm_Filtro fil = new Frm_Filtro();
            if (txt_Dni.Text.Trim().Length < 8)
            {
                fil.Show();
                ver.Lbl_Msm1.Text = "El Nro de DNI debe tener 8 digitos";
                ver.ShowDialog(); fil.Hide();txt_Dni.Focus();
                return false;
            }
            if (txt_nombres.Text.Trim().Length < 2)
            {
                fil.Show();
                ver.Lbl_Msm1.Text = "Ingrese el nombre del Personal";
                ver.ShowDialog();fil.Hide();txt_nombres.Focus();
                return false;
            }
            if (txt_direccion.Text.Trim().Length < 4)
            {
                fil.Show();
                ver.Lbl_Msm1.Text = "Ingresa la direccion del Personal";
                ver.ShowDialog(); fil.Hide(); txt_direccion.Focus();
                return false;
            }
            if (txt_correo.Text.Trim().Length < 4)
            {
                fil.Show();
                ver.Lbl_Msm1.Text = "Ingresa el correo del Personal";
                ver.ShowDialog(); fil.Hide(); txt_correo.Focus();
                return false;
            }
            if (txt_NroCelular.Text.Trim().Length < 4)
            {
                fil.Show();
                ver.Lbl_Msm1.Text = "Ingresa el Nro Celular del Personal";
                ver.ShowDialog(); fil.Hide(); txt_NroCelular.Focus();
                return false;
            }

            if (txt_IdPersona.Text.Trim().Length < 8)
            {
                fil.Show();
                ver.Lbl_Msm1.Text = "El ID personal no fue generado";
                ver.ShowDialog(); fil.Hide(); txt_IdPersona.Focus();
                return false;
            }

            if (cbo_sexo.SelectedIndex==-1)
            {
                fil.Show();
                ver.Lbl_Msm1.Text = "Selecciona el sexo del Personal";
                ver.ShowDialog(); fil.Hide(); cbo_sexo.Focus();
                return false;
            }
            if (cbo_rol.SelectedIndex == -1)
            {
                fil.Show();
                ver.Lbl_Msm1.Text = "Selecciona el ROL del Personal";
                ver.ShowDialog(); fil.Hide(); cbo_rol.Focus();
                return false;
            }
            if (cbo_Distrito.SelectedIndex == -1)
            {
                fil.Show();
                ver.Lbl_Msm1.Text = "Selecciona el Distrito del Personal";
                ver.ShowDialog(); fil.Hide(); cbo_Distrito.Focus();
                return false;
            }

            return true;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Tag = "";
            this.Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Frm_Advertencia ok = new Frm_Advertencia();
            Frm_Filtro fil = new Frm_Filtro();
            RN_Personal objPer = new RN_Personal();
            DataTable dt = objPer.verificarDniPersonal(this.txt_Dni.Text);

            if (xEdit==false && Convert.ToInt32( dt.Rows[0][0].ToString()) > 0)
            {
                fil.Show();
                ok.Lbl_Msm1.Text = "El Nro de DNI ya existe en la Base de Datos, Verifica";
                ok.ShowDialog();
                fil.Hide();
                ok.Tag = "";
                ok.Close();
                return;

            }

            if (validar() == true)
            {
                if (xEdit == false) { GuardarPersonal(); } else { EditarPersonal(); }
                
            }
        }

        private void GuardarPersonal()
        {
            Frm_Msm_Bueno ok = new Frm_Msm_Bueno();
            Frm_Filtro fil = new Frm_Filtro();
            RN_Personal obj = new RN_Personal();
            EN_Persona per = new EN_Persona();

            try
            {
                per.Idpersonal = txt_IdPersona.Text;
                per.Dni = txt_Dni.Text;
                per.Nombres = txt_nombres.Text;
                per.anoNacimiento = dtpFechaNac.Value;
                per.Sexo = cbo_sexo.Text;
                per.Direccion = txt_direccion.Text;
                per.Correo = txt_correo.Text;
                per.Celular = Convert.ToInt32(txt_NroCelular.Text);
                per.IdRol = Convert.ToString(cbo_rol.SelectedValue);
                per.xImagen = xFotoRuta;
                per.IdDistrito = Convert.ToString(cbo_Distrito.SelectedValue);

                obj.RN_Registrar_Personal(per);

                fil.Show();
                ok.Lbl_msm1.Text = "Los datos del personal se han guardado de forma correcta";
                ok.ShowDialog();
                fil.Hide();
                this.Tag = "A";
                this.Close();
            
            }
            catch (Exception)
            {

                MessageBox.Show("Ocurrio un error al registrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditarPersonal()
        {
            Frm_Msm_Bueno ok = new Frm_Msm_Bueno();
            Frm_Filtro fil = new Frm_Filtro();
            RN_Personal obj = new RN_Personal();
            EN_Persona per = new EN_Persona();

            try
            {
                per.Idpersonal = txt_IdPersona.Text;
                per.Dni = txt_Dni.Text;
                per.Nombres = txt_nombres.Text;
                per.anoNacimiento = dtpFechaNac.Value;
                per.Sexo = cbo_sexo.Text;
                per.Direccion = txt_direccion.Text;
                per.Correo = txt_correo.Text;
                per.Celular = Convert.ToInt32(txt_NroCelular.Text);
                per.IdRol = Convert.ToString(cbo_rol.SelectedValue);
                per.xImagen = xFotoRuta;
                per.IdDistrito = Convert.ToString(cbo_Distrito.SelectedValue);

                obj.RN_Editar_Personal(per);

                fil.Show();
                ok.Lbl_msm1.Text = "Los datos del personal se han guardado de forma correcta";
                ok.ShowDialog();
                fil.Hide();
                this.Tag = "A";
                this.Close();

            }
            catch (Exception)
            {

                MessageBox.Show("Ocurrio un error al registrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        string xFotoRuta = Application.StartupPath + @"\user.png";
        private void Pic_persona_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    xFotoRuta = openFileDialog1.FileName;
                    Pic_persona.Load( xFotoRuta);
                }
            }
            catch (Exception ex)
            {
                xFotoRuta = Application.StartupPath+@"\user.png";
                Pic_persona.Image = ApliControl.Properties.Resources.user;
               
            }
        }

      

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Tag = "";
            this.Close();
        }

        private void pnl_titulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Utilitarios u = new Utilitarios();
                u.Mover_formulario(this);
            }
        }

       public bool xEdit = false;
        private void txt_NroCelular_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                string xCar1;
                string xCar2;

                if (xEdit == false)
                {
                    //generar codigo del personal
                    if (txt_Dni.Text.Length == 0) return;
                    if (txt_nombres.Text.Length == 0) return;

                    xCar1 = Convert.ToString(txt_Dni.Text).Substring(3, 5);
                    xCar2 = Convert.ToString(txt_nombres.Text).Substring(1, 4);

                    txt_IdPersona.Text = xCar1 + "-" + xCar2;

                }
            }
            catch (Exception)
            {


            }
            

        }

        public void BuscarPersonalParaEditar(string idPersona)
        {
            try
            {
                RN_Personal obj = new RN_Personal();
                DataTable dt = new DataTable();
                cargarRol();
                cargarDistrito();
                dt = obj.RN_Buscar_todoPersonal(idPersona);
                if (dt.Rows.Count > 0)
                {
                    txt_IdPersona.Text = Convert.ToString(dt.Rows[0]["Id_Pernl"]);
                    txt_Dni.Text = Convert.ToString(dt.Rows[0]["DNIPR"]);
                    txt_nombres.Text = Convert.ToString(dt.Rows[0]["Nombre_Completo"]);
                    txt_direccion.Text = Convert.ToString(dt.Rows[0]["Domicilio"]);
                    txt_correo.Text = Convert.ToString(dt.Rows[0]["Correo"]);
                    cbo_sexo.Text = Convert.ToString(dt.Rows[0]["Sexo"]);
                    dtpFechaNac.Value = Convert.ToDateTime(dt.Rows[0]["Fec_Naci"]);
                    txt_NroCelular.Text = Convert.ToString(dt.Rows[0]["Celular"]);
                    cbo_rol.SelectedValue = Convert.ToString(dt.Rows[0]["Id_Rol"]);
                    cbo_Distrito.SelectedValue = Convert.ToString(dt.Rows[0]["Id_Distrito"]);
                    xFotoRuta = Convert.ToString(dt.Rows[0]["Foto"]);


                    xEdit = true;
                    btn_aceptar.Enabled = true;
                    //Pic_persona.Load(xFotoRuta);
                    if (File.Exists(xFotoRuta) == true)
                    {
                        Pic_persona.Load(xFotoRuta);
                    }
                    else
                    {
                        Pic_persona.Load(Application.StartupPath + @"\user.png");
                    }
                }
            
            }
            catch (Exception)
            {


            }
        }

        private void txt_Dni_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                string xCar1;
                string xCar2;

                if (xEdit == false)
                {
                    //generar codigo del personal
                    if (txt_Dni.Text.Length == 0) return;
                    if (txt_nombres.Text.Length == 0) return;

                    xCar1 = Convert.ToString(txt_Dni.Text).Substring(3, 5);
                    xCar2 = Convert.ToString(txt_nombres.Text).Substring(1, 4);

                    txt_IdPersona.Text = xCar1 + "-" + xCar2;

                }
            }
            catch (Exception)
            {


            }
        }

        private void txt_nombres_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                string xCar1;
                string xCar2;

                if (xEdit == false)
                {
                    //generar codigo del personal
                    if (txt_Dni.Text.Length == 0) return;
                    if (txt_nombres.Text.Length == 0) return;

                    xCar1 = Convert.ToString(txt_Dni.Text).Substring(3, 5);
                    xCar2 = Convert.ToString(txt_nombres.Text).Substring(1, 4);

                    txt_IdPersona.Text = xCar1 + "-" + xCar2;

                }
            }
            catch (Exception)
            {


            }
        }
    }
}
