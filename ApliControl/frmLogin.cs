using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MicroSisPlani;
using Prj_CapaNegocio;


namespace ApliControl
{
    public partial class FormImagen : Form
    {
        public FormImagen()
        {
            InitializeComponent();
        }

        private void FormImagen_Load(object sender, EventArgs e)
        {
            
        }

        private bool validar()
        {
            if (txtUsu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingresa tu Usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsu.Focus();
                return false;
            }
            if (txtPass.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingresa tu Usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPass.Focus();
                return false;
            }
            return true;
        }

        private void AccesoAlSistema()
        {
            RU_Usuario objUsuario = new RU_Usuario();
            DataTable miDatos = new DataTable();
            int veces = 0;

            if (validar() == true)
            {
                DataTable dt = objUsuario.BD_verificar_Acceso(this.txtUsu.Text, this.txtPass.Text);
                if (dt.Rows.Count > 0)
                {
                    Cls_Libreria.Usuario = txtUsu.Text;
                    miDatos = objUsuario.BD_Leer_Datos_Usuario(txtUsu.Text);
                    DataRow dr = miDatos
                        .Rows[0];
                    Cls_Libreria.IdUsu = Convert.ToString(dr["Id_Usu"]);
                    Cls_Libreria.Apellidos = Convert.ToString(dr["Nombre_Completo"]);
                    Cls_Libreria.IdRol = Convert.ToString(dr["Id_Rol"]);
                    Cls_Libreria.Rol = dr["NomRol"].ToString();
                    Cls_Libreria.Foto =dr["Avatar"].ToString();
                    //los datos son correctos
                    //llenar datos del usuario a miDatos
                    // MessageBox.Show("Bienvenidos al sistema", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Frm_Principal frm = new Frm_Principal();
                    frm.Show();
                    frm.cargarDatosDeUsuario();
                }
                else
                {
                    //no son correctos
                    MessageBox.Show("Usuario o Contraseña no son validos:", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txtUsu.Text = "";
                    this.txtPass.Text = "";
                    txtUsu.Focus();

                    veces += 1;
                    if (veces == 3)
                    {
                        MessageBox.Show("El Nro Maximo de intentos fue superado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Application.Exit();
                    }
                }
            }
            else
            {
                return;
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsu_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtPass.Focus();
            }
        }

        private void elButton1_Click(object sender, EventArgs e)
        {
            AccesoAlSistema();
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                elButton1_Click(sender, e);
            }
        }
    }
}
