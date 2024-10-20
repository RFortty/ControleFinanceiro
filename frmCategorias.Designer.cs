namespace teste
{
    partial class frmCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategorias));
            this.dgCategorias = new System.Windows.Forms.DataGridView();
            this.gbCategorias = new System.Windows.Forms.GroupBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtModificado = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblModificado = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtCadastrado = new System.Windows.Forms.TextBox();
            this.lblCadastrado = new System.Windows.Forms.Label();
            this.txtCadPor = new System.Windows.Forms.TextBox();
            this.lblCadPor = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategorias)).BeginInit();
            this.gbCategorias.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgCategorias
            // 
            this.dgCategorias.AllowUserToAddRows = false;
            this.dgCategorias.AllowUserToDeleteRows = false;
            this.dgCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgCategorias.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgCategorias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategorias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgCategorias.Location = new System.Drawing.Point(12, 232);
            this.dgCategorias.Name = "dgCategorias";
            this.dgCategorias.ReadOnly = true;
            this.dgCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCategorias.Size = new System.Drawing.Size(507, 273);
            this.dgCategorias.TabIndex = 1;
            this.dgCategorias.TabStop = false;
            this.dgCategorias.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgCategorias_MouseClick);
            // 
            // gbCategorias
            // 
            this.gbCategorias.Controls.Add(this.txtCategoria);
            this.gbCategorias.Controls.Add(this.txtCodigo);
            this.gbCategorias.Controls.Add(this.txtModificado);
            this.gbCategorias.Controls.Add(this.lblCategoria);
            this.gbCategorias.Controls.Add(this.lblModificado);
            this.gbCategorias.Controls.Add(this.lblCodigo);
            this.gbCategorias.Controls.Add(this.btnSalvar);
            this.gbCategorias.Controls.Add(this.txtCadastrado);
            this.gbCategorias.Controls.Add(this.lblCadastrado);
            this.gbCategorias.Location = new System.Drawing.Point(12, 78);
            this.gbCategorias.Name = "gbCategorias";
            this.gbCategorias.Size = new System.Drawing.Size(507, 148);
            this.gbCategorias.TabIndex = 2;
            this.gbCategorias.TabStop = false;
            this.gbCategorias.Text = "Cadastro de Categorias";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(74, 61);
            this.txtCategoria.MaxLength = 50;
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(281, 20);
            this.txtCategoria.TabIndex = 17;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(74, 28);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(54, 20);
            this.txtCodigo.TabIndex = 15;
            // 
            // txtModificado
            // 
            this.txtModificado.Location = new System.Drawing.Point(361, 122);
            this.txtModificado.MaxLength = 100;
            this.txtModificado.Name = "txtModificado";
            this.txtModificado.ReadOnly = true;
            this.txtModificado.Size = new System.Drawing.Size(119, 20);
            this.txtModificado.TabIndex = 21;
            this.txtModificado.TabStop = false;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(6, 64);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(62, 13);
            this.lblCategoria.TabIndex = 18;
            this.lblCategoria.Text = "* Categoria:";
            // 
            // lblModificado
            // 
            this.lblModificado.AutoSize = true;
            this.lblModificado.Location = new System.Drawing.Point(246, 125);
            this.lblModificado.Name = "lblModificado";
            this.lblModificado.Size = new System.Drawing.Size(109, 13);
            this.lblModificado.TabIndex = 22;
            this.lblModificado.Text = "Data de Modificação:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(18, 31);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(50, 13);
            this.lblCodigo.TabIndex = 16;
            this.lblCodigo.Text = "* Código:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::teste.Properties.Resources.filesave;
            this.btnSalvar.Location = new System.Drawing.Point(74, 100);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(93, 42);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtCadastrado
            // 
            this.txtCadastrado.Location = new System.Drawing.Point(361, 89);
            this.txtCadastrado.MaxLength = 100;
            this.txtCadastrado.Name = "txtCadastrado";
            this.txtCadastrado.ReadOnly = true;
            this.txtCadastrado.Size = new System.Drawing.Size(119, 20);
            this.txtCadastrado.TabIndex = 20;
            this.txtCadastrado.TabStop = false;
            // 
            // lblCadastrado
            // 
            this.lblCadastrado.AutoSize = true;
            this.lblCadastrado.Location = new System.Drawing.Point(262, 92);
            this.lblCadastrado.Name = "lblCadastrado";
            this.lblCadastrado.Size = new System.Drawing.Size(93, 13);
            this.lblCadastrado.TabIndex = 19;
            this.lblCadastrado.Text = "Data de Cadastro:";
            // 
            // txtCadPor
            // 
            this.txtCadPor.Location = new System.Drawing.Point(373, 508);
            this.txtCadPor.MaxLength = 100;
            this.txtCadPor.Name = "txtCadPor";
            this.txtCadPor.ReadOnly = true;
            this.txtCadPor.Size = new System.Drawing.Size(119, 20);
            this.txtCadPor.TabIndex = 23;
            this.txtCadPor.TabStop = false;
            // 
            // lblCadPor
            // 
            this.lblCadPor.AutoSize = true;
            this.lblCadPor.Location = new System.Drawing.Point(285, 511);
            this.lblCadPor.Name = "lblCadPor";
            this.lblCadPor.Size = new System.Drawing.Size(82, 13);
            this.lblCadPor.TabIndex = 24;
            this.lblCadPor.Text = "Cadastrado por:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = global::teste.Properties.Resources.eraser;
            this.btnExcluir.Location = new System.Drawing.Point(426, 12);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(93, 42);
            this.btnExcluir.TabIndex = 6;
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
            this.btnAlterar.TabIndex = 5;
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
            this.btnCancelar.TabIndex = 4;
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
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.Text = "&Adicionar";
            this.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 536);
            this.Controls.Add(this.txtCadPor);
            this.Controls.Add(this.lblCadPor);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.gbCategorias);
            this.Controls.Add(this.dgCategorias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".: Cadastro de Categorias :.";
            this.Load += new System.EventHandler(this.frmCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCategorias)).EndInit();
            this.gbCategorias.ResumeLayout(false);
            this.gbCategorias.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCategorias;
        private System.Windows.Forms.GroupBox gbCategorias;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtModificado;
        private System.Windows.Forms.Label lblModificado;
        private System.Windows.Forms.TextBox txtCadastrado;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCadastrado;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCadPor;
        private System.Windows.Forms.Label lblCadPor;

    }
}