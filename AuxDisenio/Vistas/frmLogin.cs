using AuxDisenio.Controladores;
using AuxDisenio.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuxDisenio.Vistas
{
    public partial class frmLogin : Form
    {
        UsuariosController _User = new UsuariosController();
        public frmLogin()
        {
            InitializeComponent();
        }
        private void BtnLogAceptar_Click(object sender, EventArgs e)
        {
            if (_User.Autenticar(txtuser.Text, txtpass.Text))
            {
                //var reg = (Usuarios)usuarioBindingSource.Current;
                //usuariosBindingSource.DataSource = _User.ObtenerIDUsuario(txtuser.Text, txtpass.Text);
                this.Hide();
                frmArchivos frm = new frmArchivos(txtuser.Text, txtpass.Text);
                frm.ShowDialog();


            }
            else
                MessageBox.Show("LA CUENTA O CONTRASEÑA SON INCORRECTOS", "NO SE PUDO INICIAR SESION", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnLogCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Txtuser_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                e.Handled = true; //silencia el sonido enter
                btnLogAceptar.PerformClick(); ;
            }
        }
    }
}
