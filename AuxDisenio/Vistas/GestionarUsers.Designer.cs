namespace AuxDisenio.Vistas
{
    partial class GestionarUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label ciLabel;
            System.Windows.Forms.Label cuentaLabel;
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciLabel1 = new System.Windows.Forms.Label();
            this.cuentaLabel1 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            ciLabel = new System.Windows.Forms.Label();
            cuentaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.SlateGray;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(514, 390);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(135, 46);
            this.btnEliminar.TabIndex = 27;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.SlateGray;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(305, 390);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(135, 46);
            this.btnModificar.TabIndex = 26;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.SlateGray;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.Location = new System.Drawing.Point(101, 390);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(135, 46);
            this.btnRegistrar.TabIndex = 25;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataSource = typeof(AuxDisenio.Data.Usuarios);
            // 
            // usuariosDataGridView
            // 
            this.usuariosDataGridView.AutoGenerateColumns = false;
            this.usuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuariosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.usuariosDataGridView.DataSource = this.usuariosBindingSource;
            this.usuariosDataGridView.Location = new System.Drawing.Point(12, 82);
            this.usuariosDataGridView.Name = "usuariosDataGridView";
            this.usuariosDataGridView.Size = new System.Drawing.Size(746, 302);
            this.usuariosDataGridView.TabIndex = 28;
            this.usuariosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usuariosDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdUsuario";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdUsuario";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ci";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ci";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Apellido";
            this.dataGridViewTextBoxColumn4.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Cuenta";
            this.dataGridViewTextBoxColumn5.HeaderText = "Cuenta";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Pass";
            this.dataGridViewTextBoxColumn6.HeaderText = "Pass";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TipoUsuario";
            this.dataGridViewTextBoxColumn7.HeaderText = "TipoUsuario";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // ciLabel
            // 
            ciLabel.AutoSize = true;
            ciLabel.Location = new System.Drawing.Point(84, 9);
            ciLabel.Name = "ciLabel";
            ciLabel.Size = new System.Drawing.Size(19, 13);
            ciLabel.TabIndex = 28;
            ciLabel.Text = "Ci:";
            // 
            // ciLabel1
            // 
            this.ciLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Ci", true));
            this.ciLabel1.Location = new System.Drawing.Point(109, 9);
            this.ciLabel1.Name = "ciLabel1";
            this.ciLabel1.Size = new System.Drawing.Size(100, 23);
            this.ciLabel1.TabIndex = 29;
            this.ciLabel1.Text = "label1";
            // 
            // cuentaLabel
            // 
            cuentaLabel.AutoSize = true;
            cuentaLabel.Location = new System.Drawing.Point(86, 36);
            cuentaLabel.Name = "cuentaLabel";
            cuentaLabel.Size = new System.Drawing.Size(44, 13);
            cuentaLabel.TabIndex = 29;
            cuentaLabel.Text = "Cuenta:";
            // 
            // cuentaLabel1
            // 
            this.cuentaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Cuenta", true));
            this.cuentaLabel1.Location = new System.Drawing.Point(136, 36);
            this.cuentaLabel1.Name = "cuentaLabel1";
            this.cuentaLabel1.Size = new System.Drawing.Size(100, 23);
            this.cuentaLabel1.TabIndex = 30;
            this.cuentaLabel1.Text = "label1";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(193, 33);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(515, 20);
            this.txtBusqueda.TabIndex = 31;
            this.txtBusqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtBusqueda_KeyUp);
            // 
            // GestionarUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(cuentaLabel);
            this.Controls.Add(this.cuentaLabel1);
            this.Controls.Add(ciLabel);
            this.Controls.Add(this.ciLabel1);
            this.Controls.Add(this.usuariosDataGridView);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrar);
            this.Name = "GestionarUsers";
            this.Text = "GestionarUsers";
            this.Load += new System.EventHandler(this.frmGestionarUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.Button btnModificar;
        public System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private System.Windows.Forms.DataGridView usuariosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label ciLabel1;
        private System.Windows.Forms.Label cuentaLabel1;
        private System.Windows.Forms.TextBox txtBusqueda;
    }
}