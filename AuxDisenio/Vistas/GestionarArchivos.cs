using AuxDisenio.Controladores;
using AuxDisenio.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuxDisenio
{
    public partial class frmArchivos : Form
    {
        ArchivosController _aC = new ArchivosController();
        UsuariosController _uC = new UsuariosController();
        string _tipo;
        public frmArchivos(string text)
        {
            InitializeComponent();
        }
        public frmArchivos(string pCuenta, string pPass)
        {
            InitializeComponent();
            _tipo = _uC.obtenerTipo(pCuenta,pPass);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //// TODO: esta línea de código carga datos en la tabla 'dbSibaritaDataSet.Archivo' Puede moverla o quitarla según sea necesario.
            //this.sibaritaTableAdapter1.Fill(this.dbSibaritaDataSet.Archivo);
            //// TODO: esta línea de código carga datos en la tabla 'dbSibaritaDataSet.Archivo' Puede moverla o quitarla según sea necesario.
            //this.archivoTableAdapter1.Fill(this.dbSibaritaDataSet.Archivo);
            //// TODO: esta línea de código carga datos en la tabla 'textoDataSet.Archivo' Puede moverla o quitarla según sea necesario.
            //this.archivoTableAdapter.Fill(this.textoDataSet.Archivo);

            // Refresh();
            Listar(txtBusqueda.Text);
            MessageBox.Show(_tipo);
            if(_tipo=="Administrador")
            {
                btnGestionarUser.Visible = true;
            }
            else
            {
                btnGestionarUser.Visible = false;
            }
        }

        private void Listar(string pBuscar)
        {
            archivoBindingSource.DataSource = _aC.Listar(pBuscar);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Todos los archivos (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                archivoTextBox.Text = openFileDialog1.FileName;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if(nombreTextBox.Text.Trim().Equals("")||archivoTextBox.Text.Trim().Equals(""))
            {
                MessageBox.Show("El nombre es obligatorio");
                return;
            }
            byte[] file = null;
            Stream myStream = openFileDialog1.OpenFile();
            using (MemoryStream ms=new MemoryStream())
            {
                myStream.CopyTo(ms);
                file = ms.ToArray();
            }

            using(Data.dbSibaritaEntities db=new Data.dbSibaritaEntities())
            {
                Data.Archivo cArchivo = new Data.Archivo();
                cArchivo.nombre = nombreTextBox.Text.Trim();
                cArchivo.doc = file;
                cArchivo.realName = openFileDialog1.SafeFileName;

                db.Archivo.Add(cArchivo);
                db.SaveChanges();
            }
            //Refresh();
            Listar(txtBusqueda.Text);


        }
        private void Refresh()
        {
            using (Data.dbSibaritaEntities db = new Data.dbSibaritaEntities())
            {
                var lst = from d in db.Archivo
                          select new { d.nombre };
                archivoDataGridView.DataSource = lst.ToList();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (archivoDataGridView.Rows.Count > 0)
            {
                /*int id = int.Parse(archivoDataGridView.Rows[archivoDataGridView.CurrentRow.Index].Cells[0].Value.ToString())*/;
                int id = Convert.ToInt32(idLabel1.Text);
                using (Data.dbSibaritaEntities db = new Data.dbSibaritaEntities())
                {
                    var oArchivo = db.Archivo.Find(id);
                    string path = AppDomain.CurrentDomain.BaseDirectory;
                    string folder = path + "/temp/";
                    string fullFilePath = folder + oArchivo.realName;

                    if (!Directory.Exists(folder))
                        Directory.CreateDirectory(folder);
                    if (File.Exists(fullFilePath))
                        Directory.Delete(fullFilePath);
                    File.WriteAllBytes(fullFilePath, oArchivo.doc);
                    Process.Start(fullFilePath);
                }
            }
        }

        private void TxtBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Listar(txtBusqueda.Text);
            }
        }

        private void BtnGestionarUser_Click(object sender, EventArgs e)
        {
            GestionarUsers frm = new GestionarUsers();
            
            frm.ShowDialog();
            
        }
    }
}
