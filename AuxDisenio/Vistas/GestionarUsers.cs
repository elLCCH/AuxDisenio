using AuxDisenio.Controladores;
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
    public partial class GestionarUsers : Form
    {

        UsuariosController _objUsuario = new UsuariosController();
        public GestionarUsers()
        {
            InitializeComponent();
        }

        private void frmGestionarUsuarios_Load(object sender, EventArgs e)
        {
            Listar(txtBusqueda.Text);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            frmUsuario AddUsuario = new frmUsuario();
            AddUsuario.ShowDialog();
            Listar(txtBusqueda.Text);

        }

        private void Listar(string pBuscar)
        {

            usuariosBindingSource.DataSource = _objUsuario.Listar(pBuscar);
            // usuariosDataGridView.Columns["imagen"].Visible = false;

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            frmUsuario AddUser = new frmUsuario(cuentaLabel1.Text);
            AddUser.ShowDialog();
            _objUsuario = new UsuariosController();
            Listar(txtBusqueda.Text);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("ELiminar registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                _objUsuario.Eliminar(cuentaLabel1.Text);
                _objUsuario = new UsuariosController();
                Listar(txtBusqueda.Text);
            }
        }



        private void TxtBusqueda_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void usuariosDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.usuariosDataGridView.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.usuariosDataGridView.Rows[e.RowIndex].Cells["Eliminar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\\Delete.ico"); //Recuerden colocar su icono en la carpeta debug de su proyecto
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.usuariosDataGridView.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.usuariosDataGridView.Columns[e.ColumnIndex].Width = icoAtomico.Width + 8;

                e.Handled = true;
            }
            if (e.ColumnIndex >= 0 && this.usuariosDataGridView.Columns[e.ColumnIndex].Name == "Modificar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.usuariosDataGridView.Rows[e.RowIndex].Cells["Modificar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\\Update.ico"); //Recuerden colocar su icono en la carpeta debug de su proyecto
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.usuariosDataGridView.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.usuariosDataGridView.Columns[e.ColumnIndex].Width = icoAtomico.Width + 8;

                e.Handled = true;
            }
            if (e.ColumnIndex >= 0 && this.usuariosDataGridView.Columns[e.ColumnIndex].Name == "Agregar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.usuariosDataGridView.Rows[e.RowIndex].Cells["Agregar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\\Add.ico"); //Recuerden colocar su icono en la carpeta debug de su proyecto
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.usuariosDataGridView.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.usuariosDataGridView.Columns[e.ColumnIndex].Width = icoAtomico.Width + 8;

                e.Handled = true;
            }
        }

        private void usuariosDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.usuariosDataGridView.Columns[e.ColumnIndex].Name == "Eliminar")
            {

                // MessageBox.Show("hola");

                DialogResult res = MessageBox.Show("ELiminar registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    _objUsuario.Eliminar(cuentaLabel1.Text);
                    _objUsuario = new UsuariosController();
                    Listar(txtBusqueda.Text);
                }

            }
            if (this.usuariosDataGridView.Columns[e.ColumnIndex].Name == "Modificar")
            {

                // MessageBox.Show("XD");
                frmUsuario AddUser = new frmUsuario(cuentaLabel1.Text);
                AddUser.ShowDialog();
                _objUsuario = new UsuariosController();
                Listar(txtBusqueda.Text);

            }
            if (this.usuariosDataGridView.Columns[e.ColumnIndex].Name == "Agregar")
            {

                // MessageBox.Show("XD");
                frmUsuario AddUsuario = new frmUsuario();
                AddUsuario.ShowDialog();
                Listar(txtBusqueda.Text);

            }
        }

    }
}
