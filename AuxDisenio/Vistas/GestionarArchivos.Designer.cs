namespace AuxDisenio
{
    partial class frmArchivos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nombreLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArchivos));
            System.Windows.Forms.Label idLabel;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.archivoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.archivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.archivoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.archivoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idLabel1 = new System.Windows.Forms.Label();
            this.archivoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nombreLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.archivoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.archivoBindingNavigator)).BeginInit();
            this.archivoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.archivoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(17, 109);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(45, 13);
            nombreLabel.TabIndex = 10;
            nombreLabel.Text = "nombre:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(idLabel);
            this.splitContainer1.Panel1.Controls.Add(this.idLabel1);
            this.splitContainer1.Panel1.Controls.Add(this.txtBusqueda);
            this.splitContainer1.Panel1.Controls.Add(this.archivoTextBox);
            this.splitContainer1.Panel1.Controls.Add(nombreLabel);
            this.splitContainer1.Panel1.Controls.Add(this.nombreTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.btnSeleccionar);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.archivoDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 172;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(137, 134);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(340, 20);
            this.txtBusqueda.TabIndex = 16;
            this.txtBusqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtBusqueda_KeyUp);
            // 
            // archivoTextBox
            // 
            this.archivoTextBox.Location = new System.Drawing.Point(272, 106);
            this.archivoTextBox.Name = "archivoTextBox";
            this.archivoTextBox.Size = new System.Drawing.Size(449, 20);
            this.archivoTextBox.TabIndex = 14;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(81, 106);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(147, 20);
            this.nombreTextBox.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(629, 132);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Abrir Documento";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(512, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Subir Archivo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(723, 105);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(28, 21);
            this.btnSeleccionar.TabIndex = 6;
            this.btnSeleccionar.Text = "...";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // archivoBindingSource
            // 
            this.archivoBindingSource.DataSource = typeof(AuxDisenio.Data.Archivo);
            // 
            // archivoBindingNavigator
            // 
            this.archivoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.archivoBindingNavigator.BindingSource = this.archivoBindingSource;
            this.archivoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.archivoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.archivoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.archivoBindingNavigatorSaveItem});
            this.archivoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.archivoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.archivoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.archivoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.archivoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.archivoBindingNavigator.Name = "archivoBindingNavigator";
            this.archivoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.archivoBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.archivoBindingNavigator.TabIndex = 1;
            this.archivoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // archivoBindingNavigatorSaveItem
            // 
            this.archivoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.archivoBindingNavigatorSaveItem.Enabled = false;
            this.archivoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("archivoBindingNavigatorSaveItem.Image")));
            this.archivoBindingNavigatorSaveItem.Name = "archivoBindingNavigatorSaveItem";
            this.archivoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.archivoBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(20, 80);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 16;
            idLabel.Text = "id:";
            // 
            // idLabel1
            // 
            this.idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.archivoBindingSource, "id", true));
            this.idLabel1.Location = new System.Drawing.Point(44, 80);
            this.idLabel1.Name = "idLabel1";
            this.idLabel1.Size = new System.Drawing.Size(100, 23);
            this.idLabel1.TabIndex = 17;
            this.idLabel1.Text = "label1";
            // 
            // archivoDataGridView
            // 
            this.archivoDataGridView.AllowUserToAddRows = false;
            this.archivoDataGridView.AllowUserToDeleteRows = false;
            this.archivoDataGridView.AutoGenerateColumns = false;
            this.archivoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.archivoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.archivoDataGridView.DataSource = this.archivoBindingSource;
            this.archivoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.archivoDataGridView.Location = new System.Drawing.Point(0, 0);
            this.archivoDataGridView.Name = "archivoDataGridView";
            this.archivoDataGridView.ReadOnly = true;
            this.archivoDataGridView.Size = new System.Drawing.Size(800, 274);
            this.archivoDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn4.HeaderText = "id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn5.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "realName";
            this.dataGridViewTextBoxColumn6.HeaderText = "realName";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.archivoBindingNavigator);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.archivoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.archivoBindingNavigator)).EndInit();
            this.archivoBindingNavigator.ResumeLayout(false);
            this.archivoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.archivoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button3;
        
        private System.Windows.Forms.TextBox archivoTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label idLabel1;
        private System.Windows.Forms.BindingSource archivoBindingSource;
        private System.Windows.Forms.DataGridView archivoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingNavigator archivoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton archivoBindingNavigatorSaveItem;
    }
}

