namespace AuxDisenio.Vistas
{
    partial class frmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label ciLabel;
            System.Windows.Forms.Label cuentaLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label passLabel;
            System.Windows.Forms.Label tipoUsuarioLabel;
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.usuariosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.ciTextBox = new System.Windows.Forms.TextBox();
            this.cuentaTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.tipoUsuarioTextBox = new System.Windows.Forms.TextBox();
            apellidoLabel = new System.Windows.Forms.Label();
            ciLabel = new System.Windows.Forms.Label();
            cuentaLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            passLabel = new System.Windows.Forms.Label();
            tipoUsuarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Gray;
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.LightGray;
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(40, 225);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(135, 40);
            this.btnAceptar.TabIndex = 19;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Gray;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.LightGray;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(192, 225);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(141, 40);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 31);
            this.label1.TabIndex = 20;
            this.label1.Text = "GESTION USUARIOS";
            // 
            // usuariosBindingSource1
            // 
            this.usuariosBindingSource1.DataSource = typeof(AuxDisenio.Data.Usuarios);
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new System.Drawing.Point(447, 121);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(47, 13);
            apellidoLabel.TabIndex = 20;
            apellidoLabel.Text = "Apellido:";
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource1, "Apellido", true));
            this.apellidoTextBox.Location = new System.Drawing.Point(523, 118);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(100, 20);
            this.apellidoTextBox.TabIndex = 21;
            // 
            // ciLabel
            // 
            ciLabel.AutoSize = true;
            ciLabel.Location = new System.Drawing.Point(447, 147);
            ciLabel.Name = "ciLabel";
            ciLabel.Size = new System.Drawing.Size(19, 13);
            ciLabel.TabIndex = 22;
            ciLabel.Text = "Ci:";
            // 
            // ciTextBox
            // 
            this.ciTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource1, "Ci", true));
            this.ciTextBox.Location = new System.Drawing.Point(523, 144);
            this.ciTextBox.Name = "ciTextBox";
            this.ciTextBox.Size = new System.Drawing.Size(100, 20);
            this.ciTextBox.TabIndex = 23;
            // 
            // cuentaLabel
            // 
            cuentaLabel.AutoSize = true;
            cuentaLabel.Location = new System.Drawing.Point(447, 173);
            cuentaLabel.Name = "cuentaLabel";
            cuentaLabel.Size = new System.Drawing.Size(44, 13);
            cuentaLabel.TabIndex = 24;
            cuentaLabel.Text = "Cuenta:";
            // 
            // cuentaTextBox
            // 
            this.cuentaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource1, "Cuenta", true));
            this.cuentaTextBox.Location = new System.Drawing.Point(523, 170);
            this.cuentaTextBox.Name = "cuentaTextBox";
            this.cuentaTextBox.Size = new System.Drawing.Size(100, 20);
            this.cuentaTextBox.TabIndex = 25;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(447, 199);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 26;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource1, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(523, 196);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 27;
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.Location = new System.Drawing.Point(447, 225);
            passLabel.Name = "passLabel";
            passLabel.Size = new System.Drawing.Size(33, 13);
            passLabel.TabIndex = 28;
            passLabel.Text = "Pass:";
            // 
            // passTextBox
            // 
            this.passTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource1, "Pass", true));
            this.passTextBox.Location = new System.Drawing.Point(523, 222);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(100, 20);
            this.passTextBox.TabIndex = 29;
            // 
            // tipoUsuarioLabel
            // 
            tipoUsuarioLabel.AutoSize = true;
            tipoUsuarioLabel.Location = new System.Drawing.Point(447, 251);
            tipoUsuarioLabel.Name = "tipoUsuarioLabel";
            tipoUsuarioLabel.Size = new System.Drawing.Size(70, 13);
            tipoUsuarioLabel.TabIndex = 30;
            tipoUsuarioLabel.Text = "Tipo Usuario:";
            // 
            // tipoUsuarioTextBox
            // 
            this.tipoUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource1, "TipoUsuario", true));
            this.tipoUsuarioTextBox.Location = new System.Drawing.Point(523, 248);
            this.tipoUsuarioTextBox.Name = "tipoUsuarioTextBox";
            this.tipoUsuarioTextBox.Size = new System.Drawing.Size(100, 20);
            this.tipoUsuarioTextBox.TabIndex = 31;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(659, 533);
            this.Controls.Add(apellidoLabel);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(ciLabel);
            this.Controls.Add(this.ciTextBox);
            this.Controls.Add(cuentaLabel);
            this.Controls.Add(this.cuentaTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(passLabel);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(tipoUsuarioLabel);
            this.Controls.Add(this.tipoUsuarioTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Name = "frmUsuario";
            this.Text = "frmUsuario";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        public System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.BindingSource usuariosBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox ciTextBox;
        private System.Windows.Forms.TextBox cuentaTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.TextBox tipoUsuarioTextBox;
    }
}