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

namespace AuxDisenio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ArchivoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.archivoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.textoDataSet);

        }

        private void ArchivoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.archivoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.textoDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'textoDataSet.Archivo' Puede moverla o quitarla según sea necesario.
            this.archivoTableAdapter.Fill(this.textoDataSet.Archivo);

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

            using(Data.textoEntities db=new Data.textoEntities())
            {
                Data.Archivo archivo = new data
            }
        }
    }
}
