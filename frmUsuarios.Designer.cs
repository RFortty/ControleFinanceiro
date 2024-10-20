namespace teste
{
    partial class frmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            this.dgUsuarios = new System.Windows.Forms.DataGridView();
            this.gbUsuarios = new System.Windows.Forms.GroupBox();
            this.cbNivel = new System.Windows.Forms.ComboBox();
            this.lblNivel = new System.Windows.Forms.Label();
            this.txtModificado = new System.Windows.Forms.TextBox();
            this.lblModificado = new System.Windows.Forms.Label();
            this.txtCadastrado = new System.Windows.Forms.TextBox();
            this.txtCSenha = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblCadastrado = new System.Windows.Forms.Label();
            this.lblCSenha = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtCadPor = new System.Windows.Forms.TextBox();
            this.lblCadPor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).BeginInit();
            this.gbUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgUsuarios
            // 
            this.dgUsuarios.AllowUserToAddRows = false;
            this.dgUsuarios.AllowUserToDeleteRows = false;
            this.dgUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgUsuarios.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsuarios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgUsuarios.Location = new System.Drawing.Point(12, 298);
            this.dgUsuarios.Name = "dgUsuarios";
            this.dgUsuarios.ReadOnly = true;
            this.dgUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUsuarios.Size = new System.Drawing.Size(509, 231);
            this.dgUsuarios.TabIndex = 0;
            this.dgUsuarios.TabStop = false;
            this.dgUsuarios.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgUsuarios_MouseClick);
            // 
            // gbUsuarios
            // 
            this.gbUsuarios.Controls.Add(this.cbNivel);
            this.gbUsuarios.Controls.Add(this.lblNivel);
            this.gbUsuarios.Controls.Add(this.txtModificado);
            this.gbUsuarios.Controls.Add(this.lblModificado);
            this.gbUsuarios.Controls.Add(this.txtCadastrado);
            this.gbUsuarios.Controls.Add(this.txtCSenha);
            this.gbUsuarios.Controls.Add(this.txtSenha);
            this.gbUsuarios.Controls.Add(this.txtUsuario);
            this.gbUsuarios.Controls.Add(this.txtid);
            this.gbUsuarios.Controls.Add(this.lblCadastrado);
            this.gbUsuarios.Controls.Add(this.lblCSenha);
            this.gbUsuarios.Controls.Add(this.lblSenha);
            this.gbUsuarios.Controls.Add(this.lblUsuario);
            this.gbUsuarios.Controls.Add(this.lblID);
            this.gbUsuarios.Location = new System.Drawing.Point(12, 74);
            this.gbUsuarios.Name = "gbUsuarios";
            this.gbUsuarios.Size = new System.Drawing.Size(509, 218);
            this.gbUsuarios.TabIndex = 1;
            this.gbUsuarios.TabStop = false;
            this.gbUsuarios.Text = "Cadastro de Usuários";
            // 
            // cbNivel
            // 
            this.cbNivel.FormattingEnabled = true;
            this.cbNivel.Items.AddRange(new object[] {
            "Administrador",
            "Usuário"});
            this.cbNivel.Location = new System.Drawing.Point(253, 70);
            this.cbNivel.Name = "cbNivel";
            this.cbNivel.Size = new System.Drawing.Size(121, 21);
            this.cbNivel.TabIndex = 2;
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Location = new System.Drawing.Point(151, 73);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(96, 13);
            this.lblNivel.TabIndex = 12;
            this.lblNivel.Text = "* Nível de Acesso:";
            // 
            // txtModificado
            // 
            this.txtModificado.Location = new System.Drawing.Point(342, 140);
            this.txtModificado.MaxLength = 100;
            this.txtModificado.Name = "txtModificado";
            this.txtModificado.ReadOnly = true;
            this.txtModificado.Size = new System.Drawing.Size(119, 20);
            this.txtModificado.TabIndex = 6;
            this.txtModificado.TabStop = false;
            // 
            // lblModificado
            // 
            this.lblModificado.AutoSize = true;
            this.lblModificado.Location = new System.Drawing.Point(227, 143);
            this.lblModificado.Name = "lblModificado";
            this.lblModificado.Size = new System.Drawing.Size(109, 13);
            this.lblModificado.TabIndex = 10;
            this.lblModificado.Text = "Data de Modificação:";
            // 
            // txtCadastrado
            // 
            this.txtCadastrado.Location = new System.Drawing.Point(342, 107);
            this.txtCadastrado.MaxLength = 100;
            this.txtCadastrado.Name = "txtCadastrado";
            this.txtCadastrado.ReadOnly = true;
            this.txtCadastrado.Size = new System.Drawing.Size(119, 20);
            this.txtCadastrado.TabIndex = 5;
            this.txtCadastrado.TabStop = false;
            // 
            // txtCSenha
            // 
            this.txtCSenha.Location = new System.Drawing.Point(112, 140);
            this.txtCSenha.MaxLength = 8;
            this.txtCSenha.Name = "txtCSenha";
            this.txtCSenha.PasswordChar = '*';
            this.txtCSenha.Size = new System.Drawing.Size(100, 20);
            this.txtCSenha.TabIndex = 4;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(112, 107);
            this.txtSenha.MaxLength = 8;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 3;
            // 
            // txtUsuario
            // 
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsuario.Location = new System.Drawing.Point(253, 33);
            this.txtUsuario.MaxLength = 50;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(153, 20);
            this.txtUsuario.TabIndex = 1;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(112, 33);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(54, 20);
            this.txtid.TabIndex = 0;
            // 
            // lblCadastrado
            // 
            this.lblCadastrado.AutoSize = true;
            this.lblCadastrado.Location = new System.Drawing.Point(243, 110);
            this.lblCadastrado.Name = "lblCadastrado";
            this.lblCadastrado.Size = new System.Drawing.Size(93, 13);
            this.lblCadastrado.TabIndex = 4;
            this.lblCadastrado.Text = "Data de Cadastro:";
            // 
            // lblCSenha
            // 
            this.lblCSenha.AutoSize = true;
            this.lblCSenha.Location = new System.Drawing.Point(11, 143);
            this.lblCSenha.Name = "lblCSenha";
            this.lblCSenha.Size = new System.Drawing.Size(95, 13);
            this.lblCSenha.TabIndex = 3;
            this.lblCSenha.Text = "* Confirmar Senha:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(58, 110);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(48, 13);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "* Senha:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(194, 36);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(53, 13);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "* Usuário:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(78, 36);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(28, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "* ID:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::teste.Properties.Resources.filesave;
            this.btnSalvar.Location = new System.Drawing.Point(207, 249);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(93, 42);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::teste.Properties.Resources.button_cancel;
            this.btnCancelar.Location = new System.Drawing.Point(150, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 42);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = global::teste.Properties.Resources.eraser;
            this.btnExcluir.Location = new System.Drawing.Point(426, 12);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(93, 42);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "E&xcluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = global::teste.Properties.Resources.korganizer;
            this.btnAlterar.Location = new System.Drawing.Point(293, 12);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(93, 42);
            this.btnAlterar.TabIndex = 10;
            this.btnAlterar.Text = "A&lterar";
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Image = global::teste.Properties.Resources.plus;
            this.btnAdicionar.Location = new System.Drawing.Point(12, 12);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(93, 42);
            this.btnAdicionar.TabIndex = 8;
            this.btnAdicionar.Text = "&Adicionar";
            this.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtCadPor
            // 
            this.txtCadPor.Location = new System.Drawing.Point(354, 552);
            this.txtCadPor.MaxLength = 100;
            this.txtCadPor.Name = "txtCadPor";
            this.txtCadPor.ReadOnly = true;
            this.txtCadPor.Size = new System.Drawing.Size(119, 20);
            this.txtCadPor.TabIndex = 13;
            this.txtCadPor.TabStop = false;
            // 
            // lblCadPor
            // 
            this.lblCadPor.AutoSize = true;
            this.lblCadPor.Location = new System.Drawing.Point(266, 555);
            this.lblCadPor.Name = "lblCadPor";
            this.lblCadPor.Size = new System.Drawing.Size(82, 13);
            this.lblCadPor.TabIndex = 14;
            this.lblCadPor.Text = "Cadastrado por:";
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 584);
            this.Controls.Add(this.txtCadPor);
            this.Controls.Add(this.lblCadPor);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.gbUsuarios);
            this.Controls.Add(this.dgUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".: Cadastro de Usuários :.";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).EndInit();
            this.gbUsuarios.ResumeLayout(false);
            this.gbUsuarios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUsuarios;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtModificado;
        private System.Windows.Forms.Label lblModificado;
        private System.Windows.Forms.TextBox txtCadastrado;
        private System.Windows.Forms.TextBox txtCSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblCadastrado;
        private System.Windows.Forms.Label lblCSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ComboBox cbNivel;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dgUsuarios;
        private System.Windows.Forms.TextBox txtCadPor;
        private System.Windows.Forms.Label lblCadPor;
    }
}