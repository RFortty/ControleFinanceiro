namespace teste
{
    partial class frmSubCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSubCategorias));
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.gbCategorias = new System.Windows.Forms.GroupBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.lblSubCategoria = new System.Windows.Forms.Label();
            this.txtModificado = new System.Windows.Forms.TextBox();
            this.lblModificado = new System.Windows.Forms.Label();
            this.txtCadastrado = new System.Windows.Forms.TextBox();
            this.lblCadastrado = new System.Windows.Forms.Label();
            this.txtSubCategoria = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.dgSubCategorias = new System.Windows.Forms.DataGridView();
            this.txtCadPor = new System.Windows.Forms.TextBox();
            this.lblCadPor = new System.Windows.Forms.Label();
            this.gbCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSubCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = global::teste.Properties.Resources.eraser;
            this.btnExcluir.Location = new System.Drawing.Point(426, 12);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(93, 42);
            this.btnExcluir.TabIndex = 12;
            this.btnExcluir.Text = "E&xcluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = global::teste.Properties.Resources.korganizer;
            this.btnAlterar.Location = new System.Drawing.Point(284, 12);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(93, 42);
            this.btnAlterar.TabIndex = 11;
            this.btnAlterar.Text = "A&lterar";
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::teste.Properties.Resources.button_cancel;
            this.btnCancelar.Location = new System.Drawing.Point(146, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 42);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Image = global::teste.Properties.Resources.plus;
            this.btnAdicionar.Location = new System.Drawing.Point(12, 12);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(93, 42);
            this.btnAdicionar.TabIndex = 9;
            this.btnAdicionar.Text = "&Adicionar";
            this.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // gbCategorias
            // 
            this.gbCategorias.Controls.Add(this.cbCategoria);
            this.gbCategorias.Controls.Add(this.lblSubCategoria);
            this.gbCategorias.Controls.Add(this.txtModificado);
            this.gbCategorias.Controls.Add(this.lblModificado);
            this.gbCategorias.Controls.Add(this.txtCadastrado);
            this.gbCategorias.Controls.Add(this.lblCadastrado);
            this.gbCategorias.Controls.Add(this.txtSubCategoria);
            this.gbCategorias.Controls.Add(this.btnSalvar);
            this.gbCategorias.Controls.Add(this.txtCodigo);
            this.gbCategorias.Controls.Add(this.lblCodigo);
            this.gbCategorias.Controls.Add(this.lblCategoria);
            this.gbCategorias.Location = new System.Drawing.Point(12, 78);
            this.gbCategorias.Name = "gbCategorias";
            this.gbCategorias.Size = new System.Drawing.Size(507, 199);
            this.gbCategorias.TabIndex = 8;
            this.gbCategorias.TabStop = false;
            this.gbCategorias.Text = "Cadastro de Categorias";
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(100, 62);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbCategoria.TabIndex = 28;
            // 
            // lblSubCategoria
            // 
            this.lblSubCategoria.AutoSize = true;
            this.lblSubCategoria.Location = new System.Drawing.Point(10, 99);
            this.lblSubCategoria.Name = "lblSubCategoria";
            this.lblSubCategoria.Size = new System.Drawing.Size(84, 13);
            this.lblSubCategoria.TabIndex = 27;
            this.lblSubCategoria.Text = "* Sub-Categoria:";
            // 
            // txtModificado
            // 
            this.txtModificado.Location = new System.Drawing.Point(368, 160);
            this.txtModificado.MaxLength = 100;
            this.txtModificado.Name = "txtModificado";
            this.txtModificado.ReadOnly = true;
            this.txtModificado.Size = new System.Drawing.Size(119, 20);
            this.txtModificado.TabIndex = 25;
            this.txtModificado.TabStop = false;
            // 
            // lblModificado
            // 
            this.lblModificado.AutoSize = true;
            this.lblModificado.Location = new System.Drawing.Point(253, 163);
            this.lblModificado.Name = "lblModificado";
            this.lblModificado.Size = new System.Drawing.Size(109, 13);
            this.lblModificado.TabIndex = 26;
            this.lblModificado.Text = "Data de Modificação:";
            // 
            // txtCadastrado
            // 
            this.txtCadastrado.Location = new System.Drawing.Point(368, 127);
            this.txtCadastrado.MaxLength = 100;
            this.txtCadastrado.Name = "txtCadastrado";
            this.txtCadastrado.ReadOnly = true;
            this.txtCadastrado.Size = new System.Drawing.Size(119, 20);
            this.txtCadastrado.TabIndex = 24;
            this.txtCadastrado.TabStop = false;
            // 
            // lblCadastrado
            // 
            this.lblCadastrado.AutoSize = true;
            this.lblCadastrado.Location = new System.Drawing.Point(269, 130);
            this.lblCadastrado.Name = "lblCadastrado";
            this.lblCadastrado.Size = new System.Drawing.Size(93, 13);
            this.lblCadastrado.TabIndex = 23;
            this.lblCadastrado.Text = "Data de Cadastro:";
            // 
            // txtSubCategoria
            // 
            this.txtSubCategoria.Location = new System.Drawing.Point(100, 96);
            this.txtSubCategoria.MaxLength = 50;
            this.txtSubCategoria.Name = "txtSubCategoria";
            this.txtSubCategoria.Size = new System.Drawing.Size(268, 20);
            this.txtSubCategoria.TabIndex = 21;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::teste.Properties.Resources.filesave;
            this.btnSalvar.Location = new System.Drawing.Point(85, 138);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(93, 42);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(100, 29);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(54, 20);
            this.txtCodigo.TabIndex = 19;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(44, 32);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(50, 13);
            this.lblCodigo.TabIndex = 20;
            this.lblCodigo.Text = "* Código:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(32, 65);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(62, 13);
            this.lblCategoria.TabIndex = 22;
            this.lblCategoria.Text = "* Categoria:";
            // 
            // dgSubCategorias
            // 
            this.dgSubCategorias.AllowUserToAddRows = false;
            this.dgSubCategorias.AllowUserToDeleteRows = false;
            this.dgSubCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgSubCategorias.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgSubCategorias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgSubCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSubCategorias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgSubCategorias.Location = new System.Drawing.Point(12, 283);
            this.dgSubCategorias.Name = "dgSubCategorias";
            this.dgSubCategorias.ReadOnly = true;
            this.dgSubCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSubCategorias.Size = new System.Drawing.Size(507, 222);
            this.dgSubCategorias.TabIndex = 7;
            this.dgSubCategorias.TabStop = false;
            this.dgSubCategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSubCategorias_CellContentClick);
            // 
            // txtCadPor
            // 
            this.txtCadPor.Location = new System.Drawing.Point(384, 514);
            this.txtCadPor.MaxLength = 100;
            this.txtCadPor.Name = "txtCadPor";
            this.txtCadPor.ReadOnly = true;
            this.txtCadPor.Size = new System.Drawing.Size(119, 20);
            this.txtCadPor.TabIndex = 25;
            this.txtCadPor.TabStop = false;
            // 
            // lblCadPor
            // 
            this.lblCadPor.AutoSize = true;
            this.lblCadPor.Location = new System.Drawing.Point(296, 517);
            this.lblCadPor.Name = "lblCadPor";
            this.lblCadPor.Size = new System.Drawing.Size(82, 13);
            this.lblCadPor.TabIndex = 26;
            this.lblCadPor.Text = "Cadastrado por:";
            // 
            // frmSubCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 543);
            this.Controls.Add(this.txtCadPor);
            this.Controls.Add(this.lblCadPor);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.gbCategorias);
            this.Controls.Add(this.dgSubCategorias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSubCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".: Cadastro de Sub-Categorias :.";
            this.Load += new System.EventHandler(this.frmSubCategorias_Load);
            this.gbCategorias.ResumeLayout(false);
            this.gbCategorias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSubCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.GroupBox gbCategorias;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dgSubCategorias;
        private System.Windows.Forms.TextBox txtSubCategoria;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtModificado;
        private System.Windows.Forms.Label lblModificado;
        private System.Windows.Forms.TextBox txtCadastrado;
        private System.Windows.Forms.Label lblCadastrado;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label lblSubCategoria;
        private System.Windows.Forms.TextBox txtCadPor;
        private System.Windows.Forms.Label lblCadPor;
    }
}