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
    public partial class frmUsuario : Form
    {

        UsuariosController _objUsuario = new UsuariosController();
        private string _cuenta;
        private bool _esNuevo;
        public frmUsuario()
        {
            _esNuevo = true;
            InitializeComponent();

        }
        public frmUsuario(string pCuenta)
        {
            _cuenta = pCuenta;
            _esNuevo = false;
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            if (_esNuevo)
            {
                usuariosBindingSource1.AddNew();
            }
            else
            {
                MessageBox.Show(_cuenta);
                usuariosBindingSource1.DataSource = _objUsuario.BuscarPorPK(_cuenta);
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            var reg = CargarDatos();
            if (_esNuevo)
            {
                if (_objUsuario.Insertar(reg))
                {
                    MessageBox.Show("se inserto correctamente");
                    Close();
                }
            }
            else
            {
                if (_objUsuario.Modificar(reg))
                {
                    MessageBox.Show("modificacion exitosa");
                    Close();
                }
            }
        }

        private Usuarios CargarDatos()
        {
            var reg = (Usuarios)usuariosBindingSource1.Current;
            //reg.FechaNac = DateTime.Now;
            return reg;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

     
    }
}
